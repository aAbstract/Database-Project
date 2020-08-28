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
    public partial class hospital_add : Form
    {
        private bool update_flag;
        private HashSet<string> added_gov_insu;
        private DataGridViewRow selected_row_left;
        private int selected_right_index = -1;
        private DataTable temp_ds;
        public hospital_add(bool flag)
        {
            InitializeComponent();
            this.update_flag = flag;
            this.search_rgv.Enabled = flag;
            if (flag)
            {
                this.id_tb.Text = main.selected_row.Cells[0].Value.ToString();
                this.id_tb.ReadOnly = true;
                this.name_tb.Text = main.selected_row.Cells[1].Value.ToString();
                this.phone_tb.Text = main.selected_row.Cells[2].Value.ToString();
                this.manager_tb.Text = main.selected_row.Cells[3].Value.ToString();
                this.addr_tb.Text = main.selected_row.Cells[4].Value.ToString();
                this.spec_tb.Text = main.selected_row.Cells[5].Value.ToString();
                DataSet[] dgv_feed = data_access.get_hospital_gi_feed(this.id_tb.Text);
                this.all_gov_dgv.DataSource = dgv_feed[0].Tables[0];
                this.reg_gov_dgv.DataSource = dgv_feed[1].Tables[0];
                this.add_btn.Text = "UPDATE";
                this.add_btn.Click += (x, y) =>
                {
                    try
                    {
                        data_access.cu_hospital(this.update_flag, this.id_tb.Text, this.name_tb.Text, this.phone_tb.Text, this.manager_tb.Text, this.addr_tb.Text, this.spec_tb.Text);
                        utils.show_info("Updating Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("hospitals_info");
                    this.Close();
                };
            }
            else
            {
                this.temp_ds = new DataTable();
                added_gov_insu = new HashSet<string>();
                DataSet[] dgv_feed = data_access.get_hospital_gi_feed(this.id_tb.Text);
                this.all_gov_dgv.DataSource = dgv_feed[0].Tables[0];
                for (int i = 0; i < this.all_gov_dgv.Columns.Count; i++)
                {
                    this.temp_ds.Columns.Add(new DataColumn(this.all_gov_dgv.Columns[i].Name));
                }
                this.reg_gov_dgv.DataSource = this.temp_ds;
                this.add_btn.Click += (x, y) =>
                {
                    try
                    {
                        data_access.cu_hospital(this.update_flag, this.id_tb.Text, this.name_tb.Text, this.phone_tb.Text, this.manager_tb.Text, this.addr_tb.Text, this.spec_tb.Text);
                        List<string> hos_id_list = new List<string>();
                        List<string> gov_id_list = new List<string>();
                        for (int i = 0; i < this.temp_ds.Rows.Count; i++)
                        {
                            hos_id_list.Add(this.id_tb.Text);
                            gov_id_list.Add(this.temp_ds.Rows[i]["ID"].ToString());
                        }
                        data_access.cd_hos_gov(false, hos_id_list.ToArray(), gov_id_list.ToArray());
                        utils.show_info("Adding Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("hospitals_info");
                    this.Close();
                };
            }
        }

        private void search_agv_TextChanged(object sender, EventArgs e)
        {
            this.all_gov_dgv.DataSource = data_access.dreg_hgi_search(this.id_tb.Text, this.search_agv.Text);
        }

        private void search_rgv_TextChanged(object sender, EventArgs e)
        {
            this.reg_gov_dgv.DataSource = data_access.reg_hgi_search(this.id_tb.Text, this.search_rgv.Text);
        }

        private void all_gov_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.agi_slbl.Text = "SELECTED ID: " + this.all_gov_dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            this.selected_row_left = this.all_gov_dgv.Rows[e.RowIndex];
        }

        private void reg_gov_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rgi_slbl.Text = "SELECTED ID: " + this.reg_gov_dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            this.selected_right_index = e.RowIndex;
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (selected_row_left == null)
            {
                utils.show_error("No Inurance Selected!");
                return;
            }
            if (this.update_flag)
            {
                data_access.cd_hos_gov(false, new string[] { this.id_tb.Text }, new string[] { this.agi_slbl.Text.Split(' ')[2] });
                DataSet[] dgv_feed = data_access.get_hospital_gi_feed(this.id_tb.Text);
                this.all_gov_dgv.DataSource = dgv_feed[0].Tables[0];
                this.reg_gov_dgv.DataSource = dgv_feed[1].Tables[0];
            }
            else
            {
                if (this.added_gov_insu.Contains(this.selected_row_left.Cells["ID"].Value.ToString()))
                {
                    utils.show_error("Insurance ID Already Added!");
                }
                else
                {
                    DataRow dr = this.temp_ds.NewRow();
                    for (int i = 0; i < this.all_gov_dgv.Columns.Count; i++)
                    {
                        dr[i] = this.selected_row_left.Cells[i].Value.ToString();
                    }
                    this.temp_ds.Rows.Add(dr);
                    this.reg_gov_dgv.DataSource = this.temp_ds;
                    this.added_gov_insu.Add(this.selected_row_left.Cells["ID"].Value.ToString());
                }
            }
        }

        private void dreg_btn_Click(object sender, EventArgs e)
        {
            if (this.selected_right_index == -1)
            {
                utils.show_error("No Inurance Selected!");
                return;
            }
            if (this.update_flag)
            {
                data_access.cd_hos_gov(true, new string[] { this.id_tb.Text }, new string[] { this.rgi_slbl.Text.Split(' ')[2] });
                DataSet[] dgv_feed = data_access.get_hospital_gi_feed(this.id_tb.Text);
                this.all_gov_dgv.DataSource = dgv_feed[0].Tables[0];
                this.reg_gov_dgv.DataSource = dgv_feed[1].Tables[0];
            }
            else
            {
                this.temp_ds.Rows.RemoveAt(this.selected_right_index);
                this.reg_gov_dgv.DataSource = this.temp_ds;
                this.added_gov_insu.Remove(this.rgi_slbl.Text.Split(' ')[2]);
            }
        }
    }
}
