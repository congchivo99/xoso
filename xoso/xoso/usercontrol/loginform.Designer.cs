namespace xoso.usercontrol
{
    partial class loginform
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_sdt = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.cmd_login = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.cmdDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.AutoSize = true;
            this.lbl_sdt.Location = new System.Drawing.Point(9, 12);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(70, 13);
            this.lbl_sdt.TabIndex = 0;
            this.lbl_sdt.Text = "Số điện thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(12, 28);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(223, 20);
            this.txt_sdt.TabIndex = 1;
            this.txt_sdt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sdt_KeyDown);
            // 
            // cmd_login
            // 
            this.cmd_login.AutoSize = true;
            this.cmd_login.Location = new System.Drawing.Point(12, 54);
            this.cmd_login.Name = "cmd_login";
            this.cmd_login.Size = new System.Drawing.Size(81, 23);
            this.cmd_login.TabIndex = 2;
            this.cmd_login.Text = "Đăng nhập";
            this.cmd_login.UseVisualStyleBackColor = true;
            this.cmd_login.Click += new System.EventHandler(this.cmd_login_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(9, 90);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(68, 13);
            this.lblThongBao.TabIndex = 3;
            this.lblThongBao.Text = "Thông báo";
            // 
            // cmdDong
            // 
            this.cmdDong.Location = new System.Drawing.Point(108, 54);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(75, 23);
            this.cmdDong.TabIndex = 4;
            this.cmdDong.Text = "Đóng form";
            this.cmdDong.UseVisualStyleBackColor = true;
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.cmd_login);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.lbl_sdt);
            this.Location = new System.Drawing.Point(25, 25);
            this.Name = "loginform";
            this.Size = new System.Drawing.Size(251, 118);
            this.Load += new System.EventHandler(this.loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sdt;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Button cmd_login;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button cmdDong;
    }
}
