
namespace PharmacyManagement
{
    partial class MyIssue
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
            this.myIssueDataGridView = new System.Windows.Forms.DataGridView();
            this.CHECK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IssuePanel = new System.Windows.Forms.Panel();
            this.IssueIdLabel = new System.Windows.Forms.Label();
            this.assignByLabel = new System.Windows.Forms.Label();
            this.IssueTextBox = new System.Windows.Forms.RichTextBox();
            this.issueUpdateDoneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myIssueDataGridView)).BeginInit();
            this.IssuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // myIssueDataGridView
            // 
            this.myIssueDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myIssueDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.myIssueDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myIssueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myIssueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHECK});
            this.myIssueDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myIssueDataGridView.Location = new System.Drawing.Point(810, 60);
            this.myIssueDataGridView.Name = "myIssueDataGridView";
            this.myIssueDataGridView.Size = new System.Drawing.Size(780, 539);
            this.myIssueDataGridView.TabIndex = 0;
            this.myIssueDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myIssueDataGridView_CellContentClick);
            this.myIssueDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myIssueDataGridView_CellContentDoubleClick);
            // 
            // CHECK
            // 
            this.CHECK.HeaderText = "CHECK";
            this.CHECK.Name = "CHECK";
            this.CHECK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHECK.Text = "CHECK";
            // 
            // IssuePanel
            // 
            this.IssuePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.IssuePanel.Controls.Add(this.IssueIdLabel);
            this.IssuePanel.Controls.Add(this.assignByLabel);
            this.IssuePanel.Controls.Add(this.IssueTextBox);
            this.IssuePanel.Controls.Add(this.issueUpdateDoneButton);
            this.IssuePanel.Location = new System.Drawing.Point(36, 60);
            this.IssuePanel.Name = "IssuePanel";
            this.IssuePanel.Size = new System.Drawing.Size(721, 539);
            this.IssuePanel.TabIndex = 1;
            // 
            // IssueIdLabel
            // 
            this.IssueIdLabel.AutoSize = true;
            this.IssueIdLabel.Location = new System.Drawing.Point(44, 15);
            this.IssueIdLabel.Name = "IssueIdLabel";
            this.IssueIdLabel.Size = new System.Drawing.Size(41, 13);
            this.IssueIdLabel.TabIndex = 5;
            this.IssueIdLabel.Text = "IssueId";
            // 
            // assignByLabel
            // 
            this.assignByLabel.AutoSize = true;
            this.assignByLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignByLabel.Location = new System.Drawing.Point(44, 59);
            this.assignByLabel.Name = "assignByLabel";
            this.assignByLabel.Size = new System.Drawing.Size(84, 22);
            this.assignByLabel.TabIndex = 4;
            this.assignByLabel.Text = "AssignBy";
            // 
            // IssueTextBox
            // 
            this.IssueTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.IssueTextBox.Enabled = false;
            this.IssueTextBox.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueTextBox.Location = new System.Drawing.Point(47, 90);
            this.IssueTextBox.Name = "IssueTextBox";
            this.IssueTextBox.Size = new System.Drawing.Size(607, 377);
            this.IssueTextBox.TabIndex = 2;
            this.IssueTextBox.Text = "";
            // 
            // issueUpdateDoneButton
            // 
            this.issueUpdateDoneButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueUpdateDoneButton.Location = new System.Drawing.Point(566, 473);
            this.issueUpdateDoneButton.Name = "issueUpdateDoneButton";
            this.issueUpdateDoneButton.Size = new System.Drawing.Size(88, 44);
            this.issueUpdateDoneButton.TabIndex = 1;
            this.issueUpdateDoneButton.Text = "Done";
            this.issueUpdateDoneButton.UseVisualStyleBackColor = true;
            this.issueUpdateDoneButton.Click += new System.EventHandler(this.issueUpdateDoneButton_Click);
            // 
            // MyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.IssuePanel);
            this.Controls.Add(this.myIssueDataGridView);
            this.Name = "MyIssue";
            this.Size = new System.Drawing.Size(1638, 663);
            this.Load += new System.EventHandler(this.MyIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myIssueDataGridView)).EndInit();
            this.IssuePanel.ResumeLayout(false);
            this.IssuePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView myIssueDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn CHECK;
        private System.Windows.Forms.Panel IssuePanel;
        private System.Windows.Forms.Button issueUpdateDoneButton;
        private System.Windows.Forms.RichTextBox IssueTextBox;
        private System.Windows.Forms.Label assignByLabel;
        private System.Windows.Forms.Label IssueIdLabel;
    }
}
