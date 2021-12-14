using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Models
{
    public record Item
    {
        public string Parent { get; set; } = string.Empty;  
        public int Level { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public JArray? ValueArray { get; set; } 
    }

    public record Keys
    {
        public int Id { get; set; }
        public int ActionId { get; set; }
        public string SourceKey { get; set; } = string.Empty;
        public string NewKey { get; set; } = string.Empty;
        public int KeyLevel { get; set; }
    }
}
