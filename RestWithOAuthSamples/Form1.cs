using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Thinktecture.IdentityModel.Client;

namespace RestWithOAuthSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetOAuthToken_Click(object sender, EventArgs e)
        {
            textBoxToken.Text = string.Empty;
            try
            {
                // Getting a Token
                string uri = textBoxTokenEndpoint.Text;
                string clientid = textBoxClientId.Text;
                string secret = textBoxSecret.Text;
                string theToken = string.Empty;
                long HowLongTillExpires = long.MinValue;

                if(radioButtonThinkTecture.Checked)
                {
                    // Using the Thinktecture.IdentityModel.Client
                    var client = new OAuth2Client(
                        new Uri(uri),
                        clientid,
                        secret);

                    // For Thinktecture the "scope" request is passed in.
                    var response = client.RequestClientCredentialsAsync("read write").Result;

                    // At this point we now have the AccessToken in the response
                    theToken = response.AccessToken;
                    HowLongTillExpires = response.ExpiresIn;
                }
                else if(radioButtonStandardHttpClient.Checked)
                {
                    // Using standard http, we can make the call with Basic Authorization header
                    // We need to encode the "scope" as formUrlEncoded body
                    // First prepare the Base64Encode string for Basic Auth
                    string data = string.Format("{0}:{1}", clientid, secret);
                    byte[] binaryData = System.Text.Encoding.UTF8.GetBytes(data);
                    string authorizationString = System.Convert.ToBase64String(binaryData, 0, binaryData.Length);

                    using (var client = new HttpClient())
                    {
                        //Add Basic Authorization header for call to get OAuth token.
                        client.SetToken("Basic", authorizationString);

                        //Create specific request to send
                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);

                        //Pass in oAuth "grant_type" as "client credentials" and "scope" as "read write" 
                        //These must be application-form-url-encoded
                        List<KeyValuePair<string, string>> bodyContentList = new List<KeyValuePair<string, string>>();
                        bodyContentList.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
                        bodyContentList.Add(new KeyValuePair<string, string>("scope", "read write"));
                        request.Content = new FormUrlEncodedContent(bodyContentList);

                        //Send request
                        HttpResponseMessage response = client.SendAsync(request).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            string oAuthResponseString = response.Content.ReadAsStringAsync().Result;

                            //An example of using dynamic keyword and accessing properties ("access_token" and "expires_in") at runtime. 
                            dynamic oAuthToken = JsonConvert.DeserializeObject(oAuthResponseString);
                            theToken = oAuthToken.access_token;
                            HowLongTillExpires = oAuthToken.expires_in;
                        }
                        else
                        {
                            throw new System.Exception("Unable to acquire token.");
                        }
                    }

                }
                else
                {
                    throw new Exception("Invalid Client selected");
                }

                textBoxToken.Text = theToken;
                textBoxExpiresInSeconds.Text = HowLongTillExpires.ToString();

            }
            catch(System.Exception exp)
            {
                textBoxToken.Text = string.Format("Unable to get token.{0}{1}", System.Environment.NewLine, exp.ToString());
            }

        }

        private void buttonShowDecodedToken_Click(object sender, EventArgs e)
        {
            textBoxDecodedToken.Text = string.Empty;
            if (string.IsNullOrEmpty(textBoxToken.Text))
            {
                textBoxToken.Text = "Please get a valid Token!";
                return;
            }

            try
            {
                string theToken = textBoxToken.Text;

                // The token is comprised of 2 parts, lets split them into the 2 parts, the header and the body/claims
                var parts = theToken.Split('.');
                var header = parts[0];
                var claims = parts[1];

                var jsonhead = JObject.Parse(Encoding.UTF8.GetString(Base64Url.Decode(header)));
                var jsondata = JObject.Parse(Encoding.UTF8.GetString(Base64Url.Decode(claims)));


                string output = String.Format("Token header: {2}{0}{2}Token claims: {2}{1}{2}", jsonhead.ToString(), jsondata.ToString(), Environment.NewLine);

                textBoxDecodedToken.Text = output;

            }
            catch (System.Exception exp)
            {
                textBoxDecodedToken.Text = string.Format("Unable to decode token.{0}{1}", System.Environment.NewLine, exp.ToString());
            }
        }

        private void buttonCallService_Click(object sender, EventArgs e)
        {
            textBoxServiceResponse.Text = string.Empty;
            try
            {
                string output = string.Empty;
                bool includeToken = checkBoxIncludeBearerToken.Checked;
                string acceptHeader = textBoxAcceptHeader.Text;
                string accessToken = textBoxToken.Text;
                string verb = textBoxHttpVerb.Text;
                string url = string.Format("{0}?api_key={1}", textBoxServiceUrl.Text, textBoxMasheryApiKey.Text);

                using (var client = new HttpClient())
                {
                    //Add default headers for every request from this http client
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptHeader));
                    if (includeToken)
                        client.SetToken("Bearer", accessToken);

                    //Create specific request to send
                    HttpRequestMessage request = new HttpRequestMessage(new HttpMethod(verb), url);

                    //Add specific header to this request
                    request.Headers.Add("x-cim-RequestId", Guid.NewGuid().ToString());

                    //Send request
                    HttpResponseMessage response = client.SendAsync(request).Result;
                    if(response.IsSuccessStatusCode)
                    {
                        string test = response.Content.ReadAsStringAsync().Result;
                        output = test;
                    }
                    else{
                        output = string.Format("StatusCode: {0}", response.StatusCode.ToString());
                    }
                }

                textBoxServiceResponse.Text = output;

            }
            catch(System.Exception exp)
            {
                MessageBox.Show(string.Format("{0}", exp.ToString()));
            }
        }

        private void buttonParseAsJson_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = string.Empty;
            textBoxMessageId.Text = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(textBoxServiceResponse.Text))
                {
                    textBoxServiceResponse.Text = "Please call a service so there is something to parse!";
                    return;
                }
                string responseValue = textBoxServiceResponse.Text;
                //Example showing deserialize to .NET type
                TestMessage testobj = JsonConvert.DeserializeObject<TestMessage>(responseValue);
                textBoxMessage.Text = testobj.Message;
                textBoxMessageId.Text = testobj.MessageId;

            }
            catch (System.Exception exp)
            {
                MessageBox.Show(string.Format("Unable to parse service response as json.{0}{1}", System.Environment.NewLine, exp.ToString()));
            }

        }

        private void buttonValidateToken_Click(object sender, EventArgs e)
        {
            // Note: this example shows validating the token by checking valid token issuer and lifetime.
            // This should be expanded to confirm the token has not been tampered with.

            if (string.IsNullOrEmpty(textBoxToken.Text))
            {
                textBoxToken.Text = "Please get a valid Token!";
                return;
            }
            try
            {
                bool validIssuer = false;
                bool validExpiration = false;

                var parts = textBoxToken.Text.Split('.');
                var header = parts[0];
                var claims = parts[1];


                var jsonhead = JObject.Parse(Encoding.UTF8.GetString(Base64UrlDecode(header)));
                var jsondata = JObject.Parse(Encoding.UTF8.GetString(Base64UrlDecode(claims)));

                dynamic jheader = JsonConvert.DeserializeObject(jsonhead.ToString());
                dynamic jdata = JsonConvert.DeserializeObject(jsondata.ToString());

                string algo = jheader.alg;
                string clientid = jdata.clientid;
                dynamic scope = jdata.scope;
                string iss = jdata.iss;

                if (string.Compare(iss, textBoxExpectedIssuer.Text, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    validIssuer = true;
                }

                Int32 startTime = jdata.nbf;
                Int32 endTime = jdata.exp;
                DateTime dtValidUntil = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(endTime / 1d)).ToLocalTime();

                if(dtValidUntil > System.DateTime.Now)
                {
                    validExpiration = true;
                }

                if(validIssuer && validExpiration)
                {
                    MessageBox.Show(string.Format("Token is valid and will expire after: {0}", dtValidUntil.ToString("yyyy-MM-ddThh:mm:ss tt")));
                }
                else
                {
                    MessageBox.Show(string.Format("Token is NOT valid and will expire after: {0}", dtValidUntil.ToString()));
                }

            }
            catch (System.Exception exp)
            {
                MessageBox.Show(string.Format("Unable to validate token.{0}{1}", System.Environment.NewLine, exp.ToString()));
            }

        }

        private static byte[] Base64UrlDecode(string arg)
        {
            string s = arg;
            s = s.Replace('-', '+'); 
            s = s.Replace('_', '/'); 

            switch (s.Length % 4) 
            {
                case 0: break; 
                case 2: s += "=="; break; 
                case 3: s += "="; break; 
                default: throw new Exception("Not a valid base64url string.");
            }

            return Convert.FromBase64String(s); 
        }

    }
}
