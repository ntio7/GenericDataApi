using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Models
{
    /// <summary>
    /// ActionTyps = Api, Porcidure, from file - dll,send mail, sms...
    /// </summary>
    public class ActionType
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;    
        public string Description { get; set; } = String.Empty;
        
    }
}
