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
    public partial class gov_insu_add : Form
    {
        private bool update_flag;
        public gov_insu_add(bool flag)
        {
            InitializeComponent();
            this.update_flag = flag; // Save Mode Flag (True -> Update Mode, False -> Add Mode)
            if (flag) // Update Mode
            {
                this.id_tb.Text = main.selected_row.Cells[0].Value.ToString(); // Load ID From Main Table in Main Form
                this.id_tb.ReadOnly = true; // Set ID Text Box to Read Only Mode
                this.name_tb.Text = main.selected_row.Cells[1].Value.ToString(); // Load Field #1 From Main Table in Main Form 
                this.phone_tb.Text = main.selected_row.Cells[2].Value.ToString(); // Load Field #2 From Main Table in Main Form
                this.addr_tb.Text = main.selected_row.Cells[3].Value.ToString(); // Load Field #3 From Main Table in Main Form
                this.button1.Text = "UPDATE";
                this.button1.Click += (x, y) => // Attach Update Action to Main Button
                {
                    try
                    {
                        // data_access Function to Add or Update Government Insurance Entity
                        data_access.cu_gov_inus(this.update_flag, this.id_tb.Text, this.name_tb.Text, this.phone_tb.Text, this.addr_tb.Text);
                        utils.show_info("Updating Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("gov_insu_info"); // Reload Main Table in Main Form
                    this.Close();
                };
            }
            else // Add Mode
            {
                this.button1.Click += (x, y) => // Attach Add Action to Main Button
                {
                    try
                    {
                        // data_access Function to Add or Update Government Insurance Entity
                        data_access.cu_gov_inus(this.update_flag, this.id_tb.Text, this.name_tb.Text, this.phone_tb.Text, this.addr_tb.Text);
                        utils.show_info("Adding Done!");
                    }
                    catch (Exception excption)
                    {
                        utils.show_error(excption.Message);
                    }
                    main.dgv_ref.DataSource = data_access.get_data_source("gov_insu_info"); // Reload Main Table in Main Form
                    this.Close();
                };
            }
        }
    }
}
