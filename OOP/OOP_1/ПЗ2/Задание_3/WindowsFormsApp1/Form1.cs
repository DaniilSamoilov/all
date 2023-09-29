using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void button_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBox_num1.Text, out num_1))
            {
                MessageBox.Show("Неверно задано значение!, Введите число cнова");
            }
            if (!Int32.TryParse(textBox_num2.Text, out num_2))
            {
                MessageBox.Show("Неверно задано значение!, Введите число cнова");
            }

            int result;
            long time;
            (result, time) = NOD(num_1, num_2);

            label3.Text += "\nРезультат:" + result.ToString() +
                "\nВремя выполнения(в тиках):" + time.ToString() + "\n";



            (result, time) = FindGCDStein(num_1, num_2);

            label4.Text += "\nРезультат:" + result.ToString() +
                "\nВремя выполнения(в тиках):" + time.ToString() + "\n";
        }



        public static (int nod, long time) NOD(int a, int b)//метод Евклида
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            a = Math.Abs(a);
            b = Math.Abs(b);
            
            if (a == 0) return (b, timer.ElapsedTicks);
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
            return (a, timer.ElapsedTicks);
        }

        static public (int nod, long time) FindGCDStein(int u, int v)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int k;
            // Step 1.
            // gcd(0, v) = v, because everything divides zero, 
            // and v is the largest number that divides v. 
            // Similarly, gcd(u, 0) = u. gcd(0, 0) is not typically 
            // defined, but it is convenient to set gcd(0, 0) = 0.
            if (u == 0 || v == 0)
                return (u | v, timer.ElapsedTicks);
            // Step 2.
            // if u and v are both even, then gcd(u, v) = 2•gcd(u/2, v/2), 
            // because 2 is a common divisor. 
            for (k = 0; ((u | v) & 1) == 0; ++k)
            {
                u >>= 1;
                v >>= 1;
            }
            // Step 3.
            // if u is even and v is odd, then gcd(u, v) = gcd(u/2, v), 
            // because 2 is not a common divisor. 
            // Similarly, if u is odd and v is even, 
            // then gcd(u, v) = gcd(u, v/2). 

            while ((u & 1) == 0)
                u >>= 1;
            // Step 4.
            // if u and v are both odd, and u ≥ v, 
            // then gcd(u, v) = gcd((u − v)/2, v). 
            // If both are odd and u < v, then gcd(u, v) = gcd((v − u)/2, u). 
            // These are combinations of one step of the simple 
            // Euclidean algorithm, 
            // which uses subtraction at each step, and an application 
            // of step 3 above. 
            // The division by 2 results in an integer because the 
            // difference of two odd numbers is even.
            do
            {
                while ((v & 1) == 0)  // Loop x
                    v >>= 1;
                // Now u and v are both odd, so diff(u, v) is even.
                //   Let u = min(u, v), v = diff(u, v)/2. 
                if (u < v)
                {
                    v -= u;
                }
                else
                {
                    int diff = u - v;
                    u = v;
                    v = diff;
                }
                v >>= 1;
                // Step 5.
                // Repeat steps 3–4 until u = v, or (one more step) 
                // until u = 0.
                // In either case, the result is (2^k) * v, where k is 
                // the number of common factors of 2 found in step 2. 
            } while (v != 0);
            u <<= k;
            return (u, timer.ElapsedTicks);
        }
    }
}