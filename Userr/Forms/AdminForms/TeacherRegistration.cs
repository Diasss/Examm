using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Userr.Forms.AdminForms
{
    public class TeacherRegistration
    {
        public static void Registration(string login, string password, string fName, string lName, DateTime bDate, string telephoneNum)
        {
            string cmdstr = "INSERT Users VALUES ('" + login + "', '" + password +"', '" + fName + "', '" + lName + "', '" + telephoneNum + "', " + 3 + ", '" + bDate + "', NULL)";
            using (SqlConnection conn = new SqlConnection(ConnectionString.Connstr))
            {
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("Учитель успешно добавлен");
                }
            }
        }
    }
}
