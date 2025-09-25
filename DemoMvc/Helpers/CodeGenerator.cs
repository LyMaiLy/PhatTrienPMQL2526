using System.Text.RegularExpressions;

namespace DemoMvc.Helpers
{
    public static class CodeGenerator
    {
        public static string GenerateNextCode(string lastCode, string defaultPrefix = "STD", int numberLength = 3)
        {
            if (string.IsNullOrEmpty(lastCode))
            {
                return defaultPrefix + 1.ToString().PadLeft(numberLength, '0');
            }

            var match = Regex.Match(lastCode, @"(\D+)(\d+)");
            if (!match.Success)
            {
                return defaultPrefix + 1.ToString().PadLeft(numberLength, '0');
            }

            string prefix = match.Groups[1].Value;
            string number = match.Groups[2].Value;

            int nextNumber = int.Parse(number) + 1;
            string newNumber = nextNumber.ToString().PadLeft(number.Length, '0');

            return prefix + newNumber;
        }
    }
}

