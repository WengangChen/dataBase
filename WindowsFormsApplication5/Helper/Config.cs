using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5.Helper
{
    internal static class Config
    {
        static Config()
        {
            Server = "127.0.0.1,18188";
        }

        public static string Server { set; get; }
    }
}
