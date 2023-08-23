
namespace PharmacyManagement
{
    partial class AdminManageEmployees
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
            this.addEmployeesButton = new System.Windows.Forms.Button();
            this.RemoveEmployeesButton = new System.Windows.Forms.Button();
            this.updateSalaryButton = new System.Windows.Forms.Button();
            this.addWorkerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmAddWorkerButton = new System.Windows.Forms.Button();
            this.workerNameTextBox = new System.Windows.Forms.TextBox();
            this.workerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.addWorkerLabels = new System.Windows.Forms.Label();
            this.removeEmployeePanel = new System.Windows.Forms.Panel();
            this.confirmRemoveButton = new System.Windows.Forms.Button();
            this.removeEmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.updateSalaryPanel = new System.Windows.Forms.Panel();
            this.confirmUpdateSalaryButton = new System.Windows.Forms.Button();
            this.salaryUpdateNewSalaryTextBox = new System.Windows.Forms.TextBox();
            this.salaryUpdateIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.allWorkersGroupBox = new System.Windows.Forms.GroupBox();
            this.workerInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.addWorkerPanel.SuspendLayout();
            this.removeEmployeePanel.SuspendLayout();
            this.updateSalaryPanel.SuspendLayout();
            this.allWorkersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addEmployeesButton
            // 
            this.addEmployeesButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addEmployeesButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeesButton.Location = new System.Drawing.Point(21, 59);
            this.addEmployeesButton.Name = "addEmployeesButton";
            this.addEmployeesButton.Size = new System.Drawing.Size(139, 47);
            this.addEmployeesButton.TabIndex = 57;
            this.addEmployeesButton.Text = "Add Employees";
            this.addEmployeesButton.UseVisualStyleBackColor = false;
            this.addEmployeesButton.Click += new System.EventHandler(this.addEmployeesButton_Click);
            // 
            // RemoveEmployeesButton
            // 
            this.RemoveEmployeesButton.BackColor = System.Drawing.Color.MistyRose;
            this.RemoveEmployeesButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmployeesButton.Location = new System.Drawing.Point(171, 59);
            this.RemoveEmployeesButton.Name = "RemoveEmployeesButton";
            this.RemoveEmployeesButton.Size = new System.Drawing.Size(139, 47);
            this.RemoveEmployeesButton.TabIndex = 58;
            this.RemoveEmployeesButton.Text = "Remove Employees";
            this.RemoveEmployeesButton.UseVisualStyleBackColor = false;
            this.RemoveEmployeesButton.Click += new System.EventHandler(this.RemoveEmployeesButton_Click);
            // 
            // updateSalaryButton
            // 
            this.updateSalaryButton.BackColor = System.Drawing.Color.Plum;
            this.updateSalaryButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSalaryButton.Location = new System.Drawing.Point(329, 59);
            this.updateSalaryButton.Name = "updateSalaryButton";
            this.updateSalaryButton.Size = new System.Drawing.Size(139, 47);
            this.updateSalaryButton.TabIndex = 59;
            this.updateSalaryButton.Text = "Update Salary";
            this.updateSalaryButton.UseVisualStyleBackColor = false;
            this.updateSalaryButton.Click += new System.EventHandler(this.updateSalaryButton_Click);
            // 
            // addWorkerPanel
            // 
            this.addWorkerPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addWorkerPanel.Controls.Add(this.label1);
            this.addWorkerPanel.Controls.Add(this.confirmAddWorkerButton);
            this.addWorkerPanel.Controls.Add(this.workerNameTextBox);
            this.addWorkerPanel.Controls.Add(this.workerPasswordTextBox);
            this.addWorkerPanel.Controls.Add(this.addWorkerLabels);
            this.addWorkerPanel.Location = new System.Drawing.Point(21, 112);
            this.addWorkerPanel.Name = "addWorkerPanel";
            this.addWorkerPanel.Size = new System.Drawing.Size(447, 512);
            this.addWorkerPanel.TabIndex = 63;
            this.addWorkerPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 125);
            this.label1.TabIndex = 65;
            this.label1.Text = "Worker Name : \r\n\r\nWorker Password :\r\n\r\n\r\n";
            // 
            // confirmAddWorkerButton
            // 
            this.confirmAddWorkerButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.confirmAddWorkerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.confirmAddWorkerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmAddWorkerButton.Location = new System.Drawing.Point(133, 312);
            this.confirmAddWorkerButton.Name = "confirmAddWorkerButton";
            this.confirmAddWorkerButton.Size = new System.Drawing.Size(168, 56);
            this.confirmAddWorkerButton.TabIndex = 68;
            this.confirmAddWorkerButton.Text = "Confirm";
            this.confirmAddWorkerButton.UseVisualStyleBackColor = false;
            this.confirmAddWorkerButton.Click += new System.EventHandler(this.confirmAddWorkerButton_Click);
            // 
            // workerNameTextBox
            // 
            this.workerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerNameTextBox.Location = new System.Drawing.Point(256, 125);
            this.workerNameTextBox.Name = "workerNameTextBox";
            this.workerNameTextBox.Size = new System.Drawing.Size(144, 29);
            this.workerNameTextBox.TabIndex = 67;
            // 
            // workerPasswordTextBox
            // 
            this.workerPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerPasswordTextBox.Location = new System.Drawing.Point(256, 175);
            this.workerPasswordTextBox.Name = "workerPasswordTextBox";
            this.workerPasswordTextBox.Size = new System.Drawing.Size(144, 29);
            this.workerPasswordTextBox.TabIndex = 66;
            this.workerPasswordTextBox.TextChanged += new System.EventHandler(this.workerPasswordTextBox_TextChanged);
            // 
            // addWorkerLabels
            // 
            this.addWorkerLabels.AutoSize = true;
            this.addWorkerLabels.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkerLabels.Location = new System.Drawing.Point(44, 106);
            this.addWorkerLabels.Name = "addWorkerLabels";
            this.addWorkerLabels.Size = new System.Drawing.Size(0, 21);
            this.addWorkerLabels.TabIndex = 64;
            // 
            // removeEmployeePanel
            // 
            this.removeEmployeePanel.BackColor = System.Drawing.Color.MistyRose;
            this.removeEmployeePanel.Controls.Add(this.label2);
            this.removeEmployeePanel.Controls.Add(this.confirmRemoveButton);
            this.removeEmployeePanel.Controls.Add(this.removeEmployeeIdTextBox);
            this.removeEmployeePanel.Location = new System.Drawing.Point(21, 112);
            this.removeEmployeePanel.Name = "removeEmployeePanel";
            this.removeEmployeePanel.Size = new System.Drawing.Size(447, 512);
            this.removeEmployeePanel.TabIndex = 72;
            this.removeEmployeePanel.Visible = false;
            // 
            // confirmRemoveButton
            // 
            this.confirmRemoveButton.BackColor = System.Drawing.Color.Maroon;
            this.confirmRemoveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmRemoveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmRemoveButton.Location = new System.Drawing.Point(133, 286);
            this.confirmRemoveButton.Name = "confirmRemoveButton";
            this.confirmRemoveButton.Size = new System.Drawing.Size(156, 63);
            this.confirmRemoveButton.TabIndex = 3;
            this.confirmRemoveButton.Text = "Remove";
            this.confirmRemoveButton.UseVisualStyleBackColor = false;
            this.confirmRemoveButton.Click += new System.EventHandler(this.confirmRemoveButton_Click);
            // 
            // removeEmployeeIdTextBox
            // 
            this.removeEmployeeIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmployeeIdTextBox.Location = new System.Drawing.Point(197, 90);
            this.removeEmployeeIdTextBox.Name = "removeEmployeeIdTextBox";
            this.removeEmployeeIdTextBox.Size = new System.Drawing.Size(158, 29);
            this.removeEmployeeIdTextBox.TabIndex = 2;
            // 
            // updateSalaryPanel
            // 
            this.updateSalaryPanel.BackColor = System.Drawing.Color.Plum;
            this.updateSalaryPanel.Controls.Add(this.confirmUpdateSalaryButton);
            this.updateSalaryPanel.Controls.Add(this.salaryUpdateNewSalaryTextBox);
            this.updateSalaryPanel.Controls.Add(this.salaryUpdateIdTextBox);
            this.updateSalaryPanel.Controls.Add(this.label4);
            this.updateSalaryPanel.Location = new System.Drawing.Point(21, 112);
            this.updateSalaryPanel.Name = "updateSalaryPanel";
            this.updateSalaryPanel.Size = new System.Drawing.Size(447, 512);
            this.updateSalaryPanel.TabIndex = 4;
            this.updateSalaryPanel.Visible = false;
            this.updateSalaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.updateSalaryPanel_Paint);
            // 
            // confirmUpdateSalaryButton
            // 
            this.confirmUpdateSalaryButton.BackColor = System.Drawing.Color.DarkViolet;
            this.confirmUpdateSalaryButton.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmUpdateSalaryButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.confirmUpdateSalaryButton.Location = new System.Drawing.Point(145, 305);
            this.confirmUpdateSalaryButton.Name = "confirmUpdateSalaryButton";
            this.confirmUpdateSalaryButton.Size = new System.Drawing.Size(156, 63);
            this.confirmUpdateSalaryButton.TabIndex = 3;
            this.confirmUpdateSalaryButton.Text = "Confirm";
            this.confirmUpdateSalaryButton.UseVisualStyleBackColor = false;
            this.confirmUpdateSalaryButton.Click += new System.EventHandler(this.confirmUpdateSalaryButton_Click);
            // 
            // salaryUpdateNewSalaryTextBox
            // 
            this.salaryUpdateNewSalaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryUpdateNewSalaryTextBox.Location = new System.Drawing.Point(230, 177);
            this.salaryUpdateNewSalaryTextBox.Name = "salaryUpdateNewSalaryTextBox";
            this.salaryUpdateNewSalaryTextBox.Size = new System.Drawing.Size(134, 29);
            this.salaryUpdateNewSalaryTextBox.TabIndex = 2;
            // 
            // salaryUpdateIdTextBox
            // 
            this.salaryUpdateIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryUpdateIdTextBox.Location = new System.Drawing.Point(230, 103);
            this.salaryUpdateIdTextBox.Name = "salaryUpdateIdTextBox";
            this.salaryUpdateIdTextBox.Size = new System.Drawing.Size(134, 29);
            this.salaryUpdateIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 125);
            this.label4.TabIndex = 0;
            this.label4.Text = "Worker ID :\r\n\r\n\r\nNew Salary : \r\n\r\n";
            // 
            // allWorkersGroupBox
            // 
            this.allWorkersGroupBox.Controls.Add(this.workerInfoDataGridView);
            this.allWorkersGroupBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allWorkersGroupBox.Location = new System.Drawing.Point(514, 59);
            this.allWorkersGroupBox.Name = "allWorkersGroupBox";
            this.allWorkersGroupBox.Size = new System.Drawing.Size(1121, 565);
            this.allWorkersGroupBox.TabIndex = 70;
            this.allWorkersGroupBox.TabStop = false;
            this.allWorkersGroupBox.Text = "All Workers";
            // 
            // workerInfoDataGridView
            // 
            this.workerInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workerInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.workerInfoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerInfoDataGridView.Location = new System.Drawing.Point(6, 28);
            this.workerInfoDataGridView.Name = "workerInfoDataGridView";
            this.workerInfoDataGridView.Size = new System.Drawing.Size(1104, 531);
            this.workerInfoDataGridView.TabIndex = 0;
            this.workerInfoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workerInfoDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Worker ID :";
            // 
            // AdminManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.allWorkersGroupBox);
            this.Controls.Add(this.updateSalaryButton);
            this.Controls.Add(this.RemoveEmployeesButton);
            this.Controls.Add(this.addEmployeesButton);
            this.Controls.Add(this.updateSalaryPanel);
            this.Controls.Add(this.addWorkerPanel);
            this.Controls.Add(this.removeEmployeePanel);
            this.Name = "AdminManageEmployees";
            this.Size = new System.Drawing.Size(1638, 641);
            this.Load += new System.EventHandler(this.AdminManageEmployees_Load);
            this.addWorkerPanel.ResumeLayout(false);
            this.addWorkerPanel.PerformLayout();
            this.removeEmployeePanel.ResumeLayout(false);
            this.removeEmployeePanel.PerformLayout();
            this.updateSalaryPanel.ResumeLayout(false);
            this.updateSalaryPanel.PerformLayout();
            this.allWorkersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workerInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmployeesButton;
        private System.Windows.Forms.Button RemoveEmployeesButton;
        private System.Windows.Forms.Button updateSalaryButton;
        private System.Windows.Forms.Panel addWorkerPanel;
        private System.Windows.Forms.Label addWorkerLabels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox workerPasswordTextBox;
        private System.Windows.Forms.TextBox workerNameTextBox;
        private System.Windows.Forms.Button confirmAddWorkerButton;
        private System.Windows.Forms.GroupBox allWorkersGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView workerInfoDataGridView;
        private System.Windows.Forms.Panel removeEmployeePanel;
        private System.Windows.Forms.TextBox removeEmployeeIdTextBox;
        private System.Windows.Forms.Button confirmRemoveButton;
        private System.Windows.Forms.Panel updateSalaryPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salaryUpdateNewSalaryTextBox;
        private System.Windows.Forms.TextBox salaryUpdateIdTextBox;
        private System.Windows.Forms.Button confirmUpdateSalaryButton;
        private System.Windows.Forms.Label label2;
    }
}
