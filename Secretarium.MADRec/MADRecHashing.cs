using Secretarium.Helpers;

namespace Secretarium.MADRec
{
    public static class MADRecHashing
    {
        public static string Hash(string salt, string value)
        {
            return (salt + value).HashSha256().ToBase64String(false);
        }

        public static string Hash(string salt, int value)
        {
            return (salt + value.ToString("N6")).HashSha256().ToBase64String(false);
        }

        public static string Hash(string salt, double value)
        {
            return (salt + value.ToString("N6")).HashSha256().ToBase64String(false);
        }

        public static string Hash(string salt, bool value)
        {
            return (salt + (value ? "true" : "false")).HashSha256().ToBase64String(false);
        }
    }
}
