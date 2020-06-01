using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace StudentInfoSystem
{

    public class LogAttempt
    {
        [Key]
        public int LogAttemptId { get; set; }

        public string Username { get; set; }

        public DateTime Time { get; set; } = DateTime.Now;

        [JsonConverter(typeof(StringEnumConverter))]
        public LoginStatusCode StatusCode { get; set; }

        public LogAttempt() { }

    }
}
