using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Userr
{
    public class ConnectionString
    {
        private static string _connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        public static string Connstr { get => _connstr; private set => _connstr = value; }
    }
}