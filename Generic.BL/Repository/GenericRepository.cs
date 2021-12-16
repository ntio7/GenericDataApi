using Generic.Data;
using Generic.Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.BL
{
    public class GenericRepository : IGenericRepository
    {
        public string GetItems()
        {

            using (GenericDbContext genericDb = new GenericContextFactory().CreateDbContext())
            {
                RequestAction a = new();


               // return (IEnumerable<string>)genericDb.Actions.Select(a => a.Id);


            }

            return "";
           
        }

    }
}
