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
    public partial class acc_info : Form
    {
        private string user_name = null;
        public acc_info(string user_name)
        {
            InitializeComponent();
            this.user_name = user_name;
            this.user_name_lbl.Text = "User Name: " + user_name;
            this.role_lbl.Text = "Role: " + data_access.get_user_info(user_name, "Priv");
            this.ssn_lbl.Text = "SSN:" + data_access.get_user_info(user_name, "SSN");
            this.ds_tb.Text = data_access.get_user_info(user_name, "pass_hash");
            this.email_tb.Text = data_access.get_user_info(user_name, "email");
        }

        private void er_btn_Click(object sender, EventArgs e)
        {
            data_access.reset_user_data(this.user_name, "email", this.email_tb.Text);
            utils.show_info("Email Reset Done!");
        }

        private void passr_btn_Click(object sender, EventArgs e)
        {
            data_access.reset_user_data(this.user_name, "pass_hash", utils.ComputeSha256Hash(this.npass_tb.Text));
            this.ds_tb.Text = data_access.get_user_info(user_name, "pass_hash");
            utils.show_info("Password Reset Done!");
        }
    }
}
