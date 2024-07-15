namespace xoso.usercontrol
{
    partial class dangkyform
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cmdDangKy = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.cmdDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(12, 52);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(276, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đăng ký thông tin";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(12, 98);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(276, 20);
            this.txtHoTen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(12, 145);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(276, 20);
            this.dateTimePickerNgaySinh.TabIndex = 7;
            this.dateTimePickerNgaySinh.Value = new System.DateTime(1999, 1, 1, 14, 29, 0, 0);
            // 
            // cmdDangKy
            // 
            this.cmdDangKy.Location = new System.Drawing.Point(12, 183);
            this.cmdDangKy.Name = "cmdDangKy";
            this.cmdDangKy.Size = new System.Drawing.Size(75, 23);
            this.cmdDangKy.TabIndex = 8;
            this.cmdDangKy.Text = "Đăng ký";
            this.cmdDangKy.UseVisualStyleBackColor = true;
            this.cmdDangKy.Click += new System.EventHandler(this.cmdDangKy_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(12, 219);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(68, 13);
            this.lblThongBao.TabIndex = 9;
            this.lblThongBao.Text = "Thông báo";
            // 
            // cmdDong
            // 
            this.cmdDong.Location = new System.Drawing.Point(152, 183);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(75, 23);
            this.cmdDong.TabIndex = 10;
            this.cmdDong.Text = "Đóng form";
            this.cmdDong.UseVisualStyleBackColor = true;
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // dangkyform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.cmdDangKy);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label1);
            this.Name = "dangkyform";
            this.Size = new System.Drawing.Size(338, 253);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Button cmdDangKy;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button cmdDong;
    }
}
