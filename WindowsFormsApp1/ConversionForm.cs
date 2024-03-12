using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertCurrency(object sender, EventArgs e)
        {
            const decimal ConversionCoefficent = 1.95583m;

            decimal amountBGN = this.numericUpDownAmount.Value;
            decimal amountEUR = amountBGN / ConversionCoefficent;

            this.resultLabel.Text = $"{amountBGN} BGN = {amountEUR:F2} EUR";
        }
    }
}
