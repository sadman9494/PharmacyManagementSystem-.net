
namespace PharmacyManagement
{
    partial class AdminBillHistory
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
            this.adminBillHistoryGridView = new System.Windows.Forms.DataGridView();
            this.adminBillGridView = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.adminBillHistoryGridView)).BeginInit();
            this.adminBillGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminBillHistoryGridView
            // 
            this.adminBillHistoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminBillHistoryGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminBillHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminBillHistoryGridView.Location = new System.Drawing.Point(6, 19);
            this.adminBillHistoryGridView.Name = "adminBillHistoryGridView";
            this.adminBillHistoryGridView.Size = new System.Drawing.Size(1388, 522);
            this.adminBillHistoryGridView.TabIndex = 0;
            // 
            // adminBillGridView
            // 
            this.adminBillGridView.Controls.Add(this.adminBillHistoryGridView);
            this.adminBillGridView.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBillGridView.Location = new System.Drawing.Point(28, 33);
            this.adminBillGridView.Name = "adminBillGridView";
            this.adminBillGridView.Size = new System.Drawing.Size(1400, 547);
            this.adminBillGridView.TabIndex = 1;
            this.adminBillGridView.TabStop = false;
            this.adminBillGridView.Text = "All Bills";
            // 
            // AdminBillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.adminBillGridView);
            this.Name = "AdminBillHistory";
            this.Size = new System.Drawing.Size(1638, 656);
            this.Load += new System.EventHandler(this.AdminBillHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminBillHistoryGridView)).EndInit();
            this.adminBillGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminBillHistoryGridView;
        private System.Windows.Forms.GroupBox adminBillGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
