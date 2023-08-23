
namespace PharmacyManagement
{
    partial class AdminSalesAndInventoryUserControl
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
            this.TotalUnitLabel = new System.Windows.Forms.Label();
            this.totalCompanyLabel = new System.Windows.Forms.Label();
            this.totalNetWorth = new System.Windows.Forms.Label();
            this.totalSellingPriceLabel = new System.Windows.Forms.Label();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.medicineNameTextBox = new System.Windows.Forms.TextBox();
            this.medicineSearchButton = new System.Windows.Forms.Button();
            this.medicineNameLabel = new System.Windows.Forms.Label();
            this.totalUnitsSold = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyProfitLabel = new System.Windows.Forms.Label();
            this.companyNameSearchButton = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.allMedicineDataGridView = new System.Windows.Forms.DataGridView();
            this.medicineProfitLabel = new System.Windows.Forms.Label();
            this.remainingUnitsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allMedicineDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalUnitLabel
            // 
            this.TotalUnitLabel.AutoSize = true;
            this.TotalUnitLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalUnitLabel.Location = new System.Drawing.Point(38, 11);
            this.TotalUnitLabel.Name = "TotalUnitLabel";
            this.TotalUnitLabel.Size = new System.Drawing.Size(77, 20);
            this.TotalUnitLabel.TabIndex = 1;
            this.TotalUnitLabel.Text = "totalUnit";
            this.TotalUnitLabel.Click += new System.EventHandler(this.TotalUnitLabel_Click);
            // 
            // totalCompanyLabel
            // 
            this.totalCompanyLabel.AutoSize = true;
            this.totalCompanyLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCompanyLabel.Location = new System.Drawing.Point(37, 37);
            this.totalCompanyLabel.Name = "totalCompanyLabel";
            this.totalCompanyLabel.Size = new System.Drawing.Size(125, 20);
            this.totalCompanyLabel.TabIndex = 2;
            this.totalCompanyLabel.Text = "totalCompanies";
            // 
            // totalNetWorth
            // 
            this.totalNetWorth.AutoSize = true;
            this.totalNetWorth.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNetWorth.Location = new System.Drawing.Point(37, 74);
            this.totalNetWorth.Name = "totalNetWorth";
            this.totalNetWorth.Size = new System.Drawing.Size(117, 20);
            this.totalNetWorth.TabIndex = 3;
            this.totalNetWorth.Text = "totalNetWorth";
            // 
            // totalSellingPriceLabel
            // 
            this.totalSellingPriceLabel.AutoSize = true;
            this.totalSellingPriceLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSellingPriceLabel.Location = new System.Drawing.Point(38, 106);
            this.totalSellingPriceLabel.Name = "totalSellingPriceLabel";
            this.totalSellingPriceLabel.Size = new System.Drawing.Size(133, 20);
            this.totalSellingPriceLabel.TabIndex = 4;
            this.totalSellingPriceLabel.Text = "totalSellingPrice";
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfitLabel.Location = new System.Drawing.Point(38, 139);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(88, 20);
            this.ProfitLabel.TabIndex = 5;
            this.ProfitLabel.Text = "Profit/Loss";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Medicine Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // medicineNameTextBox
            // 
            this.medicineNameTextBox.Location = new System.Drawing.Point(219, 47);
            this.medicineNameTextBox.Name = "medicineNameTextBox";
            this.medicineNameTextBox.Size = new System.Drawing.Size(149, 22);
            this.medicineNameTextBox.TabIndex = 7;
            this.medicineNameTextBox.TextChanged += new System.EventHandler(this.medicineNameTextBox_TextChanged);
            // 
            // medicineSearchButton
            // 
            this.medicineSearchButton.Location = new System.Drawing.Point(409, 47);
            this.medicineSearchButton.Name = "medicineSearchButton";
            this.medicineSearchButton.Size = new System.Drawing.Size(75, 23);
            this.medicineSearchButton.TabIndex = 8;
            this.medicineSearchButton.Text = "Search";
            this.medicineSearchButton.UseVisualStyleBackColor = true;
            this.medicineSearchButton.Click += new System.EventHandler(this.medicineSearchButton_Click);
            // 
            // medicineNameLabel
            // 
            this.medicineNameLabel.AutoSize = true;
            this.medicineNameLabel.Location = new System.Drawing.Point(32, 95);
            this.medicineNameLabel.Name = "medicineNameLabel";
            this.medicineNameLabel.Size = new System.Drawing.Size(101, 16);
            this.medicineNameLabel.TabIndex = 9;
            this.medicineNameLabel.Text = "MedicineName";
            // 
            // totalUnitsSold
            // 
            this.totalUnitsSold.AutoSize = true;
            this.totalUnitsSold.Location = new System.Drawing.Point(30, 127);
            this.totalUnitsSold.Name = "totalUnitsSold";
            this.totalUnitsSold.Size = new System.Drawing.Size(94, 16);
            this.totalUnitsSold.TabIndex = 11;
            this.totalUnitsSold.Text = "totalUnit Sold";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.remainingUnitsLabel);
            this.groupBox1.Controls.Add(this.medicineProfitLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.totalUnitsSold);
            this.groupBox1.Controls.Add(this.medicineNameTextBox);
            this.groupBox1.Controls.Add(this.medicineSearchButton);
            this.groupBox1.Controls.Add(this.medicineNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 236);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine Finder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Company Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.companyNameTextBox.Location = new System.Drawing.Point(219, 45);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(148, 22);
            this.companyNameTextBox.TabIndex = 7;
            // 
            // companyProfitLabel
            // 
            this.companyProfitLabel.AutoSize = true;
            this.companyProfitLabel.Location = new System.Drawing.Point(32, 136);
            this.companyProfitLabel.Name = "companyProfitLabel";
            this.companyProfitLabel.Size = new System.Drawing.Size(43, 16);
            this.companyProfitLabel.TabIndex = 10;
            this.companyProfitLabel.Text = "profit";
            // 
            // companyNameSearchButton
            // 
            this.companyNameSearchButton.Location = new System.Drawing.Point(411, 45);
            this.companyNameSearchButton.Name = "companyNameSearchButton";
            this.companyNameSearchButton.Size = new System.Drawing.Size(75, 23);
            this.companyNameSearchButton.TabIndex = 8;
            this.companyNameSearchButton.Text = "Search";
            this.companyNameSearchButton.UseVisualStyleBackColor = true;
            this.companyNameSearchButton.Click += new System.EventHandler(this.companyNameSearchButton_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(32, 107);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(103, 16);
            this.companyNameLabel.TabIndex = 9;
            this.companyNameLabel.Text = "CompanyName";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.companyNameLabel);
            this.groupBox2.Controls.Add(this.companyNameTextBox);
            this.groupBox2.Controls.Add(this.companyNameSearchButton);
            this.groupBox2.Controls.Add(this.companyProfitLabel);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(41, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 189);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Finder";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox4.Controls.Add(this.allMedicineDataGridView);
            this.groupBox4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(573, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(962, 465);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "All Medicines";
            // 
            // allMedicineDataGridView
            // 
            this.allMedicineDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.allMedicineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allMedicineDataGridView.Location = new System.Drawing.Point(6, 27);
            this.allMedicineDataGridView.Name = "allMedicineDataGridView";
            this.allMedicineDataGridView.Size = new System.Drawing.Size(950, 426);
            this.allMedicineDataGridView.TabIndex = 0;
            // 
            // medicineProfitLabel
            // 
            this.medicineProfitLabel.AutoSize = true;
            this.medicineProfitLabel.Location = new System.Drawing.Point(29, 182);
            this.medicineProfitLabel.Name = "medicineProfitLabel";
            this.medicineProfitLabel.Size = new System.Drawing.Size(43, 16);
            this.medicineProfitLabel.TabIndex = 12;
            this.medicineProfitLabel.Text = "Profit";
            // 
            // remainingUnitsLabel
            // 
            this.remainingUnitsLabel.AutoSize = true;
            this.remainingUnitsLabel.Location = new System.Drawing.Point(30, 154);
            this.remainingUnitsLabel.Name = "remainingUnitsLabel";
            this.remainingUnitsLabel.Size = new System.Drawing.Size(104, 16);
            this.remainingUnitsLabel.TabIndex = 13;
            this.remainingUnitsLabel.Text = "remainingUnits";
            // 
            // AdminSalesAndInventoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProfitLabel);
            this.Controls.Add(this.totalSellingPriceLabel);
            this.Controls.Add(this.totalNetWorth);
            this.Controls.Add(this.totalCompanyLabel);
            this.Controls.Add(this.TotalUnitLabel);
            this.Name = "AdminSalesAndInventoryUserControl";
            this.Size = new System.Drawing.Size(1538, 641);
            this.Load += new System.EventHandler(this.AdminSalesAndInventoryUserControl_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allMedicineDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalUnitLabel;
        private System.Windows.Forms.Label totalCompanyLabel;
        private System.Windows.Forms.Label totalNetWorth;
        private System.Windows.Forms.Label totalSellingPriceLabel;
        private System.Windows.Forms.Label ProfitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medicineNameTextBox;
        private System.Windows.Forms.Button medicineSearchButton;
        private System.Windows.Forms.Label medicineNameLabel;
        private System.Windows.Forms.Label totalUnitsSold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label companyProfitLabel;
        private System.Windows.Forms.Button companyNameSearchButton;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView allMedicineDataGridView;
        private System.Windows.Forms.Label medicineProfitLabel;
        private System.Windows.Forms.Label remainingUnitsLabel;
    }
}
