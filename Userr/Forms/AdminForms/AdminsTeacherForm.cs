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
    public partial class AdminsTeacherForm : Form
    {
        public AdminsTeacherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewTeacherForm form = new AddNewTeacherForm();
            form.Show();
        }
    }
}
