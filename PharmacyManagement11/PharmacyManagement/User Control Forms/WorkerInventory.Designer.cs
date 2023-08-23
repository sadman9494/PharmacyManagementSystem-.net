
namespace PharmacyManagement
{
    partial class WorkerInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.wInLabel = new System.Windows.Forms.Label();
            this.searchMedicineButton = new System.Windows.Forms.Button();
            this.removeMedicineButton = new System.Windows.Forms.Button();
            this.addMedicineButton = new System.Windows.Forms.Button();
            this.InventoryTitleLabel = new System.Windows.Forms.Label();
            this.addMedicinePanel = new System.Windows.Forms.Panel();
            this.addMedicineConfirmButton = new System.Windows.Forms.Button();
            this.addMedicineDiscountTextBox = new System.Windows.Forms.TextBox();
            this.addMedicineQuantityTextBox = new System.Windows.Forms.TextBox();
            this.addMedicineSellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.addMedicineBuyingPriceTextBox = new System.Windows.Forms.TextBox();
            this.addMedicineCompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.addMedicineNameTextBox = new System.Windows.Forms.TextBox();
            this.addExpiringDate = new System.Windows.Forms.DateTimePicker();
            this.addCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.addMedicineLabel = new System.Windows.Forms.Label();
            this.removeMedicinePanel = new System.Windows.Forms.Panel();
            this.confirmDeleteMedicineButton = new System.Windows.Forms.Button();
            this.removeMedicineMedicineNamesComboBox = new System.Windows.Forms.ComboBox();
            this.removeMedicineCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.InventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.searchMedicinePanel = new System.Windows.Forms.Panel();
            this.totalMedicineProfit = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.remainingUnitsLabel = new System.Windows.Forms.Label();
            this.ExpiringDateLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.medicineNameLabel = new System.Windows.Forms.Label();
            this.searchMedicineTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medicineSearchButton = new System.Windows.Forms.Button();
            this.medicineInfoUpdateButton = new System.Windows.Forms.Button();
            this.UpdateMedicineInfoPanel = new System.Windows.Forms.Panel();
            this.updateMedicineExpDateTextBox = new System.Windows.Forms.DateTimePicker();
            this.confirmUpdateMedInfoButton = new System.Windows.Forms.Button();
            this.updateMedicineDiscountTextBox = new System.Windows.Forms.TextBox();
            this.updateMedicineSellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.updateMedicineQuantityTextBox = new System.Windows.Forms.TextBox();
            this.updateMedicineIdTextBox = new System.Windows.Forms.TextBox();
            this.updateMedicineInfoLabel = new System.Windows.Forms.Label();
            this.addMedicinePanel.SuspendLayout();
            this.removeMedicinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.InventoryGroupBox.SuspendLayout();
            this.searchMedicinePanel.SuspendLayout();
            this.UpdateMedicineInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wInLabel
            // 
            this.wInLabel.AutoSize = true;
            this.wInLabel.Location = new System.Drawing.Point(35, 14);
            this.wInLabel.Name = "wInLabel";
            this.wInLabel.Size = new System.Drawing.Size(17, 13);
            this.wInLabel.TabIndex = 59;
            this.wInLabel.Text = "\"\"";
            // 
            // searchMedicineButton
            // 
            this.searchMedicineButton.BackColor = System.Drawing.Color.Plum;
            this.searchMedicineButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMedicineButton.Location = new System.Drawing.Point(224, 36);
            this.searchMedicineButton.Name = "searchMedicineButton";
            this.searchMedicineButton.Size = new System.Drawing.Size(93, 47);
            this.searchMedicineButton.TabIndex = 58;
            this.searchMedicineButton.Text = "Search Medicine";
            this.searchMedicineButton.UseVisualStyleBackColor = false;
            this.searchMedicineButton.Click += new System.EventHandler(this.searchMedicineButton_Click);
            // 
            // removeMedicineButton
            // 
            this.removeMedicineButton.BackColor = System.Drawing.Color.LightSalmon;
            this.removeMedicineButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMedicineButton.Location = new System.Drawing.Point(123, 36);
            this.removeMedicineButton.Name = "removeMedicineButton";
            this.removeMedicineButton.Size = new System.Drawing.Size(93, 47);
            this.removeMedicineButton.TabIndex = 57;
            this.removeMedicineButton.Text = "Remove Medicine";
            this.removeMedicineButton.UseVisualStyleBackColor = false;
            this.removeMedicineButton.Click += new System.EventHandler(this.removeMedicineButton_Click);
            // 
            // addMedicineButton
            // 
            this.addMedicineButton.BackColor = System.Drawing.Color.PowderBlue;
            this.addMedicineButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedicineButton.Location = new System.Drawing.Point(14, 36);
            this.addMedicineButton.Name = "addMedicineButton";
            this.addMedicineButton.Size = new System.Drawing.Size(93, 47);
            this.addMedicineButton.TabIndex = 56;
            this.addMedicineButton.Text = "Add Medicine";
            this.addMedicineButton.UseVisualStyleBackColor = false;
            this.addMedicineButton.Click += new System.EventHandler(this.addMedicineButton_Click);
            // 
            // InventoryTitleLabel
            // 
            this.InventoryTitleLabel.AutoSize = true;
            this.InventoryTitleLabel.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryTitleLabel.Location = new System.Drawing.Point(788, 11);
            this.InventoryTitleLabel.Name = "InventoryTitleLabel";
            this.InventoryTitleLabel.Size = new System.Drawing.Size(80, 16);
            this.InventoryTitleLabel.TabIndex = 55;
            this.InventoryTitleLabel.Text = "Inventory";
            // 
            // addMedicinePanel
            // 
            this.addMedicinePanel.BackColor = System.Drawing.Color.PowderBlue;
            this.addMedicinePanel.Controls.Add(this.addMedicineConfirmButton);
            this.addMedicinePanel.Controls.Add(this.addMedicineDiscountTextBox);
            this.addMedicinePanel.Controls.Add(this.addMedicineQuantityTextBox);
            this.addMedicinePanel.Controls.Add(this.addMedicineSellingPriceTextBox);
            this.addMedicinePanel.Controls.Add(this.addMedicineBuyingPriceTextBox);
            this.addMedicinePanel.Controls.Add(this.addMedicineCompanyNameTextBox);
            this.addMedicinePanel.Controls.Add(this.addMedicineNameTextBox);
            this.addMedicinePanel.Controls.Add(this.addExpiringDate);
            this.addMedicinePanel.Controls.Add(this.addCategoryComboBox);
            this.addMedicinePanel.Controls.Add(this.addMedicineLabel);
            this.addMedicinePanel.Location = new System.Drawing.Point(14, 92);
            this.addMedicinePanel.Name = "addMedicinePanel";
            this.addMedicinePanel.Size = new System.Drawing.Size(440, 504);
            this.addMedicinePanel.TabIndex = 60;
            this.addMedicinePanel.Visible = false;
            // 
            // addMedicineConfirmButton
            // 
            this.addMedicineConfirmButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addMedicineConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedicineConfirmButton.Location = new System.Drawing.Point(137, 390);
            this.addMedicineConfirmButton.Name = "addMedicineConfirmButton";
            this.addMedicineConfirmButton.Size = new System.Drawing.Size(156, 41);
            this.addMedicineConfirmButton.TabIndex = 16;
            this.addMedicineConfirmButton.Text = "Confirm";
            this.addMedicineConfirmButton.UseVisualStyleBackColor = false;
            this.addMedicineConfirmButton.Click += new System.EventHandler(this.addMedicineConfirmButton_Click);
            // 
            // addMedicineDiscountTextBox
            // 
            this.addMedicineDiscountTextBox.Font = new System.Drawing.Font("Georgia", 12F);
            this.addMedicineDiscountTextBox.Location = new System.Drawing.Point(197, 328);
            this.addMedicineDiscountTextBox.Name = "addMedicineDiscountTextBox";
            this.addMedicineDiscountTextBox.Size = new System.Drawing.Size(195, 26);
            this.addMedicineDiscountTextBox.TabIndex = 15;
            this.addMedicineDiscountTextBox.TextChanged += new System.EventHandler(this.addMedicineDiscountTextBox_TextChanged);
            // 
            // addMedicineQuantityTextBox
            // 
            this.addMedicineQuantityTextBox.Font = new System.Drawing.Font("Georgia", 12F);
            this.addMedicineQuantityTextBox.Location = new System.Drawing.Point(197, 238);
            this.addMedicineQuantityTextBox.Name = "addMedicineQuantityTextBox";
            this.addMedicineQuantityTextBox.Size = new System.Drawing.Size(195, 26);
            this.addMedicineQuantityTextBox.TabIndex = 14;
            // 
            // addMedicineSellingPriceTextBox
            // 
            this.addMedicineSellingPriceTextBox.Font = new System.Drawing.Font("Georgia", 12F);
            this.addMedicineSellingPriceTextBox.Location = new System.Drawing.Point(197, 200);
            this.addMedicineSellingPriceTextBox.Name = "addMedicineSellingPriceTextBox";
            this.addMedicineSellingPriceTextBox.Size = new System.Drawing.Size(195, 26);
            this.addMedicineSellingPriceTextBox.TabIndex = 13;
            // 
            // addMedicineBuyingPriceTextBox
            // 
            this.addMedicineBuyingPriceTextBox.Font = new System.Drawing.Font("Georgia", 12F);
            this.addMedicineBuyingPriceTextBox.Location = new System.Drawing.Point(197, 161);
            this.addMedicineBuyingPriceTextBox.Name = "addMedicineBuyingPriceTextBox";
            this.addMedicineBuyingPriceTextBox.Size = new System.Drawing.Size(195, 26);
            this.addMedicineBuyingPriceTextBox.TabIndex = 12;
            // 
            // addMedicineCompanyNameTextBox
            // 
            this.addMedicineCompanyNameTextBox.Font = new System.Drawing.Font("Georgia", 12F);
            this.addMedicineCompanyNameTextBox.Location = new System.Drawing.Point(197, 118);
            this.addMedicineCompanyNameTextBox.Name = "addMedicineCompanyNameTextBox";
            this.addMedicineCompanyNameTextBox.Size = new System.Drawing.Size(195, 26);
            this.addMedicineCompanyNameTextBox.TabIndex = 11;
            // 
            // addMedicineNameTextBox
            // 
            this.addMedicineNameTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedicineNameTextBox.Location = new System.Drawing.Point(197, 31);
            this.addMedicineNameTextBox.Name = "addMedicineNameTextBox";
            this.addMedicineNameTextBox.Size = new System.Drawing.Size(195, 26);
            this.addMedicineNameTextBox.TabIndex = 10;
            this.addMedicineNameTextBox.TextChanged += new System.EventHandler(this.addMedicineNameTextBox_TextChanged);
            // 
            // addExpiringDate
            // 
            this.addExpiringDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpiringDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addExpiringDate.Location = new System.Drawing.Point(197, 282);
            this.addExpiringDate.Name = "addExpiringDate";
            this.addExpiringDate.Size = new System.Drawing.Size(119, 26);
            this.addExpiringDate.TabIndex = 9;
            this.addExpiringDate.ValueChanged += new System.EventHandler(this.addExpiringDate_ValueChanged);
            // 
            // addCategoryComboBox
            // 
            this.addCategoryComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.addCategoryComboBox.DropDownHeight = 110;
            this.addCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCategoryComboBox.Font = new System.Drawing.Font("Georgia", 12F);
            this.addCategoryComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addCategoryComboBox.FormattingEnabled = true;
            this.addCategoryComboBox.IntegralHeight = false;
            this.addCategoryComboBox.Items.AddRange(new object[] {
            "Tablet",
            "Syrup",
            "Powder",
            "Solution",
            "IV"});
            this.addCategoryComboBox.Location = new System.Drawing.Point(197, 75);
            this.addCategoryComboBox.Name = "addCategoryComboBox";
            this.addCategoryComboBox.Size = new System.Drawing.Size(195, 26);
            this.addCategoryComboBox.TabIndex = 8;
            // 
            // addMedicineLabel
            // 
            this.addMedicineLabel.AutoSize = true;
            this.addMedicineLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedicineLabel.Location = new System.Drawing.Point(17, 35);
            this.addMedicineLabel.Name = "addMedicineLabel";
            this.addMedicineLabel.Size = new System.Drawing.Size(149, 315);
            this.addMedicineLabel.TabIndex = 0;
            this.addMedicineLabel.Text = "Name :\r\n\r\nCategory :\r\n\r\nCompany Name :\r\n\r\nBuying Price :\r\n\r\nSelling Price :\r\n\r\nQu" +
    "antity:\r\n\r\nExpiring Date :\r\n\r\nDiscount (optional) :";
            // 
            // removeMedicinePanel
            // 
            this.removeMedicinePanel.BackColor = System.Drawing.Color.MistyRose;
            this.removeMedicinePanel.Controls.Add(this.confirmDeleteMedicineButton);
            this.removeMedicinePanel.Controls.Add(this.removeMedicineMedicineNamesComboBox);
            this.removeMedicinePanel.Controls.Add(this.removeMedicineCategoryComboBox);
            this.removeMedicinePanel.Controls.Add(this.label2);
            this.removeMedicinePanel.Location = new System.Drawing.Point(14, 92);
            this.removeMedicinePanel.Name = "removeMedicinePanel";
            this.removeMedicinePanel.Size = new System.Drawing.Size(440, 504);
            this.removeMedicinePanel.TabIndex = 61;
            this.removeMedicinePanel.Visible = false;
            this.removeMedicinePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.removeMedicinePanel_Paint);
            // 
            // confirmDeleteMedicineButton
            // 
            this.confirmDeleteMedicineButton.BackColor = System.Drawing.Color.Maroon;
            this.confirmDeleteMedicineButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmDeleteMedicineButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmDeleteMedicineButton.Location = new System.Drawing.Point(137, 295);
            this.confirmDeleteMedicineButton.Name = "confirmDeleteMedicineButton";
            this.confirmDeleteMedicineButton.Size = new System.Drawing.Size(135, 59);
            this.confirmDeleteMedicineButton.TabIndex = 4;
            this.confirmDeleteMedicineButton.Text = "Confirm";
            this.confirmDeleteMedicineButton.UseVisualStyleBackColor = false;
            this.confirmDeleteMedicineButton.Click += new System.EventHandler(this.confirmDeleteMedicineButton_Click);
            // 
            // removeMedicineMedicineNamesComboBox
            // 
            this.removeMedicineMedicineNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.removeMedicineMedicineNamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMedicineMedicineNamesComboBox.FormattingEnabled = true;
            this.removeMedicineMedicineNamesComboBox.Location = new System.Drawing.Point(197, 200);
            this.removeMedicineMedicineNamesComboBox.Name = "removeMedicineMedicineNamesComboBox";
            this.removeMedicineMedicineNamesComboBox.Size = new System.Drawing.Size(172, 32);
            this.removeMedicineMedicineNamesComboBox.TabIndex = 3;
            this.removeMedicineMedicineNamesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // removeMedicineCategoryComboBox
            // 
            this.removeMedicineCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMedicineCategoryComboBox.FormattingEnabled = true;
            this.removeMedicineCategoryComboBox.Items.AddRange(new object[] {
            "Tablet",
            "Syrup",
            "Powder",
            "Solution",
            "IV"});
            this.removeMedicineCategoryComboBox.Location = new System.Drawing.Point(197, 108);
            this.removeMedicineCategoryComboBox.Name = "removeMedicineCategoryComboBox";
            this.removeMedicineCategoryComboBox.Size = new System.Drawing.Size(172, 32);
            this.removeMedicineCategoryComboBox.TabIndex = 2;
            this.removeMedicineCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.removeMedicineCategoryComboBox.SelectedValueChanged += new System.EventHandler(this.removeMedicineCategoryComboBox_SelectedValueChanged);
            this.removeMedicineCategoryComboBox.TextChanged += new System.EventHandler(this.removeMedicineCategoryComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 125);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Categroy :\r\n\r\n\r\n\r\nSelect Medicine   :\r\n";
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.inventoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inventoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.inventoryDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryDataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.inventoryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.inventoryDataGridView.GridColor = System.Drawing.Color.PaleTurquoise;
            this.inventoryDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inventoryDataGridView.Location = new System.Drawing.Point(7, 36);
            this.inventoryDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.inventoryDataGridView.RowHeadersWidth = 35;
            this.inventoryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.inventoryDataGridView.RowTemplate.Height = 26;
            this.inventoryDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryDataGridView.Size = new System.Drawing.Size(1155, 532);
            this.inventoryDataGridView.TabIndex = 63;
            this.inventoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // InventoryGroupBox
            // 
            this.InventoryGroupBox.Controls.Add(this.inventoryDataGridView);
            this.InventoryGroupBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryGroupBox.Location = new System.Drawing.Point(466, 52);
            this.InventoryGroupBox.Name = "InventoryGroupBox";
            this.InventoryGroupBox.Size = new System.Drawing.Size(1169, 575);
            this.InventoryGroupBox.TabIndex = 64;
            this.InventoryGroupBox.TabStop = false;
            this.InventoryGroupBox.Text = "MEDICINE INVENTORY";
            // 
            // searchMedicinePanel
            // 
            this.searchMedicinePanel.BackColor = System.Drawing.Color.Plum;
            this.searchMedicinePanel.Controls.Add(this.totalMedicineProfit);
            this.searchMedicinePanel.Controls.Add(this.categoryLabel);
            this.searchMedicinePanel.Controls.Add(this.priceLabel);
            this.searchMedicinePanel.Controls.Add(this.remainingUnitsLabel);
            this.searchMedicinePanel.Controls.Add(this.ExpiringDateLabel);
            this.searchMedicinePanel.Controls.Add(this.companyNameLabel);
            this.searchMedicinePanel.Controls.Add(this.medicineNameLabel);
            this.searchMedicinePanel.Controls.Add(this.searchMedicineTextBox);
            this.searchMedicinePanel.Controls.Add(this.label1);
            this.searchMedicinePanel.Controls.Add(this.medicineSearchButton);
            this.searchMedicinePanel.Location = new System.Drawing.Point(14, 92);
            this.searchMedicinePanel.Name = "searchMedicinePanel";
            this.searchMedicinePanel.Size = new System.Drawing.Size(440, 504);
            this.searchMedicinePanel.TabIndex = 61;
            this.searchMedicinePanel.Visible = false;
            this.searchMedicinePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchMedicinePanel_Paint);
            // 
            // totalMedicineProfit
            // 
            this.totalMedicineProfit.AutoSize = true;
            this.totalMedicineProfit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMedicineProfit.Location = new System.Drawing.Point(44, 397);
            this.totalMedicineProfit.Name = "totalMedicineProfit";
            this.totalMedicineProfit.Size = new System.Drawing.Size(104, 25);
            this.totalMedicineProfit.TabIndex = 25;
            this.totalMedicineProfit.Text = "totalProfit";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(44, 272);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(92, 25);
            this.categoryLabel.TabIndex = 24;
            this.categoryLabel.Text = "category";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(44, 232);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(57, 25);
            this.priceLabel.TabIndex = 23;
            this.priceLabel.Text = "Price";
            // 
            // remainingUnitsLabel
            // 
            this.remainingUnitsLabel.AutoSize = true;
            this.remainingUnitsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingUnitsLabel.Location = new System.Drawing.Point(44, 357);
            this.remainingUnitsLabel.Name = "remainingUnitsLabel";
            this.remainingUnitsLabel.Size = new System.Drawing.Size(158, 25);
            this.remainingUnitsLabel.TabIndex = 22;
            this.remainingUnitsLabel.Text = "remaining Units";
            // 
            // ExpiringDateLabel
            // 
            this.ExpiringDateLabel.AutoSize = true;
            this.ExpiringDateLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiringDateLabel.Location = new System.Drawing.Point(44, 310);
            this.ExpiringDateLabel.Name = "ExpiringDateLabel";
            this.ExpiringDateLabel.Size = new System.Drawing.Size(87, 25);
            this.ExpiringDateLabel.TabIndex = 21;
            this.ExpiringDateLabel.Text = "ExpDate";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(44, 187);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(152, 25);
            this.companyNameLabel.TabIndex = 20;
            this.companyNameLabel.Text = "companyName";
            // 
            // medicineNameLabel
            // 
            this.medicineNameLabel.AutoSize = true;
            this.medicineNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineNameLabel.Location = new System.Drawing.Point(44, 148);
            this.medicineNameLabel.Name = "medicineNameLabel";
            this.medicineNameLabel.Size = new System.Drawing.Size(64, 25);
            this.medicineNameLabel.TabIndex = 19;
            this.medicineNameLabel.Text = "name";
            // 
            // searchMedicineTextBox
            // 
            this.searchMedicineTextBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMedicineTextBox.Location = new System.Drawing.Point(160, 23);
            this.searchMedicineTextBox.Name = "searchMedicineTextBox";
            this.searchMedicineTextBox.Size = new System.Drawing.Size(133, 31);
            this.searchMedicineTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Medicine Name : \r\n";
            // 
            // medicineSearchButton
            // 
            this.medicineSearchButton.BackColor = System.Drawing.Color.LightPink;
            this.medicineSearchButton.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineSearchButton.Location = new System.Drawing.Point(324, 21);
            this.medicineSearchButton.Name = "medicineSearchButton";
            this.medicineSearchButton.Size = new System.Drawing.Size(85, 33);
            this.medicineSearchButton.TabIndex = 0;
            this.medicineSearchButton.Text = "Search";
            this.medicineSearchButton.UseVisualStyleBackColor = false;
            this.medicineSearchButton.Click += new System.EventHandler(this.medicineSearchButton_Click);
            // 
            // medicineInfoUpdateButton
            // 
            this.medicineInfoUpdateButton.BackColor = System.Drawing.Color.Lime;
            this.medicineInfoUpdateButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineInfoUpdateButton.Location = new System.Drawing.Point(323, 36);
            this.medicineInfoUpdateButton.Name = "medicineInfoUpdateButton";
            this.medicineInfoUpdateButton.Size = new System.Drawing.Size(134, 47);
            this.medicineInfoUpdateButton.TabIndex = 65;
            this.medicineInfoUpdateButton.Text = "Update Medicine Info";
            this.medicineInfoUpdateButton.UseVisualStyleBackColor = false;
            this.medicineInfoUpdateButton.Click += new System.EventHandler(this.medicineInfoUpdateButton_Click);
            // 
            // UpdateMedicineInfoPanel
            // 
            this.UpdateMedicineInfoPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.UpdateMedicineInfoPanel.Controls.Add(this.updateMedicineExpDateTextBox);
            this.UpdateMedicineInfoPanel.Controls.Add(this.confirmUpdateMedInfoButton);
            this.UpdateMedicineInfoPanel.Controls.Add(this.updateMedicineDiscountTextBox);
            this.UpdateMedicineInfoPanel.Controls.Add(this.updateMedicineSellingPriceTextBox);
            this.UpdateMedicineInfoPanel.Controls.Add(this.updateMedicineQuantityTextBox);
            this.UpdateMedicineInfoPanel.Controls.Add(this.updateMedicineIdTextBox);
            this.UpdateMedicineInfoPanel.Controls.Add(this.updateMedicineInfoLabel);
            this.UpdateMedicineInfoPanel.Location = new System.Drawing.Point(14, 92);
            this.UpdateMedicineInfoPanel.Name = "UpdateMedicineInfoPanel";
            this.UpdateMedicineInfoPanel.Size = new System.Drawing.Size(440, 504);
            this.UpdateMedicineInfoPanel.TabIndex = 66;
            this.UpdateMedicineInfoPanel.Visible = false;
            this.UpdateMedicineInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateMedicineInfoPanel_Paint);
            // 
            // updateMedicineExpDateTextBox
            // 
            this.updateMedicineExpDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMedicineExpDateTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateMedicineExpDateTextBox.Location = new System.Drawing.Point(197, 224);
            this.updateMedicineExpDateTextBox.Name = "updateMedicineExpDateTextBox";
            this.updateMedicineExpDateTextBox.Size = new System.Drawing.Size(131, 29);
            this.updateMedicineExpDateTextBox.TabIndex = 7;
            // 
            // confirmUpdateMedInfoButton
            // 
            this.confirmUpdateMedInfoButton.BackColor = System.Drawing.Color.GreenYellow;
            this.confirmUpdateMedInfoButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmUpdateMedInfoButton.Location = new System.Drawing.Point(142, 371);
            this.confirmUpdateMedInfoButton.Name = "confirmUpdateMedInfoButton";
            this.confirmUpdateMedInfoButton.Size = new System.Drawing.Size(130, 57);
            this.confirmUpdateMedInfoButton.TabIndex = 6;
            this.confirmUpdateMedInfoButton.Text = "Confirm";
            this.confirmUpdateMedInfoButton.UseVisualStyleBackColor = false;
            this.confirmUpdateMedInfoButton.Click += new System.EventHandler(this.confirmUpdateMedInfoButton_Click);
            // 
            // updateMedicineDiscountTextBox
            // 
            this.updateMedicineDiscountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMedicineDiscountTextBox.Location = new System.Drawing.Point(197, 267);
            this.updateMedicineDiscountTextBox.Name = "updateMedicineDiscountTextBox";
            this.updateMedicineDiscountTextBox.Size = new System.Drawing.Size(131, 29);
            this.updateMedicineDiscountTextBox.TabIndex = 5;
            // 
            // updateMedicineSellingPriceTextBox
            // 
            this.updateMedicineSellingPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMedicineSellingPriceTextBox.Location = new System.Drawing.Point(197, 178);
            this.updateMedicineSellingPriceTextBox.Name = "updateMedicineSellingPriceTextBox";
            this.updateMedicineSellingPriceTextBox.Size = new System.Drawing.Size(131, 29);
            this.updateMedicineSellingPriceTextBox.TabIndex = 3;
            // 
            // updateMedicineQuantityTextBox
            // 
            this.updateMedicineQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMedicineQuantityTextBox.Location = new System.Drawing.Point(197, 135);
            this.updateMedicineQuantityTextBox.Name = "updateMedicineQuantityTextBox";
            this.updateMedicineQuantityTextBox.Size = new System.Drawing.Size(131, 29);
            this.updateMedicineQuantityTextBox.TabIndex = 2;
            // 
            // updateMedicineIdTextBox
            // 
            this.updateMedicineIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMedicineIdTextBox.Location = new System.Drawing.Point(197, 93);
            this.updateMedicineIdTextBox.Name = "updateMedicineIdTextBox";
            this.updateMedicineIdTextBox.Size = new System.Drawing.Size(131, 29);
            this.updateMedicineIdTextBox.TabIndex = 1;
            // 
            // updateMedicineInfoLabel
            // 
            this.updateMedicineInfoLabel.AutoSize = true;
            this.updateMedicineInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMedicineInfoLabel.Location = new System.Drawing.Point(27, 98);
            this.updateMedicineInfoLabel.Name = "updateMedicineInfoLabel";
            this.updateMedicineInfoLabel.Size = new System.Drawing.Size(121, 189);
            this.updateMedicineInfoLabel.TabIndex = 0;
            this.updateMedicineInfoLabel.Text = "Medicine ID :\r\n\r\nQuantity :\r\n\r\nSelling Price :\r\n\r\nExpiring Date :\r\n\r\nDiscount :";
            // 
            // WorkerInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.medicineInfoUpdateButton);
            this.Controls.Add(this.InventoryGroupBox);
            this.Controls.Add(this.wInLabel);
            this.Controls.Add(this.searchMedicineButton);
            this.Controls.Add(this.removeMedicineButton);
            this.Controls.Add(this.addMedicineButton);
            this.Controls.Add(this.InventoryTitleLabel);
            this.Controls.Add(this.removeMedicinePanel);
            this.Controls.Add(this.addMedicinePanel);
            this.Controls.Add(this.UpdateMedicineInfoPanel);
            this.Controls.Add(this.searchMedicinePanel);
            this.Name = "WorkerInventory";
            this.Size = new System.Drawing.Size(1638, 641);
            this.Load += new System.EventHandler(this.WorkerInventory_Load);
            this.addMedicinePanel.ResumeLayout(false);
            this.addMedicinePanel.PerformLayout();
            this.removeMedicinePanel.ResumeLayout(false);
            this.removeMedicinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.InventoryGroupBox.ResumeLayout(false);
            this.searchMedicinePanel.ResumeLayout(false);
            this.searchMedicinePanel.PerformLayout();
            this.UpdateMedicineInfoPanel.ResumeLayout(false);
            this.UpdateMedicineInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wInLabel;
        private System.Windows.Forms.Button searchMedicineButton;
        private System.Windows.Forms.Button removeMedicineButton;
        private System.Windows.Forms.Button addMedicineButton;
        private System.Windows.Forms.Label InventoryTitleLabel;
        private System.Windows.Forms.Panel addMedicinePanel;
        private System.Windows.Forms.Label addMedicineLabel;
        private System.Windows.Forms.DateTimePicker addExpiringDate;
        private System.Windows.Forms.ComboBox addCategoryComboBox;
        private System.Windows.Forms.Button addMedicineConfirmButton;
        private System.Windows.Forms.TextBox addMedicineDiscountTextBox;
        private System.Windows.Forms.TextBox addMedicineQuantityTextBox;
        private System.Windows.Forms.TextBox addMedicineSellingPriceTextBox;
        private System.Windows.Forms.TextBox addMedicineBuyingPriceTextBox;
        private System.Windows.Forms.TextBox addMedicineCompanyNameTextBox;
        private System.Windows.Forms.TextBox addMedicineNameTextBox;
        private System.Windows.Forms.Panel removeMedicinePanel;
        private System.Windows.Forms.ComboBox removeMedicineMedicineNamesComboBox;
        private System.Windows.Forms.ComboBox removeMedicineCategoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmDeleteMedicineButton;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.GroupBox InventoryGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel searchMedicinePanel;
        private System.Windows.Forms.Button medicineSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchMedicineTextBox;
        private System.Windows.Forms.Label remainingUnitsLabel;
        private System.Windows.Forms.Label ExpiringDateLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label medicineNameLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label totalMedicineProfit;
        private System.Windows.Forms.Button medicineInfoUpdateButton;
        private System.Windows.Forms.Panel UpdateMedicineInfoPanel;
        private System.Windows.Forms.Label updateMedicineInfoLabel;
        private System.Windows.Forms.TextBox updateMedicineIdTextBox;
        private System.Windows.Forms.TextBox updateMedicineDiscountTextBox;
        private System.Windows.Forms.TextBox updateMedicineSellingPriceTextBox;
        private System.Windows.Forms.TextBox updateMedicineQuantityTextBox;
        private System.Windows.Forms.Button confirmUpdateMedInfoButton;
        private System.Windows.Forms.DateTimePicker updateMedicineExpDateTextBox;
    }
}
