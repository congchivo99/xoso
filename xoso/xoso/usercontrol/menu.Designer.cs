namespace xoso.usercontrol
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemdangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemdangky = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemuser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemdangnhap,
            this.MenuItemdangky,
            this.MenuItemuser,
            this.MenuItemLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemdangnhap
            // 
            this.MenuItemdangnhap.Name = "MenuItemdangnhap";
            this.MenuItemdangnhap.Size = new System.Drawing.Size(77, 20);
            this.MenuItemdangnhap.Text = "Đăng nhập";
            this.MenuItemdangnhap.Click += new System.EventHandler(this.MenuItemdangnhap_Click);
            // 
            // MenuItemdangky
            // 
            this.MenuItemdangky.Name = "MenuItemdangky";
            this.MenuItemdangky.Size = new System.Drawing.Size(62, 20);
            this.MenuItemdangky.Text = "Đăng ký";
            this.MenuItemdangky.Click += new System.EventHandler(this.MenuItemdangky_Click);
            // 
            // MenuItemuser
            // 
            this.MenuItemuser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuItemuser.Name = "MenuItemuser";
            this.MenuItemuser.Size = new System.Drawing.Size(107, 20);
            this.MenuItemuser.Text = "Chưa đăng nhập";
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(72, 20);
            this.MenuItemLogout.Text = "Đăng xuất";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.menuStrip1);
            this.Name = "menu";
            this.Size = new System.Drawing.Size(544, 31);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemdangnhap;
        private System.Windows.Forms.ToolStripMenuItem MenuItemdangky;
        private System.Windows.Forms.ToolStripMenuItem MenuItemuser;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
    }
}
