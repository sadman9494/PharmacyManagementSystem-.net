
namespace PharmacyManagement
{
    partial class AdminHome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminLogOutButton = new System.Windows.Forms.Button();
            this.workerHomeSideBarLabel = new System.Windows.Forms.Label();
            this.AdminHomePanel = new System.Windows.Forms.Panel();
            this.AdminPanelClearButton = new System.Windows.Forms.Button();
            this.manageEmployeeButton = new System.Windows.Forms.Button();
            this.salesAndInventoryButton = new System.Windows.Forms.Button();
            this.billHistoryButton = new System.Windows.Forms.Button();
            this.adminIssuesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 781);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // adminLogOutButton
            // 
            this.adminLogOutButton.BackColor = System.Drawing.Color.DarkRed;
            this.adminLogOutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogOutButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.adminLogOutButton.Location = new System.Drawing.Point(33, 595);
            this.adminLogOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.adminLogOutButton.Name = "adminLogOutButton";
            this.adminLogOutButton.Size = new System.Drawing.Size(130, 46);
            this.adminLogOutButton.TabIndex = 14;
            this.adminLogOutButton.Text = "Log Out";
            this.adminLogOutButton.UseVisualStyleBackColor = false;
            this.adminLogOutButton.Click += new System.EventHandler(this.workerLogOutButton_Click);
            // 
            // workerHomeSideBarLabel
            // 
            this.workerHomeSideBarLabel.AutoSize = true;
            this.workerHomeSideBarLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.workerHomeSideBarLabel.Font = new System.Drawing.Font("Vineta BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerHomeSideBarLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.workerHomeSideBarLabel.Location = new System.Drawing.Point(27, 26);
            this.workerHomeSideBarLabel.Name = "workerHomeSideBarLabel";
            this.workerHomeSideBarLabel.Size = new System.Drawing.Size(147, 32);
            this.workerHomeSideBarLabel.TabIndex = 15;
            this.workerHomeSideBarLabel.Text = "ADMIN";
            this.workerHomeSideBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.workerHomeSideBarLabel.Click += new System.EventHandler(this.workerHomeSideBarLabel_Click);
            // 
            // AdminHomePanel
            // 
            this.AdminHomePanel.BackColor = System.Drawing.Color.Lavender;
            this.AdminHomePanel.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomePanel.Location = new System.Drawing.Point(206, 0);
            this.AdminHomePanel.Name = "AdminHomePanel";
            this.AdminHomePanel.Size = new System.Drawing.Size(1374, 641);
            this.AdminHomePanel.TabIndex = 21;
            this.AdminHomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminHomePanel_Paint);
            // 
            // AdminPanelClearButton
            // 
            this.AdminPanelClearButton.BackColor = System.Drawing.Color.LightPink;
            this.AdminPanelClearButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanelClearButton.Location = new System.Drawing.Point(1533, 649);
            this.AdminPanelClearButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AdminPanelClearButton.Name = "AdminPanelClearButton";
            this.AdminPanelClearButton.Size = new System.Drawing.Size(36, 34);
            this.AdminPanelClearButton.TabIndex = 55;
            this.AdminPanelClearButton.Text = "X";
            this.AdminPanelClearButton.UseVisualStyleBackColor = false;
            this.AdminPanelClearButton.Click += new System.EventHandler(this.WorkerPanelClearButton_Click);
            // 
            // manageEmployeeButton
            // 
            this.manageEmployeeButton.BackColor = System.Drawing.Color.Indigo;
            this.manageEmployeeButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEmployeeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageEmployeeButton.Location = new System.Drawing.Point(33, 112);
            this.manageEmployeeButton.Name = "manageEmployeeButton";
            this.manageEmployeeButton.Size = new System.Drawing.Size(130, 52);
            this.manageEmployeeButton.TabIndex = 56;
            this.manageEmployeeButton.Text = "Manage Employees";
            this.manageEmployeeButton.UseVisualStyleBackColor = false;
            this.manageEmployeeButton.Click += new System.EventHandler(this.manageEmployeeButton_Click);
            // 
            // salesAndInventoryButton
            // 
            this.salesAndInventoryButton.BackColor = System.Drawing.Color.Indigo;
            this.salesAndInventoryButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesAndInventoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salesAndInventoryButton.Location = new System.Drawing.Point(33, 204);
            this.salesAndInventoryButton.Name = "salesAndInventoryButton";
            this.salesAndInventoryButton.Size = new System.Drawing.Size(130, 52);
            this.salesAndInventoryButton.TabIndex = 57;
            this.salesAndInventoryButton.Text = "Sales And Inventory";
            this.salesAndInventoryButton.UseVisualStyleBackColor = false;
            this.salesAndInventoryButton.Click += new System.EventHandler(this.salesAndInventoryButton_Click);
            // 
            // billHistoryButton
            // 
            this.billHistoryButton.BackColor = System.Drawing.Color.Indigo;
            this.billHistoryButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billHistoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.billHistoryButton.Location = new System.Drawing.Point(33, 290);
            this.billHistoryButton.Name = "billHistoryButton";
            this.billHistoryButton.Size = new System.Drawing.Size(130, 52);
            this.billHistoryButton.TabIndex = 58;
            this.billHistoryButton.Text = "Bill History";
            this.billHistoryButton.UseVisualStyleBackColor = false;
            this.billHistoryButton.Click += new System.EventHandler(this.billHistoryButton_Click);
            // 
            // adminIssuesButton
            // 
            this.adminIssuesButton.BackColor = System.Drawing.Color.Indigo;
            this.adminIssuesButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminIssuesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminIssuesButton.Location = new System.Drawing.Point(33, 387);
            this.adminIssuesButton.Name = "adminIssuesButton";
            this.adminIssuesButton.Size = new System.Drawing.Size(130, 52);
            this.adminIssuesButton.TabIndex = 59;
            this.adminIssuesButton.Text = "ISSUES";
            this.adminIssuesButton.UseVisualStyleBackColor = false;
            this.adminIssuesButton.Click += new System.EventHandler(this.adminIssuesButton_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1584, 693);
            this.Controls.Add(this.adminIssuesButton);
            this.Controls.Add(this.billHistoryButton);
            this.Controls.Add(this.salesAndInventoryButton);
            this.Controls.Add(this.manageEmployeeButton);
            this.Controls.Add(this.AdminPanelClearButton);
            this.Controls.Add(this.AdminHomePanel);
            this.Controls.Add(this.adminLogOutButton);
            this.Controls.Add(this.workerHomeSideBarLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminHome_FormClosed);
            this.Load += new System.EventHandler(this.AdminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button adminLogOutButton;
        private System.Windows.Forms.Label workerHomeSideBarLabel;
        private System.Windows.Forms.Panel AdminHomePanel;
        private System.Windows.Forms.Button AdminPanelClearButton;
        private System.Windows.Forms.Button manageEmployeeButton;
        private System.Windows.Forms.Button salesAndInventoryButton;
        private System.Windows.Forms.Button billHistoryButton;
        private System.Windows.Forms.Button adminIssuesButton;
    }
}