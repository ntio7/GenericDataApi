using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Models
{
    internal class ActionHedars
    {
        public int Id { get; set; }
        public int ActionId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Value { get; set; } = String.Empty;
    }
}
