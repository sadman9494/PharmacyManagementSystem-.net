
namespace PharmacyManagement
{
    partial class AdminIssueUserControl
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
            this.AdminCreateIssueButton = new System.Windows.Forms.Button();
            this.workerIssueStatusButton = new System.Windows.Forms.Button();
            this.AdminCreateIssuePanel = new System.Windows.Forms.Panel();
            this.adminIssueNamesComboBox = new System.Windows.Forms.ComboBox();
            this.adminIssueAssignByLabel = new System.Windows.Forms.Label();
            this.issueSubmitButton = new System.Windows.Forms.Button();
            this.adminIssueRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.issuedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AdminIssueLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminAllIssuesDataGridView = new System.Windows.Forms.DataGridView();
            this.AdminCheckIssueStatusPanel = new System.Windows.Forms.Panel();
            this.issueFinderTextBox = new System.Windows.Forms.TextBox();
            this.IssueStatusFindButton = new System.Windows.Forms.Button();
            this.IssueCompletedLabel = new System.Windows.Forms.Label();
            this.IssueCreatedLabel = new System.Windows.Forms.Label();
            this.IssueAssignedToLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminCreateIssuePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAllIssuesDataGridView)).BeginInit();
            this.AdminCheckIssueStatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminCreateIssueButton
            // 
            this.AdminCreateIssueButton.BackColor = System.Drawing.Color.Ivory;
            this.AdminCreateIssueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateIssueButton.Location = new System.Drawing.Point(55, 197);
            this.AdminCreateIssueButton.Name = "AdminCreateIssueButton";
            this.AdminCreateIssueButton.Size = new System.Drawing.Size(129, 52);
            this.AdminCreateIssueButton.TabIndex = 0;
            this.AdminCreateIssueButton.Text = "Create Issue";
            this.AdminCreateIssueButton.UseVisualStyleBackColor = false;
            this.AdminCreateIssueButton.Click += new System.EventHandler(this.AdminCreateIssueButton_Click);
            // 
            // workerIssueStatusButton
            // 
            this.workerIssueStatusButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.workerIssueStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerIssueStatusButton.Location = new System.Drawing.Point(55, 324);
            this.workerIssueStatusButton.Name = "workerIssueStatusButton";
            this.workerIssueStatusButton.Size = new System.Drawing.Size(129, 69);
            this.workerIssueStatusButton.TabIndex = 1;
            this.workerIssueStatusButton.Text = "Check Worker Issue Status";
            this.workerIssueStatusButton.UseVisualStyleBackColor = false;
            this.workerIssueStatusButton.Click += new System.EventHandler(this.workerIssueStatusButton_Click);
            // 
            // AdminCreateIssuePanel
            // 
            this.AdminCreateIssuePanel.BackColor = System.Drawing.Color.Ivory;
            this.AdminCreateIssuePanel.Controls.Add(this.adminIssueNamesComboBox);
            this.AdminCreateIssuePanel.Controls.Add(this.adminIssueAssignByLabel);
            this.AdminCreateIssuePanel.Controls.Add(this.issueSubmitButton);
            this.AdminCreateIssuePanel.Controls.Add(this.adminIssueRichTextBox1);
            this.AdminCreateIssuePanel.Controls.Add(this.issuedateTimePicker);
            this.AdminCreateIssuePanel.Controls.Add(this.AdminIssueLabel);
            this.AdminCreateIssuePanel.Location = new System.Drawing.Point(206, 54);
            this.AdminCreateIssuePanel.Name = "AdminCreateIssuePanel";
            this.AdminCreateIssuePanel.Size = new System.Drawing.Size(753, 601);
            this.AdminCreateIssuePanel.TabIndex = 2;
            this.AdminCreateIssuePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminCreateIssuePanel_Paint);
            // 
            // adminIssueNamesComboBox
            // 
            this.adminIssueNamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminIssueNamesComboBox.FormattingEnabled = true;
            this.adminIssueNamesComboBox.Location = new System.Drawing.Point(213, 76);
            this.adminIssueNamesComboBox.Name = "adminIssueNamesComboBox";
            this.adminIssueNamesComboBox.Size = new System.Drawing.Size(121, 28);
            this.adminIssueNamesComboBox.TabIndex = 19;
            this.adminIssueNamesComboBox.Click += new System.EventHandler(this.adminIssueNamesComboBox_Click);
            // 
            // adminIssueAssignByLabel
            // 
            this.adminIssueAssignByLabel.AutoSize = true;
            this.adminIssueAssignByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminIssueAssignByLabel.Location = new System.Drawing.Point(208, 26);
            this.adminIssueAssignByLabel.Name = "adminIssueAssignByLabel";
            this.adminIssueAssignByLabel.Size = new System.Drawing.Size(72, 25);
            this.adminIssueAssignByLabel.TabIndex = 18;
            this.adminIssueAssignByLabel.Text = "Name";
            this.adminIssueAssignByLabel.Click += new System.EventHandler(this.adminIssueAssignByLabel_Click);
            // 
            // issueSubmitButton
            // 
            this.issueSubmitButton.BackColor = System.Drawing.Color.Plum;
            this.issueSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueSubmitButton.Location = new System.Drawing.Point(600, 541);
            this.issueSubmitButton.Name = "issueSubmitButton";
            this.issueSubmitButton.Size = new System.Drawing.Size(101, 36);
            this.issueSubmitButton.TabIndex = 17;
            this.issueSubmitButton.Text = "Submit";
            this.issueSubmitButton.UseVisualStyleBackColor = false;
            this.issueSubmitButton.Click += new System.EventHandler(this.issueSubmitButton_Click);
            // 
            // adminIssueRichTextBox1
            // 
            this.adminIssueRichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminIssueRichTextBox1.Location = new System.Drawing.Point(38, 217);
            this.adminIssueRichTextBox1.Name = "adminIssueRichTextBox1";
            this.adminIssueRichTextBox1.Size = new System.Drawing.Size(663, 318);
            this.adminIssueRichTextBox1.TabIndex = 16;
            this.adminIssueRichTextBox1.Text = "";
            // 
            // issuedateTimePicker
            // 
            this.issuedateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.issuedateTimePicker.Location = new System.Drawing.Point(213, 122);
            this.issuedateTimePicker.Name = "issuedateTimePicker";
            this.issuedateTimePicker.Size = new System.Drawing.Size(98, 26);
            this.issuedateTimePicker.TabIndex = 15;
            // 
            // AdminIssueLabel
            // 
            this.AdminIssueLabel.AutoSize = true;
            this.AdminIssueLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIssueLabel.Location = new System.Drawing.Point(33, 26);
            this.AdminIssueLabel.Name = "AdminIssueLabel";
            this.AdminIssueLabel.Size = new System.Drawing.Size(118, 175);
            this.AdminIssueLabel.TabIndex = 14;
            this.AdminIssueLabel.Text = "Assign By :\r\n\r\nAssign To : \r\n\r\nDate :\r\n\r\nIssue :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.adminAllIssuesDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1005, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 452);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Issues";
            // 
            // adminAllIssuesDataGridView
            // 
            this.adminAllIssuesDataGridView.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.adminAllIssuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminAllIssuesDataGridView.Location = new System.Drawing.Point(5, 26);
            this.adminAllIssuesDataGridView.Name = "adminAllIssuesDataGridView";
            this.adminAllIssuesDataGridView.Size = new System.Drawing.Size(582, 415);
            this.adminAllIssuesDataGridView.TabIndex = 0;
            this.adminAllIssuesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminAllIssuesDataGridView_CellContentClick);
            // 
            // AdminCheckIssueStatusPanel
            // 
            this.AdminCheckIssueStatusPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.AdminCheckIssueStatusPanel.Controls.Add(this.issueFinderTextBox);
            this.AdminCheckIssueStatusPanel.Controls.Add(this.IssueStatusFindButton);
            this.AdminCheckIssueStatusPanel.Controls.Add(this.IssueCompletedLabel);
            this.AdminCheckIssueStatusPanel.Controls.Add(this.IssueCreatedLabel);
            this.AdminCheckIssueStatusPanel.Controls.Add(this.IssueAssignedToLabel);
            this.AdminCheckIssueStatusPanel.Controls.Add(this.label2);
            this.AdminCheckIssueStatusPanel.Location = new System.Drawing.Point(290, 39);
            this.AdminCheckIssueStatusPanel.Name = "AdminCheckIssueStatusPanel";
            this.AdminCheckIssueStatusPanel.Size = new System.Drawing.Size(604, 613);
            this.AdminCheckIssueStatusPanel.TabIndex = 3;
            // 
            // issueFinderTextBox
            // 
            this.issueFinderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueFinderTextBox.Location = new System.Drawing.Point(168, 91);
            this.issueFinderTextBox.Name = "issueFinderTextBox";
            this.issueFinderTextBox.Size = new System.Drawing.Size(160, 29);
            this.issueFinderTextBox.TabIndex = 8;
            // 
            // IssueStatusFindButton
            // 
            this.IssueStatusFindButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IssueStatusFindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueStatusFindButton.Location = new System.Drawing.Point(379, 89);
            this.IssueStatusFindButton.Name = "IssueStatusFindButton";
            this.IssueStatusFindButton.Size = new System.Drawing.Size(82, 36);
            this.IssueStatusFindButton.TabIndex = 7;
            this.IssueStatusFindButton.Text = "Find";
            this.IssueStatusFindButton.UseVisualStyleBackColor = false;
            this.IssueStatusFindButton.Click += new System.EventHandler(this.IssueStatusFindButton_Click);
            // 
            // IssueCompletedLabel
            // 
            this.IssueCompletedLabel.AutoSize = true;
            this.IssueCompletedLabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueCompletedLabel.Location = new System.Drawing.Point(53, 337);
            this.IssueCompletedLabel.Name = "IssueCompletedLabel";
            this.IssueCompletedLabel.Size = new System.Drawing.Size(140, 31);
            this.IssueCompletedLabel.TabIndex = 5;
            this.IssueCompletedLabel.Text = "Completed";
            // 
            // IssueCreatedLabel
            // 
            this.IssueCreatedLabel.AutoSize = true;
            this.IssueCreatedLabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueCreatedLabel.Location = new System.Drawing.Point(53, 226);
            this.IssueCreatedLabel.Name = "IssueCreatedLabel";
            this.IssueCreatedLabel.Size = new System.Drawing.Size(104, 31);
            this.IssueCreatedLabel.TabIndex = 4;
            this.IssueCreatedLabel.Text = "Created";
            // 
            // IssueAssignedToLabel
            // 
            this.IssueAssignedToLabel.AutoSize = true;
            this.IssueAssignedToLabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueAssignedToLabel.Location = new System.Drawing.Point(53, 279);
            this.IssueAssignedToLabel.Name = "IssueAssignedToLabel";
            this.IssueAssignedToLabel.Size = new System.Drawing.Size(154, 31);
            this.IssueAssignedToLabel.TabIndex = 3;
            this.IssueAssignedToLabel.Text = "Assigned To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :\r\n";
            // 
            // AdminIssueUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.AdminCheckIssueStatusPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AdminCreateIssuePanel);
            this.Controls.Add(this.workerIssueStatusButton);
            this.Controls.Add(this.AdminCreateIssueButton);
            this.Name = "AdminIssueUserControl";
            this.Size = new System.Drawing.Size(1601, 691);
            this.Load += new System.EventHandler(this.AdminIssueUserControl_Load);
            this.AdminCreateIssuePanel.ResumeLayout(false);
            this.AdminCreateIssuePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminAllIssuesDataGridView)).EndInit();
            this.AdminCheckIssueStatusPanel.ResumeLayout(false);
            this.AdminCheckIssueStatusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminCreateIssueButton;
        private System.Windows.Forms.Button workerIssueStatusButton;
        private System.Windows.Forms.Panel AdminCreateIssuePanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView adminAllIssuesDataGridView;
        private System.Windows.Forms.Panel AdminCheckIssueStatusPanel;
        private System.Windows.Forms.ComboBox adminIssueNamesComboBox;
        private System.Windows.Forms.Label adminIssueAssignByLabel;
        private System.Windows.Forms.Button issueSubmitButton;
        private System.Windows.Forms.RichTextBox adminIssueRichTextBox1;
        private System.Windows.Forms.DateTimePicker issuedateTimePicker;
        private System.Windows.Forms.Label AdminIssueLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IssueCreatedLabel;
        private System.Windows.Forms.Label IssueAssignedToLabel;
        private System.Windows.Forms.Label IssueCompletedLabel;
        private System.Windows.Forms.Button IssueStatusFindButton;
        private System.Windows.Forms.TextBox issueFinderTextBox;
    }
}
