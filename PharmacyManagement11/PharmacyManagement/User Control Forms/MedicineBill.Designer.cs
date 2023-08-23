
namespace PharmacyManagement
{
    partial class MedicineBill
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
            this.billDataGridView = new System.Windows.Forms.DataGridView();
            this.billPanel = new System.Windows.Forms.Panel();
            this.billProductDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.billProductDeleteButton = new System.Windows.Forms.Button();
            this.billProductTotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.billLoadProductButton = new System.Windows.Forms.Button();
            this.billCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.billCompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.billDiscountTextBox = new System.Windows.Forms.TextBox();
            this.billAddingButton = new System.Windows.Forms.Button();
            this.billProductQuantityTextBox = new System.Windows.Forms.TextBox();
            this.billProductNameTextBox = new System.Windows.Forms.TextBox();
            this.billProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.billProductLabel = new System.Windows.Forms.Label();
            this.billConfirmButton = new System.Windows.Forms.Button();
            this.billIdTextBox = new System.Windows.Forms.TextBox();
            this.billId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.billPaidTextBox = new System.Windows.Forms.TextBox();
            this.billNetTotalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.billProfitLabel = new System.Windows.Forms.Label();
            this.billSellerIdLabel = new System.Windows.Forms.Label();
            this.workerBillTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            this.billPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // billDataGridView
            // 
            this.billDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.billDataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDataGridView.Location = new System.Drawing.Point(34, 82);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.Size = new System.Drawing.Size(1079, 492);
            this.billDataGridView.TabIndex = 0;
            this.billDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billDataGridView_CellContentClick);
            // 
            // billPanel
            // 
            this.billPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.billPanel.Controls.Add(this.billProductDateTimePicker);
            this.billPanel.Controls.Add(this.billProductDeleteButton);
            this.billPanel.Controls.Add(this.billProductTotalAmountTextBox);
            this.billPanel.Controls.Add(this.billLoadProductButton);
            this.billPanel.Controls.Add(this.billCustomerNameTextBox);
            this.billPanel.Controls.Add(this.billCompanyNameTextBox);
            this.billPanel.Controls.Add(this.billDiscountTextBox);
            this.billPanel.Controls.Add(this.billAddingButton);
            this.billPanel.Controls.Add(this.billProductQuantityTextBox);
            this.billPanel.Controls.Add(this.billProductNameTextBox);
            this.billPanel.Controls.Add(this.billProductPriceTextBox);
            this.billPanel.Controls.Add(this.billProductLabel);
            this.billPanel.Location = new System.Drawing.Point(1142, 82);
            this.billPanel.Name = "billPanel";
            this.billPanel.Size = new System.Drawing.Size(450, 558);
            this.billPanel.TabIndex = 1;
            // 
            // billProductDateTimePicker
            // 
            this.billProductDateTimePicker.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.billProductDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.billProductDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billProductDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.billProductDateTimePicker.Location = new System.Drawing.Point(198, 200);
            this.billProductDateTimePicker.Name = "billProductDateTimePicker";
            this.billProductDateTimePicker.Size = new System.Drawing.Size(157, 29);
            this.billProductDateTimePicker.TabIndex = 15;
            // 
            // billProductDeleteButton
            // 
            this.billProductDeleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.billProductDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billProductDeleteButton.Location = new System.Drawing.Point(115, 466);
            this.billProductDeleteButton.Name = "billProductDeleteButton";
            this.billProductDeleteButton.Size = new System.Drawing.Size(95, 45);
            this.billProductDeleteButton.TabIndex = 14;
            this.billProductDeleteButton.Text = "Delete";
            this.billProductDeleteButton.UseVisualStyleBackColor = false;
            this.billProductDeleteButton.Click += new System.EventHandler(this.billProductDeleteButton_Click);
            // 
            // billProductTotalAmountTextBox
            // 
            this.billProductTotalAmountTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.billProductTotalAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billProductTotalAmountTextBox.Location = new System.Drawing.Point(198, 385);
            this.billProductTotalAmountTextBox.Multiline = true;
            this.billProductTotalAmountTextBox.Name = "billProductTotalAmountTextBox";
            this.billProductTotalAmountTextBox.Size = new System.Drawing.Size(157, 25);
            this.billProductTotalAmountTextBox.TabIndex = 13;
            // 
            // billLoadProductButton
            // 
            this.billLoadProductButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.billLoadProductButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLoadProductButton.ForeColor = System.Drawing.Color.Black;
            this.billLoadProductButton.Location = new System.Drawing.Point(288, 100);
            this.billLoadProductButton.Name = "billLoadProductButton";
            this.billLoadProductButton.Size = new System.Drawing.Size(67, 32);
            this.billLoadProductButton.TabIndex = 12;
            this.billLoadProductButton.Text = "Load Product";
            this.billLoadProductButton.UseVisualStyleBackColor = false;
            this.billLoadProductButton.Click += new System.EventHandler(this.billLoadProductButton_Click);
            // 
            // billCustomerNameTextBox
            // 
            this.billCustomerNameTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.billCustomerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billCustomerNameTextBox.Location = new System.Drawing.Point(198, 341);
            this.billCustomerNameTextBox.Multiline = true;
            this.billCustomerNameTextBox.Name = "billCustomerNameTextBox";
            this.billCustomerNameTextBox.Size = new System.Drawing.Size(157, 25);
            this.billCustomerNameTextBox.TabIndex = 10;
            // 
            // billCompanyNameTextBox
            // 
            this.billCompanyNameTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.billCompanyNameTextBox.Enabled = false;
            this.billCompanyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billCompanyNameTextBox.Location = new System.Drawing.Point(198, 294);
            this.billCompanyNameTextBox.Multiline = true;
            this.billCompanyNameTextBox.Name = "billCompanyNameTextBox";
            this.billCompanyNameTextBox.Size = new System.Drawing.Size(157, 25);
            this.billCompanyNameTextBox.TabIndex = 9;
            // 
            // billDiscountTextBox
            // 
            this.billDiscountTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.billDiscountTextBox.Enabled = false;
            this.billDiscountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDiscountTextBox.Location = new System.Drawing.Point(198, 246);
            this.billDiscountTextBox.Multiline = true;
            this.billDiscountTextBox.Name = "billDiscountTextBox";
            this.billDiscountTextBox.Size = new System.Drawing.Size(157, 25);
            this.billDiscountTextBox.TabIndex = 8;
            // 
            // billAddingButton
            // 
            this.billAddingButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.billAddingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billAddingButton.Location = new System.Drawing.Point(247, 466);
            this.billAddingButton.Name = "billAddingButton";
            this.billAddingButton.Size = new System.Drawing.Size(88, 45);
            this.billAddingButton.TabIndex = 2;
            this.billAddingButton.Text = "Add";
            this.billAddingButton.UseVisualStyleBackColor = false;
            this.billAddingButton.Click += new System.EventHandler(this.billAddingButton_Click);
            // 
            // billProductQuantityTextBox
            // 
            this.billProductQuantityTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.billProductQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billProductQuantityTextBox.Location = new System.Drawing.Point(198, 68);
            this.billProductQuantityTextBox.Multiline = true;
            this.billProductQuantityTextBox.Name = "billProductQuantityTextBox";
            this.billProductQuantityTextBox.Size = new System.Drawing.Size(157, 26);
            this.billProductQuantityTextBox.TabIndex = 6;
            // 
            // billProductNameTextBox
            // 
            this.billProductNameTextBox.BackColor = System.Drawing.Color.LightCyan;
            this.billProductNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billProductNameTextBox.Location = new System.Drawing.Point(198, 18);
            this.billProductNameTextBox.Multiline = true;
            this.billProductNameTextBox.Name = "billProductNameTextBox";
            this.billProductNameTextBox.Size = new System.Drawing.Size(157, 25);
            this.billProductNameTextBox.TabIndex = 5;
            this.billProductNameTextBox.TextChanged += new System.EventHandler(this.billProductNameTextBox_TextChanged);
            // 
            // billProductPriceTextBox
            // 
            this.billProductPriceTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.billProductPriceTextBox.Enabled = false;
            this.billProductPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billProductPriceTextBox.Location = new System.Drawing.Point(198, 154);
            this.billProductPriceTextBox.Multiline = true;
            this.billProductPriceTextBox.Name = "billProductPriceTextBox";
            this.billProductPriceTextBox.Size = new System.Drawing.Size(157, 27);
            this.billProductPriceTextBox.TabIndex = 4;
            this.billProductPriceTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // billProductLabel
            // 
            this.billProductLabel.AutoSize = true;
            this.billProductLabel.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billProductLabel.Location = new System.Drawing.Point(12, 19);
            this.billProductLabel.Name = "billProductLabel";
            this.billProductLabel.Size = new System.Drawing.Size(155, 391);
            this.billProductLabel.TabIndex = 2;
            this.billProductLabel.Text = "Product Name:\r\n\r\nQuantity: \r\n\r\n\r\n\r\nProduct Price :\r\n\r\nDate :\r\n\r\nDiscount :\r\n\r\nCom" +
    "pany name :\r\n\r\nCustomer name :\r\n\r\nTotal :\r\n";
            this.billProductLabel.Click += new System.EventHandler(this.billProductLabel_Click);
            // 
            // billConfirmButton
            // 
            this.billConfirmButton.BackColor = System.Drawing.Color.SeaGreen;
            this.billConfirmButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billConfirmButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.billConfirmButton.Location = new System.Drawing.Point(913, 588);
            this.billConfirmButton.Name = "billConfirmButton";
            this.billConfirmButton.Size = new System.Drawing.Size(200, 45);
            this.billConfirmButton.TabIndex = 8;
            this.billConfirmButton.Text = "Confirm Bill";
            this.billConfirmButton.UseVisualStyleBackColor = false;
            this.billConfirmButton.Click += new System.EventHandler(this.billConfirmButton_Click);
            // 
            // billIdTextBox
            // 
            this.billIdTextBox.BackColor = System.Drawing.Color.Cyan;
            this.billIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billIdTextBox.Location = new System.Drawing.Point(1348, 28);
            this.billIdTextBox.Multiline = true;
            this.billIdTextBox.Name = "billIdTextBox";
            this.billIdTextBox.Size = new System.Drawing.Size(129, 29);
            this.billIdTextBox.TabIndex = 9;
            // 
            // billId
            // 
            this.billId.AutoSize = true;
            this.billId.BackColor = System.Drawing.Color.LightSteelBlue;
            this.billId.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billId.Location = new System.Drawing.Point(1236, 28);
            this.billId.Name = "billId";
            this.billId.Size = new System.Drawing.Size(87, 28);
            this.billId.TabIndex = 10;
            this.billId.Text = "Bill ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Net Total : ";
            // 
            // billPaidTextBox
            // 
            this.billPaidTextBox.BackColor = System.Drawing.Color.LightYellow;
            this.billPaidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billPaidTextBox.Location = new System.Drawing.Point(482, 595);
            this.billPaidTextBox.Name = "billPaidTextBox";
            this.billPaidTextBox.Size = new System.Drawing.Size(157, 31);
            this.billPaidTextBox.TabIndex = 12;
            // 
            // billNetTotalTextBox
            // 
            this.billNetTotalTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.billNetTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNetTotalTextBox.Location = new System.Drawing.Point(197, 594);
            this.billNetTotalTextBox.Multiline = true;
            this.billNetTotalTextBox.Name = "billNetTotalTextBox";
            this.billNetTotalTextBox.Size = new System.Drawing.Size(157, 34);
            this.billNetTotalTextBox.TabIndex = 13;
            this.billNetTotalTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(376, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Paid :";
            // 
            // billProfitLabel
            // 
            this.billProfitLabel.AutoSize = true;
            this.billProfitLabel.Location = new System.Drawing.Point(3, 643);
            this.billProfitLabel.Name = "billProfitLabel";
            this.billProfitLabel.Size = new System.Drawing.Size(9, 13);
            this.billProfitLabel.TabIndex = 15;
            this.billProfitLabel.Text = "\'";
            this.billProfitLabel.Visible = false;
            // 
            // billSellerIdLabel
            // 
            this.billSellerIdLabel.AutoSize = true;
            this.billSellerIdLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.billSellerIdLabel.Location = new System.Drawing.Point(33, 28);
            this.billSellerIdLabel.Name = "billSellerIdLabel";
            this.billSellerIdLabel.Size = new System.Drawing.Size(39, 25);
            this.billSellerIdLabel.TabIndex = 16;
            this.billSellerIdLabel.Text = "ID";
            // 
            // workerBillTitleLabel
            // 
            this.workerBillTitleLabel.AutoSize = true;
            this.workerBillTitleLabel.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerBillTitleLabel.Location = new System.Drawing.Point(861, 9);
            this.workerBillTitleLabel.Name = "workerBillTitleLabel";
            this.workerBillTitleLabel.Size = new System.Drawing.Size(96, 16);
            this.workerBillTitleLabel.TabIndex = 56;
            this.workerBillTitleLabel.Text = "Create Bill";
            // 
            // MedicineBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.workerBillTitleLabel);
            this.Controls.Add(this.billSellerIdLabel);
            this.Controls.Add(this.billProfitLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billNetTotalTextBox);
            this.Controls.Add(this.billPaidTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billId);
            this.Controls.Add(this.billIdTextBox);
            this.Controls.Add(this.billConfirmButton);
            this.Controls.Add(this.billPanel);
            this.Controls.Add(this.billDataGridView);
            this.Name = "MedicineBill";
            this.Size = new System.Drawing.Size(1638, 656);
            this.Load += new System.EventHandler(this.MedicineBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            this.billPanel.ResumeLayout(false);
            this.billPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView billDataGridView;
        private System.Windows.Forms.Panel billPanel;
        private System.Windows.Forms.Label billProductLabel;
        private System.Windows.Forms.TextBox billProductNameTextBox;
        private System.Windows.Forms.TextBox billProductPriceTextBox;
        private System.Windows.Forms.Button billAddingButton;
        private System.Windows.Forms.TextBox billProductQuantityTextBox;
        private System.Windows.Forms.Button billConfirmButton;
        private System.Windows.Forms.TextBox billCompanyNameTextBox;
        private System.Windows.Forms.TextBox billDiscountTextBox;
        private System.Windows.Forms.TextBox billCustomerNameTextBox;
        private System.Windows.Forms.TextBox billIdTextBox;
        private System.Windows.Forms.Label billId;
        private System.Windows.Forms.Button billLoadProductButton;
        private System.Windows.Forms.TextBox billProductTotalAmountTextBox;
        private System.Windows.Forms.Button billProductDeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox billPaidTextBox;
        private System.Windows.Forms.TextBox billNetTotalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label billProfitLabel;
        private System.Windows.Forms.Label billSellerIdLabel;
        private System.Windows.Forms.DateTimePicker billProductDateTimePicker;
        private System.Windows.Forms.Label workerBillTitleLabel;
    }
}
