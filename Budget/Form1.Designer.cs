namespace Budget
{
    partial class BudgetForm
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
            this.txtHours = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblMoneyEarned = new System.Windows.Forms.Label();
            this.lblExpenseType = new System.Windows.Forms.Label();
            this.DropDownExpenseType = new System.Windows.Forms.ComboBox();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPurchaseAmount = new System.Windows.Forms.Label();
            this.txtPurchaseAmount = new System.Windows.Forms.TextBox();
            this.lblTotalEarned = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPayType = new System.Windows.Forms.Label();
            this.DropDownPaymentType = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPayEarned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(250, 19);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 2;
            this.txtHours.Text = "Hours Worked";
            this.txtHours.Click += new System.EventHandler(this.txtHours_Click);
            this.txtHours.Leave += new System.EventHandler(this.txtHours_Leave);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(13, 19);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(453, 366);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(356, 19);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(72, 20);
            this.txtPay.TabIndex = 3;
            this.txtPay.Text = "Hourly Wage";
            this.txtPay.DoubleClick += new System.EventHandler(this.txtPay_DoubleClick);
            // 
            // lblMoneyEarned
            // 
            this.lblMoneyEarned.AutoSize = true;
            this.lblMoneyEarned.Location = new System.Drawing.Point(434, 22);
            this.lblMoneyEarned.Name = "lblMoneyEarned";
            this.lblMoneyEarned.Size = new System.Drawing.Size(73, 13);
            this.lblMoneyEarned.TabIndex = 0;
            this.lblMoneyEarned.Text = "MoneyEarned";
            // 
            // lblExpenseType
            // 
            this.lblExpenseType.AutoSize = true;
            this.lblExpenseType.Location = new System.Drawing.Point(13, 50);
            this.lblExpenseType.Name = "lblExpenseType";
            this.lblExpenseType.Size = new System.Drawing.Size(75, 13);
            this.lblExpenseType.TabIndex = 0;
            this.lblExpenseType.Text = "Expense Type";
            // 
            // DropDownExpenseType
            // 
            this.DropDownExpenseType.FormattingEnabled = true;
            this.DropDownExpenseType.Items.AddRange(new object[] {
            "Eating Out",
            "Transportation",
            "Groceries",
            "Gifts",
            "Other"});
            this.DropDownExpenseType.Location = new System.Drawing.Point(16, 67);
            this.DropDownExpenseType.Name = "DropDownExpenseType";
            this.DropDownExpenseType.Size = new System.Drawing.Size(121, 21);
            this.DropDownExpenseType.TabIndex = 4;
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Location = new System.Drawing.Point(357, 3);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(69, 13);
            this.lblHourlyWage.TabIndex = 0;
            this.lblHourlyWage.Text = "Hourly Wage";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 111);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(346, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 95);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(108, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Purchase Description";
            // 
            // lblPurchaseAmount
            // 
            this.lblPurchaseAmount.AutoSize = true;
            this.lblPurchaseAmount.Location = new System.Drawing.Point(16, 138);
            this.lblPurchaseAmount.Name = "lblPurchaseAmount";
            this.lblPurchaseAmount.Size = new System.Drawing.Size(91, 13);
            this.lblPurchaseAmount.TabIndex = 0;
            this.lblPurchaseAmount.Text = "Purchase Amount";
            // 
            // txtPurchaseAmount
            // 
            this.txtPurchaseAmount.Location = new System.Drawing.Point(16, 155);
            this.txtPurchaseAmount.Name = "txtPurchaseAmount";
            this.txtPurchaseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtPurchaseAmount.TabIndex = 7;
            // 
            // lblTotalEarned
            // 
            this.lblTotalEarned.AutoSize = true;
            this.lblTotalEarned.Location = new System.Drawing.Point(434, 3);
            this.lblTotalEarned.Name = "lblTotalEarned";
            this.lblTotalEarned.Size = new System.Drawing.Size(76, 13);
            this.lblTotalEarned.TabIndex = 0;
            this.lblTotalEarned.Text = "Money Earned";
            this.lblTotalEarned.Visible = false;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Category,
            this.PurchaseDescription,
            this.PurchaseAmount,
            this.Payment,
            this.HoursWorked,
            this.TotalPayEarned});
            this.dataGrid.Location = new System.Drawing.Point(19, 182);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(491, 178);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.TabStop = false;
            this.dataGrid.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPayType
            // 
            this.lblPayType.AutoSize = true;
            this.lblPayType.Location = new System.Drawing.Point(178, 50);
            this.lblPayType.Name = "lblPayType";
            this.lblPayType.Size = new System.Drawing.Size(99, 13);
            this.lblPayType.TabIndex = 0;
            this.lblPayType.Text = "Method of Payment";
            // 
            // DropDownPaymentType
            // 
            this.DropDownPaymentType.FormattingEnabled = true;
            this.DropDownPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Debit",
            "Credit",
            "Check"});
            this.DropDownPaymentType.Location = new System.Drawing.Point(181, 67);
            this.DropDownPaymentType.Name = "DropDownPaymentType";
            this.DropDownPaymentType.Size = new System.Drawing.Size(121, 21);
            this.DropDownPaymentType.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // PurchaseDescription
            // 
            this.PurchaseDescription.HeaderText = "Purchase Description";
            this.PurchaseDescription.Name = "PurchaseDescription";
            this.PurchaseDescription.ReadOnly = true;
            // 
            // PurchaseAmount
            // 
            this.PurchaseAmount.HeaderText = "Purchase Amount";
            this.PurchaseAmount.Name = "PurchaseAmount";
            this.PurchaseAmount.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            // 
            // HoursWorked
            // 
            this.HoursWorked.HeaderText = "Hours Worked";
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.ReadOnly = true;
            this.HoursWorked.Width = 50;
            // 
            // TotalPayEarned
            // 
            this.TotalPayEarned.HeaderText = "Total Pay Earned";
            this.TotalPayEarned.Name = "TotalPayEarned";
            this.TotalPayEarned.ReadOnly = true;
            // 
            // BudgetForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(539, 401);
            this.Controls.Add(this.DropDownPaymentType);
            this.Controls.Add(this.lblPayType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.lblTotalEarned);
            this.Controls.Add(this.txtPurchaseAmount);
            this.Controls.Add(this.lblPurchaseAmount);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblHourlyWage);
            this.Controls.Add(this.DropDownExpenseType);
            this.Controls.Add(this.lblExpenseType);
            this.Controls.Add(this.lblMoneyEarned);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txtHours);
            this.Name = "BudgetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget";
            this.Load += new System.EventHandler(this.BudgetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblMoneyEarned;
        private System.Windows.Forms.Label lblExpenseType;
        private System.Windows.Forms.ComboBox DropDownExpenseType;
        private System.Windows.Forms.Label lblHourlyWage;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPurchaseAmount;
        private System.Windows.Forms.TextBox txtPurchaseAmount;
        private System.Windows.Forms.Label lblTotalEarned;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPayType;
        private System.Windows.Forms.ComboBox DropDownPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPayEarned;
    }
}

