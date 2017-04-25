using System.Collections.Generic;

namespace FinBot.Tests
{
    public static class ObjectExtensions
    {
        public static List<T> AsList<T>(this T @object)
        {
            return new List<T>() {@object};
        }
    }
}