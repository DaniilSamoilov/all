using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal input, initial_guess;
        int iter = 0;
        static decimal Newton(decimal input, decimal guess, ref int iter)
        {
            decimal? previous_guess = null;
            while (Math.Abs(guess * guess - input) > Convert.ToDecimal(Math.Pow(10, -28)) && previous_guess!=guess)
            {
                previous_guess = guess;
                guess = (guess + (input / guess)) / 2;
                iter++;
            }

            return guess;
        }

        static decimal Newton(decimal input, ref decimal guess, ref int iter)
        {
            guess = (guess + input / guess) / 2;
            iter++;

            return guess;
        }

        private void textBoxInput_Leave(object sender, EventArgs e)
        {
            iter = 0;
            if (!Decimal.TryParse(textBoxInput.Text, out input) || input < 0)
            {
                if (textBoxInput.Text == String.Empty) { input = 0; return; }
                MessageBox.Show("Неверно задано значение!, Введите число cнова");
                textBoxInput.Select();
                return;
            }
        }
        private void textBoxInputInitialGuess_Leave(object sender, EventArgs e)
        {
            iter = 0;
            if (!Decimal.TryParse(textBoxInputInitialGuess.Text, out initial_guess) || initial_guess < 0)
            {
                if (textBoxInputInitialGuess.Text == String.Empty) { initial_guess = 0; return; }
                MessageBox.Show("Неверно задано значение!, Введите число cнова");
                textBoxInputInitialGuess.Select();
                return;
            }
        }
        private void buttonOutputMath_Click(object sender, EventArgs e)
        {
            textBoxOutputMath.Text = Convert.ToString(Math.Sqrt((double)input));
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = Convert.ToString(Newton(input, initial_guess, ref iter));
            labelOutput.Text = $"Количество итераций: {iter}\n" +
                $"Погрешность: {Math.Abs(Convert.ToDecimal(Math.Sqrt((double)input)) - Convert.ToDecimal(textBoxOutput.Text))}";
        }

        private void buttonIterToOutput_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = Convert.ToString(Newton(input, ref initial_guess, ref iter));
            labelOutput.Text = $"Количество итераций: {iter}\n" +
                $"Погрешность: {Math.Abs(Convert.ToDecimal(Math.Sqrt((double)input)) - Convert.ToDecimal(textBoxOutput.Text))}";
        }
    }
}