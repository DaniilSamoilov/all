using System.Text;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int input;
        private void button_convert_Click(object sender, EventArgs e)
        {
            labelOutput.Text = $"В двоичной\n{convert(input)}";
        }
        private void textBoxInput_Leave(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBoxInput.Text, out input) || input < 0)
            {
                if (textBoxInput.Text == String.Empty)
                {
                    input = 0;
                    textBoxInput.Text = "0";
                    return;
                }
                MessageBox.Show("Неверно задано значение!, Введите число cнова");
                textBoxInput.Select();
                return;
            }

        }

        static string convert(int inp)
        {
            StringBuilder str = new();
            do
            {
                str.Insert(0, inp % 2);
                inp /= 2;
            } while (inp > 0);
            try { return str.ToString(); }
            catch { MessageBox.Show("Ошибка в методе Convert, str вернул null"); return "error"; }
        }
    }
}