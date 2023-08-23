
namespace PharmacyManagement
{
    partial class WorkerIssue
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
            this.issueGroupBox = new System.Windows.Forms.GroupBox();
            this.workerIssueComboBox = new System.Windows.Forms.ComboBox();
            this.workerIssueAssignByLabel = new System.Windows.Forms.Label();
            this.issueSubmitButton = new System.Windows.Forms.Button();
            this.workerIssueRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.issuedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WorkerIssueLabel = new System.Windows.Forms.Label();
            this.issueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // issueGroupBox
            // 
            this.issueGroupBox.BackColor = System.Drawing.Color.PowderBlue;
            this.issueGroupBox.Controls.Add(this.workerIssueComboBox);
            this.issueGroupBox.Controls.Add(this.workerIssueAssignByLabel);
            this.issueGroupBox.Controls.Add(this.issueSubmitButton);
            this.issueGroupBox.Controls.Add(this.workerIssueRichTextBox1);
            this.issueGroupBox.Controls.Add(this.issuedateTimePicker);
            this.issueGroupBox.Controls.Add(this.WorkerIssueLabel);
            this.issueGroupBox.Location = new System.Drawing.Point(259, 21);
            this.issueGroupBox.Name = "issueGroupBox";
            this.issueGroupBox.Size = new System.Drawing.Size(995, 625);
            this.issueGroupBox.TabIndex = 0;
            this.issueGroupBox.TabStop = false;
            this.issueGroupBox.Enter += new System.EventHandler(this.issueGroupBox_Enter);
            // 
            // workerIssueComboBox
            // 
            this.workerIssueComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerIssueComboBox.FormattingEnabled = true;
            this.workerIssueComboBox.Location = new System.Drawing.Point(325, 120);
            this.workerIssueComboBox.Name = "workerIssueComboBox";
            this.workerIssueComboBox.Size = new System.Drawing.Size(121, 28);
            this.workerIssueComboBox.TabIndex = 13;
            this.workerIssueComboBox.Click += new System.EventHandler(this.workerIssueComboBox_Click);
            // 
            // workerIssueAssignByLabel
            // 
            this.workerIssueAssignByLabel.AutoSize = true;
            this.workerIssueAssignByLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerIssueAssignByLabel.Location = new System.Drawing.Point(320, 62);
            this.workerIssueAssignByLabel.Name = "workerIssueAssignByLabel";
            this.workerIssueAssignByLabel.Size = new System.Drawing.Size(73, 28);
            this.workerIssueAssignByLabel.TabIndex = 12;
            this.workerIssueAssignByLabel.Text = "Name";
            // 
            // issueSubmitButton
            // 
            this.issueSubmitButton.BackColor = System.Drawing.Color.Plum;
            this.issueSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueSubmitButton.Location = new System.Drawing.Point(808, 566);
            this.issueSubmitButton.Name = "issueSubmitButton";
            this.issueSubmitButton.Size = new System.Drawing.Size(101, 36);
            this.issueSubmitButton.TabIndex = 11;
            this.issueSubmitButton.Text = "Submit";
            this.issueSubmitButton.UseVisualStyleBackColor = false;
            this.issueSubmitButton.Click += new System.EventHandler(this.issueSubmitButton_Click);
            // 
            // workerIssueRichTextBox1
            // 
            this.workerIssueRichTextBox1.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerIssueRichTextBox1.Location = new System.Drawing.Point(150, 280);
            this.workerIssueRichTextBox1.Name = "workerIssueRichTextBox1";
            this.workerIssueRichTextBox1.Size = new System.Drawing.Size(759, 264);
            this.workerIssueRichTextBox1.TabIndex = 10;
            this.workerIssueRichTextBox1.Text = "";
            this.workerIssueRichTextBox1.TextChanged += new System.EventHandler(this.workerIssueRichTextBox1_TextChanged);
            // 
            // issuedateTimePicker
            // 
            this.issuedateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.issuedateTimePicker.Location = new System.Drawing.Point(325, 174);
            this.issuedateTimePicker.Name = "issuedateTimePicker";
            this.issuedateTimePicker.Size = new System.Drawing.Size(98, 26);
            this.issuedateTimePicker.TabIndex = 9;
            // 
            // WorkerIssueLabel
            // 
            this.WorkerIssueLabel.AutoSize = true;
            this.WorkerIssueLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerIssueLabel.Location = new System.Drawing.Point(145, 62);
            this.WorkerIssueLabel.Name = "WorkerIssueLabel";
            this.WorkerIssueLabel.Size = new System.Drawing.Size(127, 196);
            this.WorkerIssueLabel.TabIndex = 6;
            this.WorkerIssueLabel.Text = "Assign By :\r\n\r\nAssign To : \r\n\r\nDate :\r\n\r\nIssue :";
            // 
            // WorkerIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.issueGroupBox);
            this.Name = "WorkerIssue";
            this.Size = new System.Drawing.Size(1638, 663);
            this.Load += new System.EventHandler(this.WorkerIssue_Load);
            this.issueGroupBox.ResumeLayout(false);
            this.issueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox issueGroupBox;
        private System.Windows.Forms.Button issueSubmitButton;
        private System.Windows.Forms.RichTextBox workerIssueRichTextBox1;
        private System.Windows.Forms.DateTimePicker issuedateTimePicker;
        private System.Windows.Forms.Label WorkerIssueLabel;
        private System.Windows.Forms.Label workerIssueAssignByLabel;
        private System.Windows.Forms.ComboBox workerIssueComboBox;
    }
}
