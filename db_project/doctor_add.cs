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
    public partial class doctor_add : Form
    {
        private bool update_flag;
        public doctor_add(bool flag)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = data_access.get_data_source("gov_insu_info"); // data_access Function To Load Goverenment Insurances From Database
            this.update_flag = flag; // Save Mode Flag (True -> Update Mode, False -> Add Mode)
            if (flag) // if Update Mode
            {
                this.ssn_tb.Text = main.selected_row.Cells[0].Value.ToString(); // Load Item ID From Main Table in Main Form
                this.ssn_tb.ReadOnly = true; // Set ID Textbox To Read Only Mode
                this.name_tb.Text = main.selected_row.Cells[1].Value.ToString(); // Load Item Field #1 From Main Table in Main Form
                this.dateTimePicker1.Value = DateTime.Parse(main.selected_row.Cells[2].Value.ToString()); // Load Item Field #2 From Main Table in Main Form
                this.addr_tb.Text = main.selected_row.Cells[3].Value.ToString(); // Load Item Field #3 From Main Table in Main Form
                this.phone_tb.Text = main.selected_row.Cells[4].Value.ToString(); // Load Item Field #4 From Main Table in Main Form
                this.spec_tb.Text = main.selected_row.Cells[5].Value.ToString(); // Load Item Field #5 From Main Table in Main Form
                this.gi_lbl.Text = "SELECTED ID: " + data_access.get_insu_id(main.selected_row.Cells[7].Value.ToString()); // Load Item Field #7 From Main Table in Main Form
                this.button1.Text = "UPDATE";
                this.button1.Click += (x, y) => // Attach Update Action To Main Button
                {
                    try
                    {
                        data_access.cu_doctor(this.update_flag, this.ssn_tb.Text, this.name_tb.Text, this.dateTimePicker1.Value.ToString("yyyy-MM-dd"), this.addr_tb.Text, this.phone_tb.Text, this.spec_tb.Text, this.gi_lbl.Text.Split(' ')[2]);
                        utils.show_info("Updating Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("doctors_info"); // Reload Main Table in Main Form
                    this.Close();
                };
            }
            else // Add Mode
            {
                this.button1.Click += (x, y) => // Attach Add Action To Main Button
                {
                    try
                    {
                        // data_access Function To Add or Update Doctor Entity
                        data_access.cu_doctor(this.update_flag, this.ssn_tb.Text, this.name_tb.Text, this.dateTimePicker1.Value.ToString("yyyy-MM-dd"), this.addr_tb.Text, this.phone_tb.Text, this.spec_tb.Text, this.gi_lbl.Text.Split(' ')[2]);
                        utils.show_info("Adding Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("doctors_info"); // Reload Main Table in Main Form
                    this.Close();
                };
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.gi_lbl.Text = "SELECTED ID: " + this.dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString(); // Keep Track of Selected Insurance ID
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = data_access.gov_insu_search(this.search_tb.Text); // data_access Function Government Insurance Search in Database
        }
    }
}