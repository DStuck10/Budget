using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Budget
{
    public partial class BudgetForm : Form
    {
        public BudgetForm()
        {
            InitializeComponent();
        }     

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtHours.Text != "Hours Worked")
            {
                // Declaring the tax amounts
                decimal socialSecurityTax = .062M;
                decimal medicareTax = .0145M;
                decimal paIncomeTax = .0307M;
                decimal decaturTownshipIncomeTax = .01350M;
                decimal paSuiSdiTax = .0007M;
                decimal hourlyPay, hoursWorked;

                // Declaring the amount of money earned and calculating the amount of taxes deducted
                hoursWorked = Convert.ToDecimal(txtHours.Text);
                hourlyPay = Convert.ToDecimal(txtPay.Text);

                decimal grossPay = hourlyPay * hoursWorked;
                decimal socialSecurityTaxWithholding = grossPay * socialSecurityTax;
                decimal medicareTaxWithholding = grossPay * medicareTax;
                decimal paIncomeTaxWithholding = grossPay * paIncomeTax;
                decimal decaturTowhshipIncomeTaxWithholding = grossPay * decaturTownshipIncomeTax;
                decimal paSuiSdiWithholding = grossPay * paSuiSdiTax;

                lblMoneyEarned.Text = (grossPay - socialSecurityTaxWithholding - medicareTaxWithholding -
                    paIncomeTaxWithholding - decaturTowhshipIncomeTaxWithholding - paSuiSdiWithholding).ToString("C2");
                lblTotalEarned.Visible = true;
                
            }
            dataGrid.Visible = true;

            // Declaring the data grid variables
            string Category, Date, Description, PurchaseAmount, Payment;
            double pay = Convert.ToDouble(txtPay.Text);
            double HoursWorked;
            double TotalEarned;

            // Assigns the values to the data grid variables
            Category = DropDownExpenseType.Text;            
            Date = dateTime.Text;
            Description = txtDescription.Text;
            PurchaseAmount = txtPurchaseAmount.Text;
            Payment = DropDownPaymentType.Text;

            // Setting the value to zero if no value entered
            if (txtHours.Text == "Hours Worked")
            {
                HoursWorked = 0;
                TotalEarned = 0;
            }
            else
            {
                HoursWorked = Convert.ToDouble(txtHours.Text);
                TotalEarned = pay * HoursWorked;
            }

            dataGrid.Visible = true;

            // Enters the data from the text boxes into the data grid
            string firstColumn = Date;
            string secondColumn = Category;
            string thirdColumn = Description;
            string fourthColumn = PurchaseAmount;
            string fifthColumn = Payment;
            string sixthColumn = Convert.ToString(HoursWorked);
            string seventhColumn = Convert.ToString(TotalEarned);
            string[] row = { firstColumn, secondColumn, thirdColumn, fourthColumn, fifthColumn, sixthColumn, seventhColumn };
            dataGrid.Rows.Add(row);

            // Reset the text box values after button click
            txtHours.Text = "Hours Worked";
            DropDownExpenseType.Text = "";
            txtDescription.Text = "";
            txtPurchaseAmount.Text = "";           
        }

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            lblMoneyEarned.Text = "";
            txtPay.Text = "7.50";
        }

        private void txtHours_Click(object sender, EventArgs e)
        {
            txtHours.Text = "";
        }

        private void txtHours_Leave(object sender, EventArgs e)
        {
            if (txtHours.Text == "")
            {
                txtHours.Text = "Hours Worked";
            }
        }

        private void txtPay_DoubleClick(object sender, EventArgs e)
        {
            Form f2 = new Hourly_Wage();
            f2.ShowDialog();
            txtPay.Text = Convert.ToString(Variable.NewHourWage);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {         
            
        }        
    }
}
