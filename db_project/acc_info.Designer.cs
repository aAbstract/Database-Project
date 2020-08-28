namespace db_project
{
    partial class acc_info
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
            this.user_name_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.role_lbl = new System.Windows.Forms.Label();
            this.ssn_lbl = new System.Windows.Forms.Label();
            this.ds_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.er_btn = new System.Windows.Forms.Button();
            this.passr_btn = new System.Windows.Forms.Button();
            this.npass_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_name_lbl
            // 
            this.user_name_lbl.AutoSize = true;
            this.user_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_lbl.Location = new System.Drawing.Point(12, 29);
            this.user_name_lbl.Name = "user_name_lbl";
            this.user_name_lbl.Size = new System.Drawing.Size(129, 26);
            this.user_name_lbl.TabIndex = 0;
            this.user_name_lbl.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(106, 239);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(295, 20);
            this.email_tb.TabIndex = 2;
            // 
            // role_lbl
            // 
            this.role_lbl.AutoSize = true;
            this.role_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_lbl.Location = new System.Drawing.Point(13, 79);
            this.role_lbl.Name = "role_lbl";
            this.role_lbl.Size = new System.Drawing.Size(63, 26);
            this.role_lbl.TabIndex = 3;
            this.role_lbl.Text = "Role:";
            // 
            // ssn_lbl
            // 
            this.ssn_lbl.AutoSize = true;
            this.ssn_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssn_lbl.Location = new System.Drawing.Point(12, 128);
            this.ssn_lbl.Name = "ssn_lbl";
            this.ssn_lbl.Size = new System.Drawing.Size(64, 26);
            this.ssn_lbl.TabIndex = 4;
            this.ssn_lbl.Text = "SSN:";
            // 
            // ds_tb
            // 
            this.ds_tb.Location = new System.Drawing.Point(144, 186);
            this.ds_tb.Name = "ds_tb";
            this.ds_tb.ReadOnly = true;
            this.ds_tb.Size = new System.Drawing.Size(366, 20);
            this.ds_tb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digital Signature";
            // 
            // er_btn
            // 
            this.er_btn.Location = new System.Drawing.Point(407, 236);
            this.er_btn.Name = "er_btn";
            this.er_btn.Size = new System.Drawing.Size(105, 23);
            this.er_btn.TabIndex = 7;
            this.er_btn.Text = "email reset";
            this.er_btn.UseVisualStyleBackColor = true;
            this.er_btn.Click += new System.EventHandler(this.er_btn_Click);
            // 
            // passr_btn
            // 
            this.passr_btn.Location = new System.Drawing.Point(407, 280);
            this.passr_btn.Name = "passr_btn";
            this.passr_btn.Size = new System.Drawing.Size(105, 23);
            this.passr_btn.TabIndex = 10;
            this.passr_btn.Text = "password reset";
            this.passr_btn.UseVisualStyleBackColor = true;
            this.passr_btn.Click += new System.EventHandler(this.passr_btn_Click);
            // 
            // npass_tb
            // 
            this.npass_tb.Location = new System.Drawing.Point(106, 283);
            this.npass_tb.Name = "npass_tb";
            this.npass_tb.Size = new System.Drawing.Size(295, 20);
            this.npass_tb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pass Reset";
            // 
            // acc_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 342);
            this.Controls.Add(this.passr_btn);
            this.Controls.Add(this.npass_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.er_btn);
            this.Controls.Add(this.ds_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ssn_lbl);
            this.Controls.Add(this.role_lbl);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_name_lbl);
            this.Name = "acc_info";
            this.Text = "acc_info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_name_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label role_lbl;
        private System.Windows.Forms.Label ssn_lbl;
        private System.Windows.Forms.TextBox ds_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button er_btn;
        private System.Windows.Forms.Button passr_btn;
        private System.Windows.Forms.TextBox npass_tb;
        private System.Windows.Forms.Label label4;
    }
}