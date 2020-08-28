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
    public partial class phist_add : Form
    {
        private bool update_flag;
        public phist_add(bool flag)
        {
            InitializeComponent();
            this.update_flag = flag;
            if (flag)
            {
                this.ssn_tb.Text = main.selected_row.Cells[0].Value.ToString();
                this.ssn_tb.ReadOnly = true;
                this.name_tb.Text = main.selected_row.Cells[1].Value.ToString();
                this.phone_tb.Text = main.selected_row.Cells[2].Value.ToString();
                this.addr_tb.Text = main.selected_row.Cells[3].Value.ToString();
                this.button1.Text = "UPDATE";
                this.button1.Click += (x, y) =>
                {
                    try
                    {
                        data_access.cu_phramacist(this.update_flag, this.ssn_tb.Text, this.name_tb.Text, this.dateTimePicker1.Value.ToString("yyyy-MM-dd"), this.addr_tb.Text, this.phone_tb.Text, this.spec_tb.Text);
                        utils.show_info("Updating Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("Pharmacist");
                    this.Close();
                };
            }
            else
            {
                this.button1.Click += (x, y) =>
                {
                    try
                    {
                        data_access.cu_phramacist(this.update_flag, this.ssn_tb.Text, this.name_tb.Text, this.dateTimePicker1.Value.ToString("yyyy-MM-dd"), this.addr_tb.Text, this.phone_tb.Text, this.spec_tb.Text);
                        utils.show_info("Adding Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("Pharmacist");
                    this.Close();
                };
            }
        }
    }
}
