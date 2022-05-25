using System;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void ConvertCurrency(object sender, EventArgs e)
        {
            decimal bgn = this.amount.Value;
            decimal eur = bgn / 1.95583m;

            this.resultLable.Text = $"{bgn} BGN = {eur:F2} EUR";
        }
    }
}
