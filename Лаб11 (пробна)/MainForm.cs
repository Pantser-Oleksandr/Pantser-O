using System;
using System.Windows.Forms;

namespace Lab11_Variant7
{
    public partial class MainForm : Form
    {
        private DecimalString decimalString1;
        private DecimalString decimalString2;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {
            string input = txtInput1.Text;
            decimalString1 = new DecimalString(input);
            lblStatus1.Text = $"Створено: {decimalString1.GetString()} (число: {decimalString1.GetNumericValue()})";
        }

        private void btnCreate2_Click(object sender, EventArgs e)
        {
            string input = txtInput2.Text;
            decimalString2 = new DecimalString(input);
            lblStatus2.Text = $"Створено: {decimalString2.GetString()} (число: {decimalString2.GetNumericValue()})";
        }

        private void btnCreateFromNumber_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumberInput.Text, out int number))
            {
                decimalString1 = new DecimalString(number);
                lblStatus1.Text = $"Створено з числа: {decimalString1.GetString()}";
            }
            else
            {
                MessageBox.Show("Введіть коректне ціле число");
            }
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            if (decimalString1 != null && decimalString2 != null)
            {
                int diff = DecimalString.Difference(decimalString1, decimalString2);
                lblResult.Text = $"Різниця: {diff}";
            }
            else
            {
                MessageBox.Show("Спочатку створіть обидві стрічки");
            }
        }

        private void btnCompareGreater_Click(object sender, EventArgs e)
        {
            if (decimalString1 != null && decimalString2 != null)
            {
                bool isGreater = DecimalString.IsGreater(decimalString1, decimalString2);
                lblResult.Text = $"Перше > Друге: {isGreater}";
            }
            else
            {
                MessageBox.Show("Спочатку створіть обидві стрічки");
            }
        }

        private void btnCompareLess_Click(object sender, EventArgs e)
        {
            if (decimalString1 != null && decimalString2 != null)
            {
                bool isLess = DecimalString.IsLess(decimalString1, decimalString2);
                lblResult.Text = $"Перше < Друге: {isLess}";
            }
            else
            {
                MessageBox.Show("Спочатку створіть обидві стрічки");
            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            if (decimalString1 != null)
            {
                decimalString1.Clear();
                lblStatus1.Text = "Стрічка 1 очищена";
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            if (decimalString2 != null)
            {
                decimalString2.Clear();
                lblStatus2.Text = "Стрічка 2 очищена";
            }
        }
    }
}