using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userr.Forms.AdminForms
{
    public class CheckLogin
    {
        public static bool Check(string login)
        {
            string cmdstr = "SELECT * FROM Users WHERE login = '" + login + "'";
            using (SqlConnection conn = new SqlConnection(ConnectionString.Connstr))
            {
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                int k = cmd.ExecuteNonQuery();
                if (k == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
