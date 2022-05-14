using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal bgn = this.amount.Value;
            decimal eur = bgn / 1.95583m;

            this.resultLable.Text = $"{bgn} BGN = {eur:F2} EUR";
        }

        private void resultLable_Click(object sender, EventArgs e)
        {

        }
    }
}
