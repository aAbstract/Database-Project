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
    public partial class phcy_add : Form
    {
        private bool update_flag;
        public phcy_add(bool flag)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = data_access.get_data_source("Pharmacist");
            this.update_flag = flag;
            if (flag)
            {
                this.ssn_tb.Text = main.selected_row.Cells[0].Value.ToString();
                this.ssn_tb.ReadOnly = true;
                this.name_tb.Text = main.selected_row.Cells[1].Value.ToString();
                this.phone_tb.Text = main.selected_row.Cells[2].Value.ToString();
                this.pws_lbl.Text = "SELECTED ID: " + data_access.get_phist_id(main.selected_row.Cells[3].Value.ToString());
                DataSet[] med_feed = data_access.get_med_phr_feed(this.ssn_tb.Text);
                this.avl_med_dgv.DataSource = med_feed[0].Tables[0];
                this.reg_med_dgv.DataSource = med_feed[1].Tables[0];
                this.button1.Text = "UPDATE";
                this.button1.Click += (x, y) =>
                {
                    try
                    {
                        data_access.cu_pharmacy(this.update_flag, this.ssn_tb.Text, this.name_tb.Text, this.phone_tb.Text, this.pws_lbl.Text.Split(' ')[2]);
                        utils.show_info("Updating Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("pharmacies_info");
                    this.Close();
                };
            }
            else
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                med_reg_btn.Enabled = false;
                med_dreg_btn.Enabled = false;
                this.button1.Click += (x, y) =>
                {
                    try
                    {
                        data_access.cu_pharmacy(this.update_flag, this.ssn_tb.Text, this.name_tb.Text, this.phone_tb.Text, this.pws_lbl.Text.Split(' ')[2]);
                        utils.show_info("Adding Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("pharmacies_info");
                    this.Close();
                };
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.pws_lbl.Text = "SELECTED ID: " + this.dataGridView1.Rows[e.RowIndex].Cells["SSN"].Value.ToString();
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = data_access.phist_search(this.search_tb.Text);
        }

        private void reg_med_search_TextChanged(object sender, EventArgs e)
        {
            this.reg_med_dgv.DataSource = data_access.med_phr_search(this.ssn_tb.Text, reg_med_search.Text)[1].Tables[0];
        }

        private void avl_med_search_TextChanged(object sender, EventArgs e)
        {
            this.avl_med_dgv.DataSource = data_access.med_phr_search(this.ssn_tb.Text, avl_med_search.Text)[0].Tables[0];

        }

        private void med_reg_btn_Click(object sender, EventArgs e)
        {
            data_access.cd_med_phr_rel(false, this.avl_med_slbl.Text.Split(' ')[2], this.ssn_tb.Text);
            DataSet[] med_feed = data_access.get_med_phr_feed(this.ssn_tb.Text);
            this.avl_med_dgv.DataSource = med_feed[0].Tables[0];
            this.reg_med_dgv.DataSource = med_feed[1].Tables[0];
        }

        private void med_dreg_btn_Click(object sender, EventArgs e)
        {
            data_access.cd_med_phr_rel(true, this.reg_med_slbl.Text.Split(' ')[2], this.ssn_tb.Text);
            DataSet[] med_feed = data_access.get_med_phr_feed(this.ssn_tb.Text);
            this.avl_med_dgv.DataSource = med_feed[0].Tables[0];
            this.reg_med_dgv.DataSource = med_feed[1].Tables[0];
        }

        private void avl_med_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.avl_med_slbl.Text = "SELECTED ID: " + this.avl_med_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void reg_med_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.reg_med_slbl.Text = "SELECTED ID: " + this.reg_med_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
