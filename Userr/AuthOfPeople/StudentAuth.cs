using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userr
{
    public class StudentAuth : IAuthorize
    {
        public bool Authorize(string login, string password)
        {
            string cmdStudents = @"SELECT * FROM Users WHERE id_roles = 2 AND login = '" + login + "' AND password = '" + password + "';";
            using (SqlConnection conn = new SqlConnection(ConnectionString.Connstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdStudents, conn);
                int read = cmd.ExecuteNonQuery();
                if (read!=0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
