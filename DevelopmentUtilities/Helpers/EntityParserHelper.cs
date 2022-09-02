using System.Text.RegularExpressions;
using System;

namespace DevelopmentUtilities.Helpers
{
    public static class EntityParserHelper
    {
        public static List<Tuple<string, string>> ParseEntityInput(string input)
        {
            var result = input.Split('}');
            if (result.Any()) return GenerateDictionary(CleanList(new List<string>(result)));
            else return new List<Tuple<string, string>>();
        }

        private static List<Tuple<string, string>> GenerateDictionary(List<string> parsedInput)
        {
            var result = new List<Tuple<string, string>>();

            foreach (string inputItem in parsedInput)
            {
                var rFt = FindFieldType(inputItem);
                if (!string.IsNullOrEmpty(rFt))
                {
                    try
                    {
                        var res = inputItem.Split(new string[] { rFt }, StringSplitOptions.None)[1]
                                    .Split('{')[0]
                                    .Trim();
                        res = Regex.Replace(res, "[^a-zA-Z0-9_.]+", "");
                        if (!string.IsNullOrEmpty(res)) result.Add(new Tuple<string,string>(rFt, res));
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return result;
        }

        private static string? FindFieldType(string prop)
        {
            if (prop.Contains("int")) return "int";
            else if (prop.Contains("float")) return "float";
            else if (prop.Contains("double")) return "double";
            else if (prop.Contains("decimal")) return "decimal";
            else if (prop.Contains("string")) return "string";
            else if (prop.Contains("char")) return "char";
            else if (prop.Contains("bool")) return "bool";
            else return null;
        }

        private static List<string> CleanList(List<string> parsedInput)
        {
            var result = new List<string>();   

            foreach (string s in parsedInput)
            {
                if (s.Contains("public"))
                {
                    result.Add(s.Remove(0, s.IndexOf("public")));
                }
                else if (s.Contains("private"))
                {
                    result.Add(s.Remove(0, s.IndexOf("private")));
                }

            }

            return result;
        }
    }
}
