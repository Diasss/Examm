using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Userr
{
    public class FinalAuthorize
    {
        public static void Auth(string login, string password)
        {
            bool k = false;
            while (k == false)
            {
                if (CheckAgainstInjection.CheckPAL(login, password) == true)
                {
                    k = true;
                }
                else
                {
                    Form1.ClearTextBox();
                    k = false;
                }
            }
            string hashPassword = MD5HashPassword.GetHash(password);
            StudentAuth studentAuth = new StudentAuth();
            AdminAuth adminAuth = new AdminAuth();
            Teacherauth teacherauth = new Teacherauth();
            if (studentAuth.Authorize(login, hashPassword) == true)
            {

            }
            else if (adminAuth.Authorize(login, hashPassword) == true)
            {
                Form1 form1 = new Form1();
                form1.Close();
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else if (teacherauth.Authorize(login, hashPassword) == true)
            {

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!");
            }
        }
    }
}
