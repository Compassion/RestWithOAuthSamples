using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestWithOAuthSamples
{
    public class TestMessage
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

    }
}
