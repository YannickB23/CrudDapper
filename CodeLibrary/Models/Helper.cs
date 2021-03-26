using System.Configuration;

namespace CodeLibrary.Models
{
    public static class Helper
    {
        public static string ConStr(string name) => ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
}
