namespace Converter
{
    internal class CUIGenerator
    {
        public string GeneratorCUI(int cuiLength)
        {
            string cui = "";
            for (int i = 1; i < 10; i++)
            {
                if (i <= 10 - cuiLength)
                {
                    cui += "0";
                }
                else
                {
                    cui += new Random().Next(0, 9);
                }
            }
            cui += GetCuiCheckSum(cui);
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
            sum *= 10;
            var cComponent = (sum % 11).ToString();
            if (cComponent == "10")
                return "0";
            return cComponent;
        }
    }
}