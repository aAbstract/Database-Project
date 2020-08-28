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
    public partial class clinic_add : Form
    {
        private bool update_flag;
        public clinic_add(bool flag)
        {
            InitializeComponent();
            this.update_flag = flag;
            this.dataGridView1.DataSource = data_access.get_data_source("Doctor");
            if (flag)
            {
                this.dssn_slbl.Text = "SELECTED ID: " + data_access.get_doctor_id(main.selected_row.Cells[0].Value.ToString());
                this.addr_tb.Text = main.selected_row.Cells[1].Value.ToString();
                this.phone_tb.Text = main.selected_row.Cells[2].Value.ToString();
                this.spec_tb.Text = main.selected_row.Cells[3].Value.ToString();
                this.button1.Text = "UPDATE";
                this.button1.Click += (x, y) =>
                {
                    try
                    {
                        data_access.cu_clinic(this.update_flag, this.dssn_slbl.Text.ToString().Split(' ')[2], this.addr_tb.Text, this.phone_tb.Text, this.spec_tb.Text);
                        utils.show_info("Updating Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("clinics_info");
                    this.Close();
                };
            }
            else
            {
                this.button1.Click += (x, y) =>
                {
                    try
                    {
                        data_access.cu_clinic(this.update_flag, this.dssn_slbl.Text.ToString().Split(' ')[2], this.addr_tb.Text, this.phone_tb.Text, this.spec_tb.Text);
                        utils.show_info("Adding Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("clinics_info");
                    this.Close();
                };
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dssn_slbl.Text = "SELECTED ID: " + this.dataGridView1.Rows[e.RowIndex].Cells["SSN"].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = data_access.doctor_search(this.textBox1.Text);
        }
    }
}
