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

        int num_1, num_2;
        public static int NOD(int a, int b)//метод Евклида
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0) return b;
            while (b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBox_num1.Text, out num_1))
            {
                MessageBox.Show("Неверно задано значение 1-го числа!, Введите число cнова");
            }
            if (!Int32.TryParse(textBox_num2.Text, out num_2))
            {
                MessageBox.Show("Неверно задано значение 2-го числа!, Введите число cнова");
            }
            NOD_OUT.Text = NOD(num_1, num_2).ToString();
        }
    }
}
