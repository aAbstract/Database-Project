using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_project
{
    public partial class Form1 : Form
    {
        public string login_string = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            string res = data_access.login(user_name_tb.Text, password_tb.Text);
            if (res == string.Empty)
            {
                utils.show_error("LOGIN FAILD");
            }
            else
            {
                login_string = res;
                this.Close();
            }
        }
    }
}
