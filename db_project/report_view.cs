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
    public partial class report_view : Form
    {
        private string channel = null;
        private string id = null;
        public report_view(string content, string _id, string _channel)
        {
            InitializeComponent();
            this.richTextBox1.Text = content; // Load Report Content
            this.channel = _channel;
            this.id = _id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save Report to Text File
            SaveFileDialog sfd = new SaveFileDialog(); // Open Save File Dialog
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                utils.write_txt(data_access.uni_report(false, this.channel, this.id), sfd.FileName + ".txt"); // Write Report to Selected File
            }
            utils.show_info("Done!");
        }
    }
}
