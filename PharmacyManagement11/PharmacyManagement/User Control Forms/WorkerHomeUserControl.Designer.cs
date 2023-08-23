
namespace PharmacyManagement
{
    partial class WorkerHomeUserControl
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
            this.HomeTitleLabel = new System.Windows.Forms.Label();
            this.HomeNameIDLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topSoldMedicineLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yesterdaySalesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.todaySalesLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeTitleLabel
            // 
            this.HomeTitleLabel.AutoSize = true;
            this.HomeTitleLabel.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitleLabel.Location = new System.Drawing.Point(689, 617);
            this.HomeTitleLabel.Name = "HomeTitleLabel";
            this.HomeTitleLabel.Size = new System.Drawing.Size(210, 17);
            this.HomeTitleLabel.TabIndex = 1;
            this.HomeTitleLabel.Text = "Pharmacy Management System";
            // 
            // HomeNameIDLabel
            // 
            this.HomeNameIDLabel.AutoSize = true;
            this.HomeNameIDLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeNameIDLabel.Location = new System.Drawing.Point(598, 499);
            this.HomeNameIDLabel.Name = "HomeNameIDLabel";
            this.HomeNameIDLabel.Size = new System.Drawing.Size(278, 64);
            this.HomeNameIDLabel.TabIndex = 0;
            this.HomeNameIDLabel.Text = "Name [ID]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.topSoldMedicineLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(120, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 257);
            this.panel1.TabIndex = 3;
            // 
            // topSoldMedicineLabel
            // 
            this.topSoldMedicineLabel.AutoSize = true;
            this.topSoldMedicineLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topSoldMedicineLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topSoldMedicineLabel.Location = new System.Drawing.Point(29, 158);
            this.topSoldMedicineLabel.Name = "topSoldMedicineLabel";
            this.topSoldMedicineLabel.Size = new System.Drawing.Size(57, 25);
            this.topSoldMedicineLabel.TabIndex = 1;
            this.topSoldMedicineLabel.Text = "Napa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(58, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Top Sold Medicine";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.yesterdaySalesLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(501, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 257);
            this.panel2.TabIndex = 2;
            // 
            // yesterdaySalesLabel
            // 
            this.yesterdaySalesLabel.AutoSize = true;
            this.yesterdaySalesLabel.Font = new System.Drawing.Font("Dutch801 XBd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesterdaySalesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yesterdaySalesLabel.Location = new System.Drawing.Point(102, 158);
            this.yesterdaySalesLabel.Name = "yesterdaySalesLabel";
            this.yesterdaySalesLabel.Size = new System.Drawing.Size(133, 32);
            this.yesterdaySalesLabel.TabIndex = 2;
            this.yesterdaySalesLabel.Text = "200 Units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(71, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yesterday Sales";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.todaySalesLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(936, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 257);
            this.panel3.TabIndex = 3;
            // 
            // todaySalesLabel
            // 
            this.todaySalesLabel.AutoSize = true;
            this.todaySalesLabel.Font = new System.Drawing.Font("Dutch801 XBd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaySalesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.todaySalesLabel.Location = new System.Drawing.Point(114, 158);
            this.todaySalesLabel.Name = "todaySalesLabel";
            this.todaySalesLabel.Size = new System.Drawing.Size(118, 32);
            this.todaySalesLabel.TabIndex = 3;
            this.todaySalesLabel.Text = "50 Units";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(78, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Today\'s Sales";
            // 
            // WorkerHomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HomeTitleLabel);
            this.Controls.Add(this.HomeNameIDLabel);
            this.Name = "WorkerHomeUserControl";
            this.Size = new System.Drawing.Size(1374, 641);
            this.Load += new System.EventHandler(this.WorkerHomeUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HomeTitleLabel;
        private System.Windows.Forms.Label HomeNameIDLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label topSoldMedicineLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label yesterdaySalesLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label todaySalesLabel;
        private System.Windows.Forms.Label label4;
    }
}
