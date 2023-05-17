using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GridTest.Shared.Models
{
    public static class QuickUtils
    {
        public static List<Dictionary<string, object>> ConvertingDataList<T>(List<T> dataList)
        {
            List<Dictionary<string, object>> results = new();

            foreach(T data in dataList)
            {
                Dictionary<string, object> tmpData = new();

                foreach (PropertyInfo prop in data.GetType().GetProperties())
                {
                    if (prop.PropertyType.IsClass)
                    {
                        var value = ConvertingData(data.GetType().GetProperty(prop.Name)?.GetValue(data, null));
                        if(value != null)
                        {
                            tmpData.Add(prop.Name, value);
                        }
                    }
                    else
                    {
                        var value = data.GetType().GetProperty(prop.Name)?.GetValue(data, null);

                        if (value != null)
                        {
                            tmpData.Add(prop.Name, value);
                        }
                    }
                }

                results.Add(tmpData);
            }

            return results;
        }

        public static Dictionary<string, object> ConvertingData<T>(T data)
        {
            if (data == null) return new Dictionary<string, object>();

            return data.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .ToDictionary(prop => prop.Name, prop => prop.GetValue(data, null));
        }
    }
}
