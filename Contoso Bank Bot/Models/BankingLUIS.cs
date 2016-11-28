using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contoso_Bank_Bot.Models
{
    public class BankingLUIS
    {
        public class Intent
        {
            public string intent { get; set; }
            public double score { get; set; }
        }

        public class Entity
        {
            public string entity { get; set; }
            public string type { get; set; }
            public int startIndex { get; set; }
            public int endIndex { get; set; }
            public double score { get; set; }
        }

        public class RootObject
        {
            public string query { get; set; }
            public List<Intent> intents { get; set; }
            public List<Entity> entities { get; set; }
        }
    }
}