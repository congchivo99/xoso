namespace xoso.usercontrol
{
    partial class form_datcuoc
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChonSo = new System.Windows.Forms.NumericUpDown();
            this.cmdDat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtChonSo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hãy đặt cược một số nguyên từ 0 .. 9";
            // 
            // txtChonSo
            // 
            this.txtChonSo.Location = new System.Drawing.Point(12, 75);
            this.txtChonSo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.txtChonSo.Name = "txtChonSo";
            this.txtChonSo.Size = new System.Drawing.Size(159, 20);
            this.txtChonSo.TabIndex = 2;
            this.txtChonSo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChonSo_KeyDown);
            // 
            // cmdDat
            // 
            this.cmdDat.Location = new System.Drawing.Point(12, 112);
            this.cmdDat.Name = "cmdDat";
            this.cmdDat.Size = new System.Drawing.Size(75, 23);
            this.cmdDat.TabIndex = 3;
            this.cmdDat.Text = "Đặt";
            this.cmdDat.UseVisualStyleBackColor = true;
            this.cmdDat.Click += new System.EventHandler(this.cmdDat_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(104, 117);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(115, 13);
            this.lblThoiGian.TabIndex = 5;
            this.lblThoiGian.Text = "Thời gian còn lại 00:00";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(69, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "SDT";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(12, 146);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(68, 13);
            this.lblThongBao.TabIndex = 7;
            this.lblThongBao.Text = "Thông báo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ĐẶT CƯỢC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tài khoản";
            // 
            // form_datcuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.cmdDat);
            this.Controls.Add(this.txtChonSo);
            this.Controls.Add(this.label1);
            this.Name = "form_datcuoc";
            this.Size = new System.Drawing.Size(271, 188);
            this.Load += new System.EventHandler(this.form_datcuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtChonSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtChonSo;
        private System.Windows.Forms.Button cmdDat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
