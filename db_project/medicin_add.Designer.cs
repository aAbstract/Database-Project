namespace db_project
{
    partial class medicin_add
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
            this.dreg_btn_gi = new System.Windows.Forms.Button();
            this.reg_btn_gi = new System.Windows.Forms.Button();
            this.search_rgv = new System.Windows.Forms.TextBox();
            this.reg_gov_dgv = new System.Windows.Forms.DataGridView();
            this.rgi_slbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.ai_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.all_gov_dgv = new System.Windows.Forms.DataGridView();
            this.search_agv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.agi_slbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nrc_slbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nrc_search = new System.Windows.Forms.TextBox();
            this.nrmc_gv = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rc_slbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rc_search = new System.Windows.Forms.TextBox();
            this.rmc_gv = new System.Windows.Forms.DataGridView();
            this.dreg_btn_mc = new System.Windows.Forms.Button();
            this.reg_btn_mc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reg_gov_dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.all_gov_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrmc_gv)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rmc_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // dreg_btn_gi
            // 
            this.dreg_btn_gi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dreg_btn_gi.Location = new System.Drawing.Point(399, 565);
            this.dreg_btn_gi.Name = "dreg_btn_gi";
            this.dreg_btn_gi.Size = new System.Drawing.Size(81, 66);
            this.dreg_btn_gi.TabIndex = 47;
            this.dreg_btn_gi.Text = "<";
            this.dreg_btn_gi.UseVisualStyleBackColor = true;
            this.dreg_btn_gi.Click += new System.EventHandler(this.dreg_btn_gi_Click);
            // 
            // reg_btn_gi
            // 
            this.reg_btn_gi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn_gi.Location = new System.Drawing.Point(399, 471);
            this.reg_btn_gi.Name = "reg_btn_gi";
            this.reg_btn_gi.Size = new System.Drawing.Size(81, 66);
            this.reg_btn_gi.TabIndex = 46;
            this.reg_btn_gi.Text = ">";
            this.reg_btn_gi.UseVisualStyleBackColor = true;
            this.reg_btn_gi.Click += new System.EventHandler(this.reg_btn_gi_Click);
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
            this.reg_gov_dgv.Size = new System.Drawing.Size(366, 228);
            this.reg_gov_dgv.TabIndex = 0;
            this.reg_gov_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reg_gov_dgv_CellClick);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rgi_slbl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.search_rgv);
            this.groupBox2.Controls.Add(this.reg_gov_dgv);
            this.groupBox2.Location = new System.Drawing.Point(486, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 304);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registerd Government Insurance";
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(362, 710);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(174, 58);
            this.add_btn.TabIndex = 43;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // ai_tb
            // 
            this.ai_tb.Location = new System.Drawing.Point(322, 21);
            this.ai_tb.Name = "ai_tb";
            this.ai_tb.Size = new System.Drawing.Size(214, 20);
            this.ai_tb.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(67, 21);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(214, 20);
            this.id_tb.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "AI";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(608, 23);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(214, 20);
            this.name_tb.TabIndex = 36;
            // 
            // all_gov_dgv
            // 
            this.all_gov_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.all_gov_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_gov_dgv.Location = new System.Drawing.Point(4, 70);
            this.all_gov_dgv.Name = "all_gov_dgv";
            this.all_gov_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.all_gov_dgv.Size = new System.Drawing.Size(366, 228);
            this.all_gov_dgv.TabIndex = 0;
            this.all_gov_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.all_gov_dgv_CellClick);
            // 
            // search_agv
            // 
            this.search_agv.Location = new System.Drawing.Point(50, 33);
            this.search_agv.Name = "search_agv";
            this.search_agv.Size = new System.Drawing.Size(72, 20);
            this.search_agv.TabIndex = 1;
            this.search_agv.TextChanged += new System.EventHandler(this.search_agv_TextChanged);
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
            // agi_slbl
            // 
            this.agi_slbl.AutoSize = true;
            this.agi_slbl.Location = new System.Drawing.Point(141, 36);
            this.agi_slbl.Name = "agi_slbl";
            this.agi_slbl.Size = new System.Drawing.Size(83, 13);
            this.agi_slbl.TabIndex = 3;
            this.agi_slbl.Text = "SELECTED ID: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agi_slbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.search_agv);
            this.groupBox1.Controls.Add(this.all_gov_dgv);
            this.groupBox1.Location = new System.Drawing.Point(17, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 304);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not Registerd Government Insurance";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nrc_slbl);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nrc_search);
            this.groupBox3.Controls.Add(this.nrmc_gv);
            this.groupBox3.Location = new System.Drawing.Point(21, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 304);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Not Registerd Conflicts";
            // 
            // nrc_slbl
            // 
            this.nrc_slbl.AutoSize = true;
            this.nrc_slbl.Location = new System.Drawing.Point(141, 36);
            this.nrc_slbl.Name = "nrc_slbl";
            this.nrc_slbl.Size = new System.Drawing.Size(83, 13);
            this.nrc_slbl.TabIndex = 3;
            this.nrc_slbl.Text = "SELECTED ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search";
            // 
            // nrc_search
            // 
            this.nrc_search.Location = new System.Drawing.Point(50, 33);
            this.nrc_search.Name = "nrc_search";
            this.nrc_search.Size = new System.Drawing.Size(72, 20);
            this.nrc_search.TabIndex = 1;
            this.nrc_search.TextChanged += new System.EventHandler(this.nrc_search_TextChanged);
            // 
            // nrmc_gv
            // 
            this.nrmc_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nrmc_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nrmc_gv.Location = new System.Drawing.Point(4, 70);
            this.nrmc_gv.Name = "nrmc_gv";
            this.nrmc_gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nrmc_gv.Size = new System.Drawing.Size(366, 228);
            this.nrmc_gv.TabIndex = 0;
            this.nrmc_gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nrmc_gv_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rc_slbl);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.rc_search);
            this.groupBox4.Controls.Add(this.rmc_gv);
            this.groupBox4.Location = new System.Drawing.Point(486, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 304);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registerd Conflicts";
            // 
            // rc_slbl
            // 
            this.rc_slbl.AutoSize = true;
            this.rc_slbl.Location = new System.Drawing.Point(154, 36);
            this.rc_slbl.Name = "rc_slbl";
            this.rc_slbl.Size = new System.Drawing.Size(83, 13);
            this.rc_slbl.TabIndex = 3;
            this.rc_slbl.Text = "SELECTED ID: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Search";
            // 
            // rc_search
            // 
            this.rc_search.Location = new System.Drawing.Point(56, 33);
            this.rc_search.Name = "rc_search";
            this.rc_search.Size = new System.Drawing.Size(72, 20);
            this.rc_search.TabIndex = 1;
            this.rc_search.TextChanged += new System.EventHandler(this.rc_search_TextChanged);
            // 
            // rmc_gv
            // 
            this.rmc_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rmc_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rmc_gv.Location = new System.Drawing.Point(4, 70);
            this.rmc_gv.Name = "rmc_gv";
            this.rmc_gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rmc_gv.Size = new System.Drawing.Size(366, 228);
            this.rmc_gv.TabIndex = 0;
            this.rmc_gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rmc_gv_CellClick);
            // 
            // dreg_btn_mc
            // 
            this.dreg_btn_mc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dreg_btn_mc.Location = new System.Drawing.Point(403, 246);
            this.dreg_btn_mc.Name = "dreg_btn_mc";
            this.dreg_btn_mc.Size = new System.Drawing.Size(81, 66);
            this.dreg_btn_mc.TabIndex = 49;
            this.dreg_btn_mc.Text = "<";
            this.dreg_btn_mc.UseVisualStyleBackColor = true;
            this.dreg_btn_mc.Click += new System.EventHandler(this.dreg_btn_mc_Click);
            // 
            // reg_btn_mc
            // 
            this.reg_btn_mc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn_mc.Location = new System.Drawing.Point(403, 152);
            this.reg_btn_mc.Name = "reg_btn_mc";
            this.reg_btn_mc.Size = new System.Drawing.Size(81, 66);
            this.reg_btn_mc.TabIndex = 48;
            this.reg_btn_mc.Text = ">";
            this.reg_btn_mc.UseVisualStyleBackColor = true;
            this.reg_btn_mc.Click += new System.EventHandler(this.reg_btn_mc_Click);
            // 
            // medicin_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 780);
            this.Controls.Add(this.dreg_btn_mc);
            this.Controls.Add(this.reg_btn_mc);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dreg_btn_gi);
            this.Controls.Add(this.reg_btn_gi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ai_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_tb);
            this.Name = "medicin_add";
            this.Text = "medicin_add";
            ((System.ComponentModel.ISupportInitialize)(this.reg_gov_dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.all_gov_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrmc_gv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rmc_gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dreg_btn_gi;
        private System.Windows.Forms.Button reg_btn_gi;
        private System.Windows.Forms.TextBox search_rgv;
        private System.Windows.Forms.DataGridView reg_gov_dgv;
        private System.Windows.Forms.Label rgi_slbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox ai_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.DataGridView all_gov_dgv;
        private System.Windows.Forms.TextBox search_agv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label agi_slbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label nrc_slbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nrc_search;
        private System.Windows.Forms.DataGridView nrmc_gv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label rc_slbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rc_search;
        private System.Windows.Forms.DataGridView rmc_gv;
        private System.Windows.Forms.Button dreg_btn_mc;
        private System.Windows.Forms.Button reg_btn_mc;
    }
}