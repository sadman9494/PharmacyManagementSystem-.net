
namespace PharmacyManagement
{
    partial class Login
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
            this.chooseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseTypeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseTypeComboBox
            // 
            this.chooseTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTypeComboBox.FormattingEnabled = true;
            this.chooseTypeComboBox.Items.AddRange(new object[] {
            "Admin",
            "Worker"});
            this.chooseTypeComboBox.Location = new System.Drawing.Point(172, 107);
            this.chooseTypeComboBox.Name = "chooseTypeComboBox";
            this.chooseTypeComboBox.Size = new System.Drawing.Size(145, 28);
            this.chooseTypeComboBox.TabIndex = 0;
            this.chooseTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseTypeComboBox_SelectedIndexChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(152, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // chooseTypeLabel
            // 
            this.chooseTypeLabel.AutoSize = true;
            this.chooseTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTypeLabel.Location = new System.Drawing.Point(12, 107);
            this.chooseTypeLabel.Name = "chooseTypeLabel";
            this.chooseTypeLabel.Size = new System.Drawing.Size(140, 20);
            this.chooseTypeLabel.TabIndex = 3;
            this.chooseTypeLabel.Text = "Choose Your Type";
            this.chooseTypeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(12, 180);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(34, 20);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID :";
            this.idLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(12, 221);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(111, 20);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "PASSWORD :";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(172, 180);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(145, 28);
            this.idTextBox.TabIndex = 6;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(172, 221);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(145, 28);
            this.passwordTextBox.TabIndex = 7;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SpringGreen;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(132, 334);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(99, 46);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Gray;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(291, 449);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(86, 29);
            this.homeButton.TabIndex = 9;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(150, 45);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(71, 31);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Login\r\n";
            this.titleLbl.Click += new System.EventHandler(this.titleLbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pharmacy Management System";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(389, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.chooseTypeLabel);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.chooseTypeComboBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseTypeComboBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chooseTypeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label2;
    }
}

