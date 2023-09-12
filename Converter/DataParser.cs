using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class DataParser
    {
        const string  corePath = "C:/Users/sergiu.stascu/source/repos/Converter/Converter/Data";
        public static List<string> GetJudete()
        {
            var judete = new List<string>();
            var json = File.ReadAllText(corePath + "/orase-dupa-judet.json");
            var jsonObj = JsonConvert.DeserializeObject<dynamic>(json);
            foreach (var item in jsonObj)
            {
                var str = item.Path;
                str = str.Replace("['", "");
                str = str.Replace("']", "");
                judete.Add(str);
            }
            return judete;
        }

        public static List<string> GetPrenumeFeminin()
        {
            return GetData("firstnames_f.json");
        }

        public static List<string> GetPrenumeMasculin()
        {
            return GetData("firstnames_m.json");
        }

        public static List<string> GetNume()
        {
            return GetData("surnames.json");
        }

        public static List<string> GetData(string fileName)
        {
            var data = new List<string>();
            var json = File.ReadAllText(corePath + "/" + fileName);
            var jsonObj = JsonConvert.DeserializeObject<dynamic>(json);
            foreach (var item in jsonObj)
            {
                var str = item.ToString().Replace("{", "");
                str = str.Replace("}", "");
                data.Add(str);
            }
            return data;
        }
    }
}
