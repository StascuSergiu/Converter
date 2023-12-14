using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class CUIGenerator
    {
        public string GeneratorCUI(string inputCui)
        {
            string cui = "";

            if (inputCui == "")
            {
                for (int i = 1; i < 10; i++)
                {
                    cui += new Random().Next(0, 9);
                }
                cui += GetCuiCheckSum(cui);
            }
            else
            {
                if (inputCui.Length <= 9)
                {
                    for(int i = 0; i < 9 - inputCui.Length; i++)
                    {
                        cui += "0";
                    }
                    cui += inputCui;
                    cui += GetCuiCheckSum(cui);
                }
                else
                {
                    cui = "input length between(0,9)";
                }
            }
            
            return cui;
        }
        public string GetCuiCheckSum(string cui)
        {
            string control = "753217532";
            long sum = 0;
            for (var index = 0; index < cui.Length; index++)
            {
                sum += int.Parse(cui[index].ToString()) * int.Parse(control[index].ToString());
            }
            sum *=10;
            var cComponent = (sum % 11).ToString();
            if (cComponent == "10")
                return "1";
            return cComponent;
        }
    }
}
