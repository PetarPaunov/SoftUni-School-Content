namespace CurrencyConverter
{
    public partial class ConvertionForm : Form
    {
        public ConvertionForm()
        {
            InitializeComponent();
        }

        private void ConvertCurrency(object sender, EventArgs e)
        {
            decimal amountBGN = this.amount.Value;
            decimal amountEUR = amountBGN / 1.95583m;

            this.resultLable.Text = $"{amountBGN} BGN = {amountEUR:F2} EUR";
        }
    }
}