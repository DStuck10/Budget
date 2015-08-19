using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class Hourly_Wage : Form
    {        
        public Hourly_Wage()
        {
            InitializeComponent();
        }      

        private void txtHourlyWageEdit_Click(object sender, EventArgs e)
        {
            txtHourlyWageEdit.Text = "";            
        }

        public void btnEnter_Click(object sender, EventArgs e)
        {
            Variable.NewHourWage = Convert.ToDouble(txtHourlyWageEdit.Text);
            this.Close();
        }        
    }
}
