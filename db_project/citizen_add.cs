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
    public partial class citizen_add : Form
    {
        private bool update_flag;
        public citizen_add(bool flag)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = data_access.get_data_source("gov_insu_info");
            this.med_his_dgv.DataSource = data_access.uni_search_engine("Medicines", "");
            this.update_flag = flag;
            if (flag)
            {
                this.ssn_tb.Text = main.selected_row.Cells[0].Value.ToString();
                this.ssn_tb.ReadOnly = true;
                this.name_tb.Text = main.selected_row.Cells[1].Value.ToString();
                this.dateTimePicker1.Value = DateTime.Parse(main.selected_row.Cells[2].Value.ToString());
                this.addr_tb.Text = main.selected_row.Cells[3].Value.ToString();
                this.phone_tb.Text = main.selected_row.Cells[4].Value.ToString();
                this.gi_lbl.Text = "SELECTED ID: " + data_access.get_insu_id(main.selected_row.Cells[6].Value.ToString());
                this.dis_his_dgv.DataSource = data_access.get_dis_his_by_id(this.ssn_tb.Text);
                this.button1.Text = "UPDATE";
                this.button1.Click += (x, y) =>
                {
                    try
                    {
                        data_access.cu_citizen(this.update_flag, this.ssn_tb.Text, this.name_tb.Text, this.dateTimePicker1.Value.ToString("yyyy-MM-dd"), this.addr_tb.Text, this.phone_tb.Text, this.gi_lbl.Text.Split(' ')[2]);
                        utils.show_info("Updating Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("citizens_info");
                    this.Close();
                };
            }
            else
            {
                this.button1.Click += (x, y) =>
                {
                    try
                    {
                        data_access.cu_citizen(this.update_flag, this.ssn_tb.Text, this.name_tb.Text, this.dateTimePicker1.Value.ToString("yyyy-MM-dd"), this.addr_tb.Text, this.phone_tb.Text, this.gi_lbl.Text.Split(' ')[2]);
                        utils.show_info("Adding Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("citizens_info");
                };
            }
        }
        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.dataGridView1.DataSource = data_access.gov_insu_search(this.search_tb.Text);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.gi_lbl.Text = "SELECTED ID: " + this.dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void med_search_tb_TextChanged(object sender, EventArgs e)
        {
            this.med_his_dgv.DataSource = data_access.uni_search_engine("Medicines", med_search_tb.Text);
        }

        private void med_his_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.med_his_lbl.Text = "SELECTED ID: " + this.med_his_dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void dis_search_btn_Click(object sender, EventArgs e)
        {
            data_access.add_dis_cit_rel(dis_name_tb.Text, this.ssn_tb.Text, this.dis_from_dtp.Value.ToString("yyyy-MM-dd"), this.dis_from_dtp.Value.ToString("yyyy-MM-dd"));
            this.dis_his_dgv.DataSource = data_access.get_dis_his_by_id(this.ssn_tb.Text);
            utils.show_info("Adding Done!");
        }

        private void med_search_btn_Click(object sender, EventArgs e)
        {
            data_access.add_med_cit_rel(this.ssn_tb.Text, this.med_his_lbl.Text.Split(' ')[2], this.med_from_dtp.Value.ToString("yyyy-MM-dd"), this.med_to_dtp.Value.ToString("yyyy-MM-dd"));
            utils.show_info("Adding Done!");
        }

        private void dis_search_tb_TextChanged(object sender, EventArgs e)
        {
            this.dis_his_dgv.DataSource = data_access.get_dis_his_by_id_search(this.ssn_tb.Text, dis_search_tb.Text);
        }
    }
}