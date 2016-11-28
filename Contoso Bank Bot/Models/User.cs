using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contoso_Bank_Bot.Models
{
    public class User
    {        
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "cheque")]
        public double Cheque { get; set; }

        [JsonProperty(PropertyName = "savings")]
        public double Savings { get; set; }

        [JsonProperty(PropertyName = "createdAt")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }
    }
}