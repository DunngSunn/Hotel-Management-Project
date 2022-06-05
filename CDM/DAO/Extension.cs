using System;

namespace DAO
{
    public static class Extension
    {
        public static int TryParseInt(string value)
        {
            int.TryParse(value, out var returnValue);
            return returnValue;
        }

        public static long TryParseLong(string value)
        {
            long.TryParse(value, out var returnValue);
            return returnValue;
        }

        public static DateTime TryParseDateTime(string value)
        {
            DateTime.TryParse(value, out var returnValue);
            return returnValue;
        }
    }
}
