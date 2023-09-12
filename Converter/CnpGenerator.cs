using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class CnpGenerator
    {
        public string GenerateCNP(DateTime birthDate, string judet, string gender)
        {
            var cnp = "";
            cnp += GetGenderIndex(birthDate, gender);
            cnp += birthDate.ToString("yyMMdd");
            cnp += judet;
            cnp += new Random().Next(1, 9);
            cnp += new Random().Next(1, 9);
            cnp += new Random().Next(1, 9);
            cnp += GetCComponent(cnp);
            return cnp;
        }

        private string GetCComponent(string cnp)
        {
            long sum = 0;
            foreach (var item in cnp)
            {
                sum += int.Parse(item.ToString()) * 279146358279;
            }
            var cComponent = (sum % 11).ToString();
            if (cComponent == "10")
                return "1";
            return cComponent;
        }

        private static string GetGenderIndex(DateTime birthDate, string gender)
        {
            switch (gender)
            {
                case "M":
                    return birthDate.Year < 2000 ? "1" : "5";
                case "F":
                    return birthDate.Year < 2000 ? "2" : "6";
                default:
                    return "0";
            }
        }
    }
}
