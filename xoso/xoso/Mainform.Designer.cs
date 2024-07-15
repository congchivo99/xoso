namespace xoso
{
    partial class Mainform
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
            this.cmdAdmin = new System.Windows.Forms.Button();
            this.cmdClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAdmin
            // 
            this.cmdAdmin.Location = new System.Drawing.Point(99, 95);
            this.cmdAdmin.Name = "cmdAdmin";
            this.cmdAdmin.Size = new System.Drawing.Size(75, 50);
            this.cmdAdmin.TabIndex = 0;
            this.cmdAdmin.Text = "Admin Form";
            this.cmdAdmin.UseVisualStyleBackColor = true;
            this.cmdAdmin.Click += new System.EventHandler(this.cmdAdmin_Click);
            // 
            // cmdClient
            // 
            this.cmdClient.Location = new System.Drawing.Point(262, 95);
            this.cmdClient.Name = "cmdClient";
            this.cmdClient.Size = new System.Drawing.Size(75, 50);
            this.cmdClient.TabIndex = 1;
            this.cmdClient.Text = "Client Form";
            this.cmdClient.UseVisualStyleBackColor = true;
            this.cmdClient.Click += new System.EventHandler(this.cmdClient_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 262);
            this.Controls.Add(this.cmdClient);
            this.Controls.Add(this.cmdAdmin);
            this.Name = "Mainform";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAdmin;
        private System.Windows.Forms.Button cmdClient;
    }
}