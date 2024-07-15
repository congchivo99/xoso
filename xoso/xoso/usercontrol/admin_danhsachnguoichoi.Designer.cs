namespace xoso.usercontrol
{
    partial class admin_danhsachnguoichoi
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
            this.dgv_nguoichoi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoichoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách người chơi";
            // 
            // dgv_nguoichoi
            // 
            this.dgv_nguoichoi.AllowUserToAddRows = false;
            this.dgv_nguoichoi.AllowUserToDeleteRows = false;
            this.dgv_nguoichoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nguoichoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_nguoichoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguoichoi.Location = new System.Drawing.Point(12, 28);
            this.dgv_nguoichoi.MultiSelect = false;
            this.dgv_nguoichoi.Name = "dgv_nguoichoi";
            this.dgv_nguoichoi.ReadOnly = true;
            this.dgv_nguoichoi.Size = new System.Drawing.Size(220, 280);
            this.dgv_nguoichoi.TabIndex = 2;
            this.dgv_nguoichoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nguoichoi_CellClick);
            // 
            // admin_danhsachnguoichoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dgv_nguoichoi);
            this.Controls.Add(this.label1);
            this.Name = "admin_danhsachnguoichoi";
            this.Size = new System.Drawing.Size(244, 319);
            this.Load += new System.EventHandler(this.admin_danhsachnguoichoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoichoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_nguoichoi;
    }
}
