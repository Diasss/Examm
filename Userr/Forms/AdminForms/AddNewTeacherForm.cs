using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Userr.Forms.AdminForms
{
    public partial class AddNewTeacherForm : Form
    {
        public AddNewTeacherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckLogin.Check(loginTextBox.Text) == true)
            {
                TeacherRegistration.Registration(loginTextBox.Text, passwordTextBox.Text, nameTextBox.Text, lnameTextBox.Text, Convert.ToDateTime(BDateTextBox.Text), telephoneNumTextBox.Text);
            }
        }
    }
}
