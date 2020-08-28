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
    public partial class medicin_add : Form
    {
        private bool update_flag;
        private DataGridViewRow selected_row_left_gi;
        private int selected_right_index_gi = -1;
        private DataGridViewRow selected_row_left_mc;
        private int selected_right_index_mc = -1;
        private DataTable temp_ds1;
        private DataTable temp_ds2;
        private HashSet<string> added_gov_insu;
        private HashSet<string> added_mc;
        public medicin_add(bool flag)
        {
            InitializeComponent();
            this.update_flag = flag; // Save Mode Flag (True -> Update Mode, False -> Add Mode)
            this.search_rgv.Enabled = flag;
            this.rc_search.Enabled = flag;
            if (flag) // Check if Form is in Update or Add Mode
            {
                this.id_tb.Text = main.selected_row.Cells[0].Value.ToString(); // Get Selected Row From Main Form
                this.id_tb.ReadOnly = true; // Make ID Textbox Read Only (Update Mode)
                this.name_tb.Text = main.selected_row.Cells[1].Value.ToString(); // Fetch Name
                this.ai_tb.Text = main.selected_row.Cells[2].Value.ToString(); // Fetch Active Ingredient
                DataSet[] dgv_feed = data_access.get_med_insu_feed(this.id_tb.Text); // Load All Government Inurance Feed From Database
                this.all_gov_dgv.DataSource = dgv_feed[0].Tables[0]; // Display All Government Inurance on the Form
                this.reg_gov_dgv.DataSource = dgv_feed[1].Tables[0]; // Display Registered Government Inurance on the Form (for The Selected Medicine)
                DataSet[] mcgv_feed = data_access.get_med_conf_feed(this.id_tb.Text); // Load All Conflicts Feed From Database
                this.nrmc_gv.DataSource = mcgv_feed[0].Tables[0]; // Display All Registerd Medicine on the Form
                this.rmc_gv.DataSource = mcgv_feed[1].Tables[0]; // Display Registered Conflicts on the Form (for The Selected Medicine)
                this.add_btn.Text = "UPDATE";
                this.add_btn.Click += (x, y) => // Inilize Buttin Behavior (Update Action)
                {
                    try
                    {
                        data_access.cu_medicine(this.update_flag, this.id_tb.Text, this.name_tb.Text, this.ai_tb.Text); // data_access Function To handle Medicine Update and Create Actions
                        utils.show_info("Updating Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("Medicines"); // Update Table in Main Form via The Global Refrence
                    this.Close();
                };
            }
            else // Form Opens in Add Mode
            {
                // Inilize Some Global Variables
                this.temp_ds1 = new DataTable();
                this.temp_ds2 = new DataTable();
                added_gov_insu = new HashSet<string>();
                added_mc = new HashSet<string>();

                DataSet[] dgv_feed = data_access.get_med_insu_feed(this.id_tb.Text); // Load All Government Inurance Feed From Database
                DataSet[] mc_dgv_feed = data_access.get_med_conf_feed(this.id_tb.Text); // Load All Conflicts Feed From Database
                this.all_gov_dgv.DataSource = dgv_feed[0].Tables[0]; // Display All Government Inurance on the Form
                this.nrmc_gv.DataSource = mc_dgv_feed[0].Tables[0]; // Display All Registerd Medicine on the Form
                for (int i = 0; i < this.all_gov_dgv.Columns.Count; i++) // Clone Table Template From Government Inusrance Table (Will Be Used in Government Inusrance Registraion)
                {
                    this.temp_ds1.Columns.Add(new DataColumn(this.all_gov_dgv.Columns[i].Name)); // Clone Each Column
                }
                for (int i = 0; i < this.nrmc_gv.Columns.Count; i++) // Clone Table Template From Medicne Table (Will Be Used in Conflicts Registraion)
                {
                    this.temp_ds2.Columns.Add(new DataColumn(this.nrmc_gv.Columns[i].Name)); // Clone Each Column
                }
                this.reg_gov_dgv.DataSource = this.temp_ds1; // Display Registerd Government Inusrance on The Form (Goverenment Inusrance Table Clone)
                this.rmc_gv.DataSource = this.temp_ds2; // Display Registerd Conflicts on The Form (Not Registerd Medicine Table Clone)
                this.add_btn.Click += (x, y) => // Inilize Buttin Behavior (Add Action)
                {
                    try
                    {
                        data_access.cu_medicine(this.update_flag, this.id_tb.Text, this.name_tb.Text, this.ai_tb.Text); // data_access Function To handle Medicine Update and Create Actions
                        // Register Medicine in Governemnt Insurance Function Parametrs
                        List<string> med_id_list_g = new List<string>(); // List Contains selected medicine id N times
                        List<string> gov_id_list = new List<string>(); // List Contains N Governemnt Inusrances To Be Registed to Current Selected Medicine
                        for (int i = 0; i < this.temp_ds1.Rows.Count; i++) // Inilize The Previous Two Lists
                        {
                            med_id_list_g.Add(this.id_tb.Text);
                            gov_id_list.Add(this.temp_ds1.Rows[i]["ID"].ToString());
                        }
                        data_access.cd_med_gov(false, med_id_list_g.ToArray(), gov_id_list.ToArray()); // data_access Function To Add Medcine Under Insurance in Database
                        // Register Medicine Conflicts
                        List<string> med_id_list_c = new List<string>(); // List Contains N Governemnt Inusrances To Be Registed to Current Selected Medicine
                        List<string> mc_id_list = new List<string>(); // List Contains N Medicine Conflicts To Be Registed With Current Selected Medicine
                        for (int i = 0; i < this.temp_ds2.Rows.Count; i++)  // Inilize The Previous Two Lists
                        {
                            med_id_list_c.Add(this.id_tb.Text);
                            mc_id_list.Add(this.temp_ds2.Rows[i]["ID"].ToString());
                        }
                        data_access.cd_med_conf(false, med_id_list_c.ToArray(), mc_id_list.ToArray()); // data_access Function To Add Medcine Conflicts in Database
                        utils.show_info("Adding Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("Medicines"); // Update Table in Main Form via The Global Refrence
                    this.Close();
                };
            }
        }

        private void search_agv_TextChanged(object sender, EventArgs e)
        {
            this.all_gov_dgv.DataSource = data_access.dreg_mcgi_search(this.id_tb.Text, this.search_agv.Text); // Not Registerd Government Database Search
        }

        private void search_rgv_TextChanged(object sender, EventArgs e)
        {
            this.reg_gov_dgv.DataSource = data_access.reg_mgi_search(this.id_tb.Text, this.search_rgv.Text); // Registerd Government Database Search
        }

        private void all_gov_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Keep Track of Selected Item in Not Registerd Government
            this.agi_slbl.Text = "SELECTED ID: " + this.all_gov_dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            this.selected_row_left_gi = this.all_gov_dgv.Rows[e.RowIndex];
        }

        private void reg_gov_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Keep Track of Selected Item in Registerd Government
            this.rgi_slbl.Text = "SELECTED ID: " + this.reg_gov_dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            this.selected_right_index_gi = e.RowIndex;
        }

        // Register Government Insurance Actions
        private void reg_btn_gi_Click(object sender, EventArgs e)
        {
            // null Selection Chek
            if (selected_row_left_gi == null)
            {
                utils.show_error("No Inurance Selected!");
                return;
            }
            if (this.update_flag) // if Update Mode Change in Database Directly
            {
                data_access.cd_med_gov(false, new string[] { this.id_tb.Text }, new string[] { this.agi_slbl.Text.Split(' ')[2] }); // data_access Function to Register Medicine To Inusrance in Database
                // Reload Government Insurance Tables in The Form
                DataSet[] dgv_feed = data_access.get_med_insu_feed(this.id_tb.Text);
                this.all_gov_dgv.DataSource = dgv_feed[0].Tables[0];
                this.reg_gov_dgv.DataSource = dgv_feed[1].Tables[0];
            }
            else // Add Mode
            {
                if (this.added_gov_insu.Contains(this.selected_row_left_gi.Cells["ID"].Value.ToString())) // if The Item to Add in The Set
                {
                    utils.show_error("Insurance ID Already Added!");
                }
                else
                {
                    // Simulate Item Transation Between Tables in Froms
                    DataRow dr = this.temp_ds1.NewRow();
                    for (int i = 0; i < this.all_gov_dgv.Columns.Count; i++)
                    {
                        dr[i] = this.selected_row_left_gi.Cells[i].Value.ToString();
                    }
                    this.temp_ds1.Rows.Add(dr);
                    this.reg_gov_dgv.DataSource = this.temp_ds1;
                    this.added_gov_insu.Add(this.selected_row_left_gi.Cells["ID"].Value.ToString()); // Add Item To The Set For Future Check
                    // NOTE: HashSet is a Constant Lookup Set -> Optimizies The Searching Process
                }
            }
        }

        // Remove Register Government Insurance Actions
        private void dreg_btn_gi_Click(object sender, EventArgs e)
        {
            if (this.selected_right_index_gi == -1)
            {
                utils.show_error("No Inurance Selected!");
                return;
            }
            if (this.update_flag)
            {
                data_access.cd_med_gov(true, new string[] { this.id_tb.Text }, new string[] { this.rgi_slbl.Text.Split(' ')[2] });
                DataSet[] dgv_feed = data_access.get_med_insu_feed(this.id_tb.Text);
                this.all_gov_dgv.DataSource = dgv_feed[0].Tables[0];
                this.reg_gov_dgv.DataSource = dgv_feed[1].Tables[0];
            }
            else
            {
                this.temp_ds1.Rows.RemoveAt(this.selected_right_index_gi);
                this.reg_gov_dgv.DataSource = this.temp_ds1;
                this.added_gov_insu.Remove(this.rgi_slbl.Text.Split(' ')[2]);
            }
        }

        private void nrc_search_TextChanged(object sender, EventArgs e)
        {
            this.nrmc_gv.DataSource = data_access.nrmc_search(this.id_tb.Text, this.nrc_search.Text); // data_access Function To Seach in Not Conflicted Mediceince
        }

        private void rc_search_TextChanged(object sender, EventArgs e)
        {
            this.rmc_gv.DataSource = data_access.rmc_search(this.id_tb.Text, this.rc_search.Text); // data_access Function To Seach in Conflicted Mediceince
        }

        private void nrmc_gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Keep Track of Selected Item in The Not Registed Conflicts
            this.nrc_slbl.Text = "SELECTED ID: " + this.nrmc_gv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            this.selected_row_left_mc = this.nrmc_gv.Rows[e.RowIndex];
        }

        private void rmc_gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Keep Track of Selected Item in The Registed Conflicts
            this.rc_slbl.Text = "SELECTED ID: " + this.rmc_gv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            this.selected_right_index_mc = e.RowIndex;
        }

        // Add Medicine Conflict To Database Actions
        private void reg_btn_mc_Click(object sender, EventArgs e)
        {
            if (selected_row_left_mc == null)
            {
                utils.show_error("No Medicine Selected!");
                return;
            }
            if (this.update_flag)
            {
                data_access.cd_med_conf(false, new string[] { this.id_tb.Text }, new string[] { this.nrc_slbl.Text.Split(' ')[2] });
                DataSet[] mcgv_feed = data_access.get_med_conf_feed(this.id_tb.Text);
                this.nrmc_gv.DataSource = mcgv_feed[0].Tables[0];
                this.rmc_gv.DataSource = mcgv_feed[1].Tables[0];
            }
            else
            {
                if (this.added_mc.Contains(this.selected_row_left_mc.Cells["ID"].Value.ToString()))
                {
                    utils.show_error("Medicine ID Already Added!");
                }
                else
                {
                    DataRow dr = this.temp_ds2.NewRow();
                    for (int i = 0; i < this.nrmc_gv.Columns.Count; i++)
                    {
                        dr[i] = this.selected_row_left_mc.Cells[i].Value.ToString();
                    }
                    this.temp_ds2.Rows.Add(dr);
                    this.rmc_gv.DataSource = this.temp_ds2;
                    this.added_mc.Add(this.selected_row_left_mc.Cells["ID"].Value.ToString());
                }
            }
        }

        // Remove Medicine Conflict To Database Actions
        private void dreg_btn_mc_Click(object sender, EventArgs e)
        {
            if (this.selected_right_index_mc == -1)
            {
                utils.show_error("No  Selected!");
                return;
            }
            if (this.update_flag)
            {
                data_access.cd_med_conf(true, new string[] { this.id_tb.Text }, new string[] { this.rc_slbl.Text.Split(' ')[2] });
                DataSet[] mcgv_feed = data_access.get_med_conf_feed(this.id_tb.Text);
                this.nrmc_gv.DataSource = mcgv_feed[0].Tables[0];
                this.rmc_gv.DataSource = mcgv_feed[1].Tables[0];
            }
            else
            {
                this.temp_ds2.Rows.RemoveAt(this.selected_right_index_mc);
                this.rmc_gv.DataSource = this.temp_ds2;
                this.added_mc.Remove(this.rc_slbl.Text.Split(' ')[2]);
            }
        }
    }
}
