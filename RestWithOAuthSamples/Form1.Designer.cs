namespace RestWithOAuthSamples
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetOAuthToken = new System.Windows.Forms.Button();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.textBoxTokenEndpoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxExpiresInSeconds = new System.Windows.Forms.TextBox();
            this.buttonShowDecodedToken = new System.Windows.Forms.Button();
            this.buttonCallService = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAcceptHeader = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHttpVerb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxServiceUrl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxServiceResponse = new System.Windows.Forms.TextBox();
            this.checkBoxIncludeBearerToken = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMasheryApiKey = new System.Windows.Forms.TextBox();
            this.buttonParseAsJson = new System.Windows.Forms.Button();
            this.textBoxDecodedToken = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxMessageId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxExpectedIssuer = new System.Windows.Forms.TextBox();
            this.buttonValidateToken = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonThinkTecture = new System.Windows.Forms.RadioButton();
            this.radioButtonStandardHttpClient = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetOAuthToken
            // 
            this.buttonGetOAuthToken.Location = new System.Drawing.Point(40, 283);
            this.buttonGetOAuthToken.Name = "buttonGetOAuthToken";
            this.buttonGetOAuthToken.Size = new System.Drawing.Size(184, 23);
            this.buttonGetOAuthToken.TabIndex = 0;
            this.buttonGetOAuthToken.Text = "Get OAuth Token";
            this.buttonGetOAuthToken.UseVisualStyleBackColor = true;
            this.buttonGetOAuthToken.Click += new System.EventHandler(this.buttonGetOAuthToken_Click);
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(29, 138);
            this.textBoxToken.Multiline = true;
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxToken.Size = new System.Drawing.Size(477, 139);
            this.textBoxToken.TabIndex = 1;
            // 
            // textBoxTokenEndpoint
            // 
            this.textBoxTokenEndpoint.Location = new System.Drawing.Point(128, 37);
            this.textBoxTokenEndpoint.Name = "textBoxTokenEndpoint";
            this.textBoxTokenEndpoint.Size = new System.Drawing.Size(378, 20);
            this.textBoxTokenEndpoint.TabIndex = 2;
            this.textBoxTokenEndpoint.Text = "https://api2.compassion.com/core/connect/token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Get OAuth Token (for client)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "OAuth Endpoint:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client Id:";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(128, 60);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(378, 20);
            this.textBoxClientId.TabIndex = 5;
            this.textBoxClientId.Text = "client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Secret:";
            // 
            // textBoxSecret
            // 
            this.textBoxSecret.Location = new System.Drawing.Point(128, 84);
            this.textBoxSecret.Name = "textBoxSecret";
            this.textBoxSecret.PasswordChar = '*';
            this.textBoxSecret.Size = new System.Drawing.Size(378, 20);
            this.textBoxSecret.TabIndex = 7;
            this.textBoxSecret.Text = "secret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Token:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Expires in (sec):";
            // 
            // textBoxExpiresInSeconds
            // 
            this.textBoxExpiresInSeconds.Location = new System.Drawing.Point(345, 285);
            this.textBoxExpiresInSeconds.Name = "textBoxExpiresInSeconds";
            this.textBoxExpiresInSeconds.Size = new System.Drawing.Size(123, 20);
            this.textBoxExpiresInSeconds.TabIndex = 10;
            // 
            // buttonShowDecodedToken
            // 
            this.buttonShowDecodedToken.Location = new System.Drawing.Point(548, 112);
            this.buttonShowDecodedToken.Name = "buttonShowDecodedToken";
            this.buttonShowDecodedToken.Size = new System.Drawing.Size(184, 23);
            this.buttonShowDecodedToken.TabIndex = 12;
            this.buttonShowDecodedToken.Text = "Show Decoded Token";
            this.buttonShowDecodedToken.UseVisualStyleBackColor = true;
            this.buttonShowDecodedToken.Click += new System.EventHandler(this.buttonShowDecodedToken_Click);
            // 
            // buttonCallService
            // 
            this.buttonCallService.Location = new System.Drawing.Point(40, 667);
            this.buttonCallService.Name = "buttonCallService";
            this.buttonCallService.Size = new System.Drawing.Size(184, 23);
            this.buttonCallService.TabIndex = 13;
            this.buttonCallService.Text = "Call REST Service";
            this.buttonCallService.UseVisualStyleBackColor = true;
            this.buttonCallService.Click += new System.EventHandler(this.buttonCallService_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Accept: ";
            // 
            // textBoxAcceptHeader
            // 
            this.textBoxAcceptHeader.Location = new System.Drawing.Point(128, 459);
            this.textBoxAcceptHeader.Name = "textBoxAcceptHeader";
            this.textBoxAcceptHeader.Size = new System.Drawing.Size(378, 20);
            this.textBoxAcceptHeader.TabIndex = 18;
            this.textBoxAcceptHeader.Text = "application/json";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "HTTP VERB:";
            // 
            // textBoxHttpVerb
            // 
            this.textBoxHttpVerb.Location = new System.Drawing.Point(128, 435);
            this.textBoxHttpVerb.Name = "textBoxHttpVerb";
            this.textBoxHttpVerb.Size = new System.Drawing.Size(378, 20);
            this.textBoxHttpVerb.TabIndex = 16;
            this.textBoxHttpVerb.Text = "GET";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "REST Endpoint:";
            // 
            // textBoxServiceUrl
            // 
            this.textBoxServiceUrl.Location = new System.Drawing.Point(128, 390);
            this.textBoxServiceUrl.Name = "textBoxServiceUrl";
            this.textBoxServiceUrl.Size = new System.Drawing.Size(378, 20);
            this.textBoxServiceUrl.TabIndex = 14;
            this.textBoxServiceUrl.Text = "https://api2.compassion.com/TEST/CI/1/Test";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Call Secure REST Service (for client)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 486);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Response: ";
            // 
            // textBoxServiceResponse
            // 
            this.textBoxServiceResponse.Location = new System.Drawing.Point(29, 502);
            this.textBoxServiceResponse.Multiline = true;
            this.textBoxServiceResponse.Name = "textBoxServiceResponse";
            this.textBoxServiceResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxServiceResponse.Size = new System.Drawing.Size(477, 159);
            this.textBoxServiceResponse.TabIndex = 21;
            // 
            // checkBoxIncludeBearerToken
            // 
            this.checkBoxIncludeBearerToken.AutoSize = true;
            this.checkBoxIncludeBearerToken.Checked = true;
            this.checkBoxIncludeBearerToken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeBearerToken.Location = new System.Drawing.Point(345, 481);
            this.checkBoxIncludeBearerToken.Name = "checkBoxIncludeBearerToken";
            this.checkBoxIncludeBearerToken.Size = new System.Drawing.Size(123, 17);
            this.checkBoxIncludeBearerToken.TabIndex = 23;
            this.checkBoxIncludeBearerToken.Text = "include bearer token";
            this.checkBoxIncludeBearerToken.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "API Key:";
            // 
            // textBoxMasheryApiKey
            // 
            this.textBoxMasheryApiKey.Location = new System.Drawing.Point(128, 412);
            this.textBoxMasheryApiKey.Name = "textBoxMasheryApiKey";
            this.textBoxMasheryApiKey.Size = new System.Drawing.Size(378, 20);
            this.textBoxMasheryApiKey.TabIndex = 24;
            this.textBoxMasheryApiKey.Text = "f5asdkyht67xg37mff9xqpaa";
            // 
            // buttonParseAsJson
            // 
            this.buttonParseAsJson.Location = new System.Drawing.Point(548, 475);
            this.buttonParseAsJson.Name = "buttonParseAsJson";
            this.buttonParseAsJson.Size = new System.Drawing.Size(184, 23);
            this.buttonParseAsJson.TabIndex = 26;
            this.buttonParseAsJson.Text = "Parse Json Response as object";
            this.buttonParseAsJson.UseVisualStyleBackColor = true;
            this.buttonParseAsJson.Click += new System.EventHandler(this.buttonParseAsJson_Click);
            // 
            // textBoxDecodedToken
            // 
            this.textBoxDecodedToken.Location = new System.Drawing.Point(521, 138);
            this.textBoxDecodedToken.Multiline = true;
            this.textBoxDecodedToken.Name = "textBoxDecodedToken";
            this.textBoxDecodedToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDecodedToken.Size = new System.Drawing.Size(477, 139);
            this.textBoxDecodedToken.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(529, 537);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "message Id:";
            // 
            // textBoxMessageId
            // 
            this.textBoxMessageId.Location = new System.Drawing.Point(620, 534);
            this.textBoxMessageId.Name = "textBoxMessageId";
            this.textBoxMessageId.Size = new System.Drawing.Size(378, 20);
            this.textBoxMessageId.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(529, 513);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "message";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(620, 512);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(378, 20);
            this.textBoxMessage.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(544, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(348, 24);
            this.label15.TabIndex = 32;
            this.label15.Text = "Decode and Validate Token (for service)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(529, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Expected Issuer:";
            // 
            // textBoxExpectedIssuer
            // 
            this.textBoxExpectedIssuer.Location = new System.Drawing.Point(620, 38);
            this.textBoxExpectedIssuer.Name = "textBoxExpectedIssuer";
            this.textBoxExpectedIssuer.Size = new System.Drawing.Size(358, 20);
            this.textBoxExpectedIssuer.TabIndex = 33;
            this.textBoxExpectedIssuer.Text = "https://idsrv3.com";
            // 
            // buttonValidateToken
            // 
            this.buttonValidateToken.Location = new System.Drawing.Point(769, 112);
            this.buttonValidateToken.Name = "buttonValidateToken";
            this.buttonValidateToken.Size = new System.Drawing.Size(184, 23);
            this.buttonValidateToken.TabIndex = 37;
            this.buttonValidateToken.Text = "Validate Token";
            this.buttonValidateToken.UseVisualStyleBackColor = true;
            this.buttonValidateToken.Click += new System.EventHandler(this.buttonValidateToken_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonStandardHttpClient);
            this.groupBox1.Controls.Add(this.radioButtonThinkTecture);
            this.groupBox1.Location = new System.Drawing.Point(128, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 32);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonThinkTecture
            // 
            this.radioButtonThinkTecture.AutoSize = true;
            this.radioButtonThinkTecture.Checked = true;
            this.radioButtonThinkTecture.Location = new System.Drawing.Point(90, 10);
            this.radioButtonThinkTecture.Name = "radioButtonThinkTecture";
            this.radioButtonThinkTecture.Size = new System.Drawing.Size(118, 17);
            this.radioButtonThinkTecture.TabIndex = 0;
            this.radioButtonThinkTecture.TabStop = true;
            this.radioButtonThinkTecture.Text = "ThinkTecture Client";
            this.radioButtonThinkTecture.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandardHttpClient
            // 
            this.radioButtonStandardHttpClient.AutoSize = true;
            this.radioButtonStandardHttpClient.Location = new System.Drawing.Point(229, 10);
            this.radioButtonStandardHttpClient.Name = "radioButtonStandardHttpClient";
            this.radioButtonStandardHttpClient.Size = new System.Drawing.Size(120, 17);
            this.radioButtonStandardHttpClient.TabIndex = 1;
            this.radioButtonStandardHttpClient.Text = "Standard Http Client";
            this.radioButtonStandardHttpClient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonValidateToken);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxExpectedIssuer);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxMessageId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxDecodedToken);
            this.Controls.Add(this.buttonParseAsJson);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxMasheryApiKey);
            this.Controls.Add(this.checkBoxIncludeBearerToken);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxServiceResponse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAcceptHeader);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxHttpVerb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxServiceUrl);
            this.Controls.Add(this.buttonCallService);
            this.Controls.Add(this.buttonShowDecodedToken);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxExpiresInSeconds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSecret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTokenEndpoint);
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.buttonGetOAuthToken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetOAuthToken;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.TextBox textBoxTokenEndpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSecret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxExpiresInSeconds;
        private System.Windows.Forms.Button buttonShowDecodedToken;
        private System.Windows.Forms.Button buttonCallService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAcceptHeader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHttpVerb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxServiceUrl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxServiceResponse;
        private System.Windows.Forms.CheckBox checkBoxIncludeBearerToken;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMasheryApiKey;
        private System.Windows.Forms.Button buttonParseAsJson;
        private System.Windows.Forms.TextBox textBoxDecodedToken;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxMessageId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxExpectedIssuer;
        private System.Windows.Forms.Button buttonValidateToken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonStandardHttpClient;
        private System.Windows.Forms.RadioButton radioButtonThinkTecture;
    }
}

