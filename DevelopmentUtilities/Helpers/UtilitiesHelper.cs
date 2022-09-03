namespace DevelopmentUtilities.Helpers
{
    public static class UtilitiesHelper
    {
        public static bool IsNumber(string FieldType)
        {
            switch (FieldType)
            {
                case "int": return true;
                case "float": return true;
                case "double": return true;
                case "decimal": return true;
                default: return false;
            }
        }
    }
}
