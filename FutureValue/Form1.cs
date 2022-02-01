using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class FutureValueForm : Form
    {
        decimal monthlyPrincipal, intRate, future;
        int months;

        public FutureValueForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFuture.Text = "";
        }

        private void FutureValueForm_DoubleClick(object sender, EventArgs e)
        {
            txtAPR.Text = "";
            txtFuture.Text = "";
            txtMontly.Text = "";
            txtYears.Text = "";
        }

        private void txtAPR_DoubleClick(object sender, EventArgs e)
        {
            txtAPR.Text = "12";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                monthlyPrincipal = Decimal.Parse(txtMontly.Text);
                intRate = Decimal.Parse(txtAPR.Text) / 12;
                months = int.Parse(txtYears.Text) * 12;
                future = CalculateFutureValue(monthlyPrincipal, intRate, months);
                txtFuture.Text = future.ToString("c");

            }catch(FormatException)
            {
                MessageBox.Show("Invalid numeric format, please input numeric values.", "Format Error");
            }catch(OverflowException)
            {
                MessageBox.Show("Value too large, please input smaller numeric values.","Overflow Error");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private decimal CalculateFutureValue(decimal monthlyPrincipal, 
            decimal intRate, int months)
        {
            decimal future = 0;

            for (int i = 0; i < months; i++)
            {
                future += (monthlyPrincipal);
                future += future * (intRate / 100);
            }

            return future;
        }
    }
}
