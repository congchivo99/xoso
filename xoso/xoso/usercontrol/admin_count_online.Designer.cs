namespace xoso.usercontrol
{
    partial class admin_count_online
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
            this.luoitk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.luoitk)).BeginInit();
            this.SuspendLayout();
            // 
            // luoitk
            // 
            this.luoitk.AllowUserToAddRows = false;
            this.luoitk.AllowUserToDeleteRows = false;
            this.luoitk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.luoitk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.luoitk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoitk.Location = new System.Drawing.Point(12, 28);
            this.luoitk.Name = "luoitk";
            this.luoitk.ReadOnly = true;
            this.luoitk.Size = new System.Drawing.Size(176, 139);
            this.luoitk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đang online";
            // 
            // admin_count_online
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luoitk);
            this.Name = "admin_count_online";
            this.Size = new System.Drawing.Size(200, 180);
            this.Load += new System.EventHandler(this.admin_count_online_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoitk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView luoitk;
        private System.Windows.Forms.Label label1;
    }
}
