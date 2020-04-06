using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace UserLogin
{

    public class LogAttempt
    {

        public string Username { get; set; }

        public DateTime Time { get; set; } = DateTime.Now;

        [JsonConverter(typeof(StringEnumConverter))]
        public LoginStatusCode StatusCode { get; set; }

        public LogAttempt() { }

    }
}
