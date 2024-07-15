namespace xoso
{
    partial class ClientForm
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
            this.statusbar1 = new xoso.usercontrol.statusbar();
            this.menu1 = new xoso.usercontrol.menu();
            this.SuspendLayout();
            // 
            // statusbar1
            // 
            this.statusbar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusbar1.Location = new System.Drawing.Point(0, 402);
            this.statusbar1.Name = "statusbar1";
            this.statusbar1.Size = new System.Drawing.Size(727, 25);
            this.statusbar1.TabIndex = 1;
            // 
            // menu1
            // 
            this.menu1.AutoScroll = true;
            this.menu1.AutoSize = true;
            this.menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(727, 24);
            this.menu1.TabIndex = 0;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 427);
            this.Controls.Add(this.statusbar1);
            this.Controls.Add(this.menu1);
            this.Name = "ClientForm";
            this.Text = "Client Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private usercontrol.menu menu1;
        private usercontrol.statusbar statusbar1;
    }
}

