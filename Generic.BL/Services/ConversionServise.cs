using Generic.Data.Models;
using Newtonsoft.Json;

namespace Generic.BL.Services
{
    public class ConversionService
    {
        public string? Token { get; set; }
        public ConversionService() { }
        public ConversionService(string Token) { this.Token = Token; }

        //public dynamic ConvertObjects(dynamic value)
        //{
        //    return convertToDestJson(ObjToItemList(value));
        //}

        //public dynamic ObjToItemList(dynamic value, int Level = 0, string Parent = "root")
        //{
        //    List<Item> il = new List<Item>();
        //    //Dictionary<int, string> ParentsDic = new();
        //    //ParentsDic.Add(ParentsDic.Count, Parent);
        //    string jsonString = System.Text.Json.JsonSerializer.Serialize(value);
        //    dynamic obj = JsonConvert.DeserializeObject(jsonString);

        //    foreach (var item in obj)
        //    {
        //        try
        //        {
        //            Item i = new Item();
        //            i.Key = item.Name;
        //            if (item.Value.GetType().Name == "JArray")
        //            {
        //                i.ValueArray = item.Value;
        //            }
        //            else
        //            {
        //                i.Value = item.Value;
        //            }

        //            i.Parent = Parent;
        //            i.Level = Level;
        //            il.Add(i);
        //        }
        //        catch (Exception)
        //        {
        //            try
        //            {
        //                ObjToItemList(item.Value, Level + 1, item.Name);
        //            }
        //            catch (Exception)
        //            {
        //            }
        //        }
        //    }


        //    DataSet ds = new CCRepository(Token).GetKeys();

        //    List<Keys> kl = ds.Tables[0].AsEnumerable()
        //    .Select(row => new Keys
        //    {
        //        Id = Convert.ToInt32(row.Field<int>("Id")),
        //        ActionId = Convert.ToInt32(row.Field<int>("ActionId")),
        //        SourceKey = row.Field<string>("SourceKey").ToString(),
        //        NewKey = row.Field<string>("NewKey").ToString(),
        //        KeyLevel = Convert.ToInt32(row.Field<int>("KeyLevel")),
        //    }).ToList();

        //    foreach (var s in il)
        //    {
        //        s.Key = kl.Where(w => w.SourceKey == s.Key && w.KeyLevel == s.Level)
        //            .Select(s => s.NewKey).FirstOrDefault();
        //    }

        //    return il;
        //}

        //public dynamic convertToDestJson(List<Item> il, int Level = 0, string Parent = "root")
        //{
        //    string json = new CCRepository(Token).GetAction();
        //    dynamic value = JsonConvert.DeserializeObject(json);
        //    return ItemListToObj(il, value);
        //}

        public dynamic ItemListToObj(List<Item> il, dynamic value, int Level = 0, string Parent = "root")
        {
            foreach (var item in value)
            {
                if (item.Value.HasValues == null)
                {
                    ItemListToObj(il, item.Value, Level + 1, item.Name);
                }
                else
                {
                    foreach (var i1 in il)
                    {
                        if (i1.Key == item.Name && i1.Parent == Parent)
                        {
                            if (item.Value.GetType().Name == "JArray")
                            {
                                item.Value = i1.ValueArray;
                            }
                            else
                            {
                                item.Value = i1.Value;
                            }
                        }
                    }
                }
            }
            return value;
        }

        //public static List<Dictionary<string, object>> ExecuteCommandToJSON(SqlCommand command)
        //{

        //    try
        //    {
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
        //        DataSet dataSet = new DataSet();
        //        sqlDataAdapter.Fill(dataSet);
        //        DataTable dt = dataSet.Tables[0];
        //        List<Dictionary<string, object>> tmp = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(JsonConvert.SerializeObject(dt));
        //        dt.Clear();
        //        return tmp;
        //    }
        //    catch (Exception ex)
        //    {
        //        var errors = new List<Dictionary<string, object>>();
        //        var error = new Dictionary<string, object>();
        //        error.Add("error:", ex.Message);
        //        errors.Add(error);
        //        return errors;
        //    }



        //    //DataTable dt = new DataTable();
        //    //SqlDataAdapter da = new SqlDataAdapter(command);
        //    //try
        //    //{
        //    //    da.Fill(dt);
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    var errors = new List<Dictionary<string, object>>();
        //    //    var error = new Dictionary<string, object>();
        //    //    error.Add("error:", ex.Message);
        //    //    errors.Add(error);
        //    //    return errors;
        //    //}

        //    //List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        //    //Dictionary<string, object> row;
        //    //foreach (DataRow dr in dt.Rows)
        //    //{
        //    //    row = new Dictionary<string, object>();
        //    //    foreach (DataColumn col in dt.Columns)
        //    //    {
        //    //        row.Add(col.ColumnName, dr[col]);
        //    //    }
        //    //    rows.Add(row);
        //    //}
        //    //command.Connection.Close();
        //    //return rows;
        //}


        //public static SqlDbType GetParamType(string type)
        //{
        //    SqlDbType sqlDbType = new SqlDbType();
        //    switch (type)
        //    {
        //        case "NVarChar":
        //            sqlDbType = SqlDbType.NVarChar;
        //            break;
        //        case "Int":
        //            sqlDbType = SqlDbType.Int;
        //            break;
        //        case "DateTime":
        //            sqlDbType = SqlDbType.DateTime;
        //            break;
        //        case "Bit":
        //            sqlDbType = SqlDbType.Bit;
        //            break;
        //        default:
        //            sqlDbType = SqlDbType.NVarChar;
        //            break;
        //    }
        //    return sqlDbType;
        //}
    }
}
