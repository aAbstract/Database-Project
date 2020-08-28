namespace db_project
{
    partial class hospital_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.agi_slbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.search_agv = new System.Windows.Forms.TextBox();
            this.all_gov_dgv = new System.Windows.Forms.DataGridView();
            this.spec_tb = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addr_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rgi_slbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.search_rgv = new System.Windows.Forms.TextBox();
            this.reg_gov_dgv = new System.Windows.Forms.DataGridView();
            this.reg_btn = new System.Windows.Forms.Button();
            this.dreg_btn = new System.Windows.Forms.Button();
            this.manager_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.all_gov_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_gov_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Spec";
            // 
            // agi_slbl
            // 
            this.agi_slbl.AutoSize = true;
            this.agi_slbl.Location = new System.Drawing.Point(141, 36);
            this.agi_slbl.Name = "agi_slbl";
            this.agi_slbl.Size = new System.Drawing.Size(83, 13);
            this.agi_slbl.TabIndex = 3;
            this.agi_slbl.Text = "SELECTED ID: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Search";
            // 
            // search_agv
            // 
            this.search_agv.Location = new System.Drawing.Point(50, 33);
            this.search_agv.Name = "search_agv";
            this.search_agv.Size = new System.Drawing.Size(72, 20);
            this.search_agv.TabIndex = 1;
            this.search_agv.TextChanged += new System.EventHandler(this.search_agv_TextChanged);
            // 
            // all_gov_dgv
            // 
            this.all_gov_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.all_gov_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_gov_dgv.Location = new System.Drawing.Point(4, 70);
            this.all_gov_dgv.Name = "all_gov_dgv";
            this.all_gov_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.all_gov_dgv.Size = new System.Drawing.Size(366, 261);
            this.all_gov_dgv.TabIndex = 0;
            this.all_gov_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.all_gov_dgv_CellClick);
            // 
            // spec_tb
            // 
            this.spec_tb.Location = new System.Drawing.Point(549, 113);
            this.spec_tb.Name = "spec_tb";
            this.spec_tb.Size = new System.Drawing.Size(254, 20);
            this.spec_tb.TabIndex = 28;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(369, 537);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(174, 58);
            this.add_btn.TabIndex = 26;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agi_slbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.search_agv);
            this.groupBox1.Controls.Add(this.all_gov_dgv);
            this.groupBox1.Location = new System.Drawing.Point(24, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 337);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not Registerd Government Insurance";
            // 
            // phone_tb
            // 
            this.phone_tb.Location = new System.Drawing.Point(98, 68);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(254, 20);
            this.phone_tb.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phone";
            // 
            // addr_tb
            // 
            this.addr_tb.Location = new System.Drawing.Point(549, 68);
            this.addr_tb.Name = "addr_tb";
            this.addr_tb.Size = new System.Drawing.Size(254, 20);
            this.addr_tb.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(549, 16);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(254, 20);
            this.name_tb.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(98, 16);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(254, 20);
            this.id_tb.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rgi_slbl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.search_rgv);
            this.groupBox2.Controls.Add(this.reg_gov_dgv);
            this.groupBox2.Location = new System.Drawing.Point(493, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 337);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registerd Government Insurance";
            // 
            // rgi_slbl
            // 
            this.rgi_slbl.AutoSize = true;
            this.rgi_slbl.Location = new System.Drawing.Point(154, 36);
            this.rgi_slbl.Name = "rgi_slbl";
            this.rgi_slbl.Size = new System.Drawing.Size(83, 13);
            this.rgi_slbl.TabIndex = 3;
            this.rgi_slbl.Text = "SELECTED ID: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Search";
            // 
            // search_rgv
            // 
            this.search_rgv.Location = new System.Drawing.Point(56, 33);
            this.search_rgv.Name = "search_rgv";
            this.search_rgv.Size = new System.Drawing.Size(72, 20);
            this.search_rgv.TabIndex = 1;
            this.search_rgv.TextChanged += new System.EventHandler(this.search_rgv_TextChanged);
            // 
            // reg_gov_dgv
            // 
            this.reg_gov_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reg_gov_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reg_gov_dgv.Location = new System.Drawing.Point(4, 70);
            this.reg_gov_dgv.Name = "reg_gov_dgv";
            this.reg_gov_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reg_gov_dgv.Size = new System.Drawing.Size(366, 261);
            this.reg_gov_dgv.TabIndex = 0;
            this.reg_gov_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reg_gov_dgv_CellClick);
            // 
            // reg_btn
            // 
            this.reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.Location = new System.Drawing.Point(406, 288);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(81, 66);
            this.reg_btn.TabIndex = 29;
            this.reg_btn.Text = ">";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // dreg_btn
            // 
            this.dreg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dreg_btn.Location = new System.Drawing.Point(406, 382);
            this.dreg_btn.Name = "dreg_btn";
            this.dreg_btn.Size = new System.Drawing.Size(81, 66);
            this.dreg_btn.TabIndex = 30;
            this.dreg_btn.Text = "<";
            this.dreg_btn.UseVisualStyleBackColor = true;
            this.dreg_btn.Click += new System.EventHandler(this.dreg_btn_Click);
            // 
            // manager_tb
            // 
            this.manager_tb.Location = new System.Drawing.Point(98, 113);
            this.manager_tb.Name = "manager_tb";
            this.manager_tb.Size = new System.Drawing.Size(254, 20);
            this.manager_tb.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Manager";
            // 
            // hospital_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 612);
            this.Controls.Add(this.manager_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dreg_btn);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spec_tb);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.phone_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addr_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label1);
            this.Name = "hospital_add";
            this.Text = "hospital_add";
            ((System.ComponentModel.ISupportInitialize)(this.all_gov_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_gov_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label agi_slbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox search_agv;
        private System.Windows.Forms.DataGridView all_gov_dgv;
        private System.Windows.Forms.TextBox spec_tb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addr_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label rgi_slbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox search_rgv;
        private System.Windows.Forms.DataGridView reg_gov_dgv;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Button dreg_btn;
        private System.Windows.Forms.TextBox manager_tb;
        private System.Windows.Forms.Label label3;
    }
}