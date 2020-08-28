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
    public partial class signup_from : Form
    {
        public signup_from()
        {
            InitializeComponent();
            string[] roles = { "Super Admin", "Health Admin", "Public Admin", "Doctor", "Pharmacist", "Citizen" };
            foreach(string x in roles)
            {
                this.comboBox1.Items.Add(x);
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            if(pass_tb.Text != repass_tb.Text)
            {
                utils.show_error("Password Mismatch");
                return;
            }
            data_access.add_user(this.user_name_tb.Text, this.pass_tb.Text, utils.role_map(comboBox1.Text), this.ssn_tb.Text, this.email_tb.Text);
            utils.show_info("Done!");
            main.dgv_ref.DataSource = data_access.get_data_source("admins_info");
            this.Close();
        }
    }
}
