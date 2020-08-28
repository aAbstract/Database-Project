namespace db_project
{
    partial class phcy_add
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
            this.pws_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ssn_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reg_med_slbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_med_search = new System.Windows.Forms.TextBox();
            this.reg_med_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.avl_med_slbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.avl_med_search = new System.Windows.Forms.TextBox();
            this.avl_med_dgv = new System.Windows.Forms.DataGridView();
            this.med_reg_btn = new System.Windows.Forms.Button();
            this.med_dreg_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_med_dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avl_med_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pws_lbl
            // 
            this.pws_lbl.AutoSize = true;
            this.pws_lbl.Location = new System.Drawing.Point(271, 36);
            this.pws_lbl.Name = "pws_lbl";
            this.pws_lbl.Size = new System.Drawing.Size(83, 13);
            this.pws_lbl.TabIndex = 3;
            this.pws_lbl.Text = "SELECTED ID: ";
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
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(50, 33);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(203, 20);
            this.search_tb.TabIndex = 1;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(439, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(390, 702);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 58);
            this.button1.TabIndex = 26;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pws_lbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.search_tb);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(497, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 337);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Owner Info";
            // 
            // phone_tb
            // 
            this.phone_tb.Location = new System.Drawing.Point(67, 185);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(339, 20);
            this.phone_tb.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phone";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(67, 112);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(339, 20);
            this.name_tb.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // ssn_tb
            // 
            this.ssn_tb.Location = new System.Drawing.Point(67, 29);
            this.ssn_tb.Name = "ssn_tb";
            this.ssn_tb.Size = new System.Drawing.Size(339, 20);
            this.ssn_tb.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reg_med_slbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.reg_med_search);
            this.groupBox2.Controls.Add(this.reg_med_dgv);
            this.groupBox2.Location = new System.Drawing.Point(536, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 337);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registerd Medicine";
            // 
            // reg_med_slbl
            // 
            this.reg_med_slbl.AutoSize = true;
            this.reg_med_slbl.Location = new System.Drawing.Point(233, 37);
            this.reg_med_slbl.Name = "reg_med_slbl";
            this.reg_med_slbl.Size = new System.Drawing.Size(83, 13);
            this.reg_med_slbl.TabIndex = 3;
            this.reg_med_slbl.Text = "SELECTED ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search";
            // 
            // reg_med_search
            // 
            this.reg_med_search.Location = new System.Drawing.Point(50, 33);
            this.reg_med_search.Name = "reg_med_search";
            this.reg_med_search.Size = new System.Drawing.Size(177, 20);
            this.reg_med_search.TabIndex = 1;
            this.reg_med_search.TextChanged += new System.EventHandler(this.reg_med_search_TextChanged);
            // 
            // reg_med_dgv
            // 
            this.reg_med_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reg_med_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reg_med_dgv.Location = new System.Drawing.Point(4, 70);
            this.reg_med_dgv.Name = "reg_med_dgv";
            this.reg_med_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reg_med_dgv.Size = new System.Drawing.Size(400, 261);
            this.reg_med_dgv.TabIndex = 0;
            this.reg_med_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reg_med_dgv_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.avl_med_slbl);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.avl_med_search);
            this.groupBox3.Controls.Add(this.avl_med_dgv);
            this.groupBox3.Location = new System.Drawing.Point(14, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 337);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Medicine";
            // 
            // avl_med_slbl
            // 
            this.avl_med_slbl.AutoSize = true;
            this.avl_med_slbl.Location = new System.Drawing.Point(233, 37);
            this.avl_med_slbl.Name = "avl_med_slbl";
            this.avl_med_slbl.Size = new System.Drawing.Size(83, 13);
            this.avl_med_slbl.TabIndex = 3;
            this.avl_med_slbl.Text = "SELECTED ID: ";
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
            // avl_med_search
            // 
            this.avl_med_search.Location = new System.Drawing.Point(50, 33);
            this.avl_med_search.Name = "avl_med_search";
            this.avl_med_search.Size = new System.Drawing.Size(177, 20);
            this.avl_med_search.TabIndex = 1;
            this.avl_med_search.TextChanged += new System.EventHandler(this.avl_med_search_TextChanged);
            // 
            // avl_med_dgv
            // 
            this.avl_med_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.avl_med_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avl_med_dgv.Location = new System.Drawing.Point(4, 70);
            this.avl_med_dgv.Name = "avl_med_dgv";
            this.avl_med_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.avl_med_dgv.Size = new System.Drawing.Size(400, 261);
            this.avl_med_dgv.TabIndex = 0;
            this.avl_med_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.avl_med_dgv_CellClick);
            // 
            // med_reg_btn
            // 
            this.med_reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_reg_btn.Location = new System.Drawing.Point(434, 473);
            this.med_reg_btn.Name = "med_reg_btn";
            this.med_reg_btn.Size = new System.Drawing.Size(100, 58);
            this.med_reg_btn.TabIndex = 28;
            this.med_reg_btn.Text = ">";
            this.med_reg_btn.UseVisualStyleBackColor = true;
            this.med_reg_btn.Click += new System.EventHandler(this.med_reg_btn_Click);
            // 
            // med_dreg_btn
            // 
            this.med_dreg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_dreg_btn.Location = new System.Drawing.Point(434, 557);
            this.med_dreg_btn.Name = "med_dreg_btn";
            this.med_dreg_btn.Size = new System.Drawing.Size(100, 58);
            this.med_dreg_btn.TabIndex = 29;
            this.med_dreg_btn.Text = "<";
            this.med_dreg_btn.UseVisualStyleBackColor = true;
            this.med_dreg_btn.Click += new System.EventHandler(this.med_dreg_btn_Click);
            // 
            // phcy_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 772);
            this.Controls.Add(this.med_dreg_btn);
            this.Controls.Add(this.med_reg_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.phone_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ssn_tb);
            this.Controls.Add(this.label1);
            this.Name = "phcy_add";
            this.Text = "phcy_add";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_med_dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avl_med_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pws_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ssn_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label reg_med_slbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reg_med_search;
        private System.Windows.Forms.DataGridView reg_med_dgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label avl_med_slbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox avl_med_search;
        private System.Windows.Forms.DataGridView avl_med_dgv;
        private System.Windows.Forms.Button med_reg_btn;
        private System.Windows.Forms.Button med_dreg_btn;
    }
}