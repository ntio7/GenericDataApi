using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Generic.BL.Services
{
    public class ExectueServise
    {

        public string ExectueAction(string action, List<string> inputParams, string connStr)
        {
            string response = "";
            //using (var connection = new SqlConnection(connStr))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand();
            //    if (action.ewaMethod_Action_Type_ID == 1)// stored procedure action
            //    {
            //        if (inputParams != null)
            //        { command.Parameters.AddRange(SqlFormat.ConvertPostParamsToSqlParams(inputParams)); }
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.Connection = connection;
            //        command.CommandText = action.ServerName;
            //    }
                response = JsonConvert.SerializeObject(new object());

            //}
            return response;
        }

        public string ExectueFunction(string connStr, string webMethod, string ServerName, List<string> inputData)
        {
            connStr = Path.GetFullPath(connStr);
            Assembly asm = Assembly.LoadFrom(connStr);
            Type t = asm.GetType(webMethod);

            var methodInfo = t.GetMethod(ServerName, new Type[1] { typeof(string) }); // overloadArr);
            if (methodInfo == null)
            {
                throw new Exception("No such method exists.");
            }

            dynamic o = Activator.CreateInstance(t);

            string jsonResult = JsonConvert.SerializeObject(inputData);
            object[] parameters = new object[1] { jsonResult };

            var r = methodInfo.Invoke(o, parameters);


            return r;
        }


    }
}
