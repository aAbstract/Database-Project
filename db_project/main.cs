using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_project
{
    public partial class main : Form
    {
        public static DataGridView dgv_ref = null;
        public static DataGridViewRow selected_row = null;
        private string login_session = null;
        private string selected_channel = null;
        public bool is_lggedout = false;
        public main(string login_string)
        {
            InitializeComponent();
            this.login_session = login_string;
            main.dgv_ref = this.dataGridView1;
            if (data_access.is_connected())
            {
                this.conns_slbl.Text = "Connection State: Connected";
            } else
            {
                this.conns_slbl.Text = "Connection State: Disconnected";
            }
            this.username_slbl.Text = "User: " + login_string.Split(':')[0];
            this.server_slbl.Text = "Server Name: " + System.Net.Dns.GetHostName();
            this.role_slbl.Text = "Role: " + utils.role_map(int.Parse(login_string.Split(':')[1]));
            string[] pub_mob_channels = { "Citizens", "Governmental Insurance" };
            string[] hdm_channels = { "Doctors", "Hospitals", "Clinics", "Medicines", "Pharmacy", "Pharmacist" };
            string[] doc_channels = { "Citizens" };
            string[] phar_channels = { "Medicines", "Pharmacist" };
            string[] citzen_channels = { "Doctors", "Pharmacy", "Clinics" };
            switch (login_string.Split(':')[1])
            {
                case "0":
                    foreach (string item_lbl in hdm_channels)
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem(item_lbl);
                        item.Click += (x, y) =>
                        {
                            this.dcch(item_lbl);
                            this.selected_channel = item_lbl;
                        };
                        this.dbc_tsi.DropDownItems.Add(item);
                    }
                    foreach (string item_lbl in pub_mob_channels)
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem(item_lbl);
                        item.Click += (x, y) =>
                        {
                            this.dcch(item_lbl);
                            this.selected_channel = item_lbl;
                        };
                        this.dbc_tsi.DropDownItems.Add(item);
                    }
                    ToolStripMenuItem item_sa = new ToolStripMenuItem("System Admins");
                    item_sa.Click += (x, y) =>
                    {
                        this.dcch("System Admins");
                        this.selected_channel = "System Admins";
                    };
                    this.dbc_tsi.DropDownItems.Add(item_sa);
                    break;
                case "1":
                    foreach (string item_lbl in hdm_channels)
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem(item_lbl);
                        item.Click += (x, y) =>
                        {
                            this.dcch(item_lbl);
                            this.selected_channel = item_lbl;
                        };
                        this.dbc_tsi.DropDownItems.Add(item);
                    }
                    break;
                case "2":
                    foreach (string item_lbl in pub_mob_channels)
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem(item_lbl);
                        item.Click += (x, y) =>
                        {
                            this.dcch(item_lbl);
                            this.selected_channel = item_lbl;
                        };
                        this.dbc_tsi.DropDownItems.Add(item);
                    }
                    break;
                case "3":
                    foreach (string item_lbl in doc_channels)
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem(item_lbl);
                        item.Click += (x, y) =>
                        {
                            this.dcch(item_lbl);
                            this.selected_channel = item_lbl;
                        };
                        this.dbc_tsi.DropDownItems.Add(item);
                    }
                    break;
                case "4":
                    foreach (string item_lbl in phar_channels)
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem(item_lbl);
                        item.Click += (x, y) =>
                        {
                            this.dcch(item_lbl);
                            this.selected_channel = item_lbl;
                        };
                        this.dbc_tsi.DropDownItems.Add(item);
                    }
                    break;
                case "5":
                    foreach (string item_lbl in citzen_channels)
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem(item_lbl);
                        item.Click += (x, y) =>
                        {
                            this.dcch(item_lbl);
                            this.selected_channel = item_lbl;
                        };
                        this.dbc_tsi.DropDownItems.Add(item);
                    }
                    add_btn.Enabled = false;
                    upd_btn.Enabled = false;
                    del_btn.Enabled = false;
                    break;
            }
        }
        private void dcch(string channel)
        {
            this.remove_event_listners(add_btn);
            this.remove_event_listners(upd_btn);
            main.selected_row = null;
            switch (channel)
            {
                case "Citizens":
                    this.dataGridView1.DataSource = data_access.get_data_source("citizens_info");
                    this.add_btn.Click += (x, y) =>
                    {
                        new citizen_add(false).Show();
                    };
                    this.upd_btn.Click += (x, y) =>
                    {
                        if (main.selected_row != null)
                        {
                            new citizen_add(true).Show();
                        }
                        else
                        {
                            utils.show_error("NO ITEM SELECTED");
                        }
                    };
                    break;
                case "Doctors":
                    this.dataGridView1.DataSource = data_access.get_data_source("doctors_info");
                    this.add_btn.Click += (x, y) =>
                    {
                        new doctor_add(false).Show();
                    };
                    this.upd_btn.Click += (x, y) =>
                    {
                        if (main.selected_row != null)
                        {
                            new doctor_add(true).Show();
                        }
                        else
                        {
                            utils.show_error("NO ITEM SELECTED");
                        }
                    };
                    break;
                case "Clinics":
                    this.dataGridView1.DataSource = data_access.get_data_source("clinics_info");
                    this.add_btn.Click += (x, y) =>
                    {
                        new clinic_add(false).Show();
                    };
                    this.upd_btn.Click += (x, y) =>
                    {
                        if (main.selected_row != null)
                        {
                            new clinic_add(true).Show();
                        }
                        else
                        {
                            utils.show_error("NO ITEM SELECTED");
                        }
                    };
                    break;
                case "Governmental Insurance":
                    this.dataGridView1.DataSource = data_access.get_data_source("gov_insu_info");
                    this.add_btn.Click += (x, y) =>
                    {
                        new gov_insu_add(false).Show();
                    };
                    this.upd_btn.Click += (x, y) =>
                    {
                        if (main.selected_row != null)
                        {
                            new gov_insu_add(true).Show();
                        }
                        else
                        {
                            utils.show_error("NO ITEM SELECTED");
                        }
                    };
                    break;
                case "Hospitals":
                    this.dataGridView1.DataSource = data_access.get_data_source("hospitals_info");
                    this.add_btn.Click += (x, y) =>
                    {
                        new hospital_add(false).Show();
                    };
                    this.upd_btn.Click += (x, y) =>
                    {
                        if (main.selected_row != null)
                        {
                            new hospital_add(true).Show();
                        }
                        else
                        {
                            utils.show_error("NO ITEM SELECTED");
                        }
                    };
                    break;
                case "Medicines":
                    this.dataGridView1.DataSource = data_access.get_data_source("Medicines");
                    this.add_btn.Click += (x, y) =>
                    {
                        new medicin_add(false).Show();
                    };
                    this.upd_btn.Click += (x, y) =>
                    {
                        if (main.selected_row != null)
                        {
                            new medicin_add(true).Show();
                        }
                        else
                        {
                            utils.show_error("NO ITEM SELECTED");
                        }
                    };
                    break;
                case "Pharmacist":
                    this.dataGridView1.DataSource = data_access.get_data_source("Pharmacist");
                    this.add_btn.Click += (x, y) =>
                    {
                        new phist_add(false).Show();
                    };
                    this.upd_btn.Click += (x, y) =>
                    {
                        if (main.selected_row != null)
                        {
                            new phist_add(true).Show();
                        }
                        else
                        {
                            utils.show_error("NO ITEM SELECTED");
                        }
                    };
                    break;
                case "Pharmacy":
                    this.dataGridView1.DataSource = data_access.get_data_source("pharmacies_info");
                    this.add_btn.Click += (x, y) =>
                    {
                        new phcy_add(false).Show();
                    };
                    this.upd_btn.Click += (x, y) =>
                    {
                        if (main.selected_row != null)
                        {
                            new phcy_add(true).Show();
                        }
                        else
                        {
                            utils.show_error("NO ITEM SELECTED");
                        }
                    };
                    break;
                case "System Admins":
                    this.dataGridView1.DataSource = data_access.get_data_source("admins_info");
                    this.add_btn.Click += (x, y) =>
                    {
                        new signup_from().Show();
                    };
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            main.selected_row = this.dataGridView1.Rows[e.RowIndex];
        }
        private void remove_event_listners(Button b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utils.show_info("Use Guide Information: ");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utils.show_info("Team Members: \nEhab Mansour:\t201800506\nBelal Rashwan:\t201800000\nIbrahim Baza:\t201800867\nEslam Elsharkawy:\t201800473");
        }

        private void accountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new acc_info(this.login_session.Split(':')[0]).Show();
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = data_access.uni_search_engine(this.selected_channel, search_tb.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selected_row == null)
            {
                utils.show_error("NO ITEM SELTECTED!");
                return;
            }
            switch (this.selected_channel)
            {
                case "Citizens":
                    data_access.uni_delete(this.selected_channel, main.selected_row.Cells[0].Value.ToString(), new string[] { });
                    this.dataGridView1.DataSource = data_access.get_data_source("citizens_info");
                    break;
                case "Doctors":
                    data_access.uni_delete(this.selected_channel, main.selected_row.Cells[0].Value.ToString(), new string[] { });
                    this.dataGridView1.DataSource = data_access.get_data_source("doctors_info");
                    break;
                case "Clinics":
                    data_access.uni_delete(this.selected_channel, data_access.get_doctor_id(main.selected_row.Cells[0].Value.ToString()), new string[] { main.selected_row.Cells[1].Value.ToString() });
                    this.dataGridView1.DataSource = data_access.get_data_source("clinics_info");
                    break;
                case "Governmental Insurance":
                    data_access.uni_delete(this.selected_channel, main.selected_row.Cells[0].Value.ToString(), new string[] { });
                    this.dataGridView1.DataSource = data_access.get_data_source("gov_insu_info");
                    break;
                case "Hospitals":
                    data_access.uni_delete(this.selected_channel, main.selected_row.Cells[0].Value.ToString(), new string[] { });
                    this.dataGridView1.DataSource = data_access.get_data_source("hospitals_info");
                    break;
                case "Medicines":
                    data_access.uni_delete(this.selected_channel, main.selected_row.Cells[0].Value.ToString(), new string[] { });
                    this.dataGridView1.DataSource = data_access.get_data_source("Medicines");
                    break;
                case "Pharmacist":
                    data_access.uni_delete(this.selected_channel, main.selected_row.Cells[0].Value.ToString(), new string[] { });
                    this.dataGridView1.DataSource = data_access.get_data_source("Pharmacist");
                    break;
                case "Pharmacy":
                    data_access.uni_delete(this.selected_channel, main.selected_row.Cells[0].Value.ToString(), new string[] { });
                    this.dataGridView1.DataSource = data_access.get_data_source("pharmacies_info");
                    break;
                case "System Admins":
                    data_access.uni_delete(this.selected_channel, main.selected_row.Cells[0].Value.ToString(), new string[] { });
                    this.dataGridView1.DataSource = data_access.get_data_source("admins_info");
                    break;
            }
        }

        private void createBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                data_access.create_backup(sfd.FileName + ".bak");
            }
            utils.show_info("Creating Backup Done!");
        }

        private void loadBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL Backup|*.bak";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                data_access.create_backup(ofd.FileName);
            }
            utils.show_info("Loading Backup Done!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.selected_channel == null)
            {
                utils.show_error("Please Select a Channel From The Database Menustrip");
                return;
            }
            if (main.selected_row == null)
            {
                utils.show_error("No Item Selected For Reporting");
                return;
            }
            string report = data_access.uni_report(true, this.selected_channel, main.selected_row.Cells[0].Value.ToString());
            if (report == null)
            {
                utils.show_info("No Report To Show For This Item");
            }
            else
            {
                new report_view(report, main.selected_row.Cells[0].Value.ToString(), this.selected_channel).Show();
            }
        }

        private void exp_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                utils.write_excel(sfd.FileName + ".xlsx", this.dataGridView1);
            }
            utils.show_info("Report Done!");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.is_lggedout = true;
            this.Close();
        }
    }
}
