using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Userr
{
    public class CheckAgainstInjection
    {
        public static bool CheckPAL(string field, string field2)
        {
            if (field.Contains(" ") || field.Contains("_") || field.Contains("-") || field.Contains("?") || field.Contains("!")||
                field2.Contains(" ") || field2.Contains("_") || field2.Contains("-") || field2.Contains("?") || field2.Contains("!"))
            {

                MessageBox.Show("Пароль или логин не может содержать пробелы");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
