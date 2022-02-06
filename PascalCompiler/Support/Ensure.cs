using System;

namespace Teqniqly.Compilers.Pascal
{
    public static class Ensure
    {
        public static void NotNull(object arg, string argName)
        {
            if (arg == null)
            {
                throw new ArgumentException($"Argument '{argName}' cannot be null.")
            }
        }
        public static void NotNullOrWhitespace(string arg, string argName)
        {
            if (string.IsNullOrWhiteSpace(arg))
            {
                throw new ArgumentException($"Argument '{argName}' cannot be null or empty.");
            }
        }
    }

    public static class Check
    {
        public static bool IsNullOrWhitespace(string arg)
        {
            return string.IsNullOrWhiteSpace(arg);
        }
    }
}
