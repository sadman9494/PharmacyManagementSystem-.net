﻿
namespace PharmacyManagement
{
    partial class BillHistory
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
            this.billHistoryGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.billHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // billHistoryGridView
            // 
            this.billHistoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billHistoryGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.billHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billHistoryGridView.Location = new System.Drawing.Point(132, 31);
            this.billHistoryGridView.Name = "billHistoryGridView";
            this.billHistoryGridView.Size = new System.Drawing.Size(1386, 605);
            this.billHistoryGridView.TabIndex = 0;
            // 
            // BillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.billHistoryGridView);
            this.Name = "BillHistory";
            this.Size = new System.Drawing.Size(1638, 656);
            this.Load += new System.EventHandler(this.BillHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billHistoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView billHistoryGridView;
    }
}
