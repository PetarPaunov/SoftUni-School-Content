namespace GUI_Currency_Converter
{
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }

        private void ConvertCurrency(object sender, EventArgs e)
        {
            const decimal ConversionCoefficient = 1.95583m;

            decimal amountBGN = this.amountNumericUpDown.Value;
            decimal amountEUR = amountBGN / ConversionCoefficient;

            this.resultLabel.Text = $"{amountBGN} BGN = {amountEUR:F2} EUR";
        }
    }
}