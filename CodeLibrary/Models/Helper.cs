using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary.Models
{
    public static class Helper
    {
        public static string ConStr(string name) => ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
}
