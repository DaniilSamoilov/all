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

        string input;
        int[] nums;
        public static int NOD(int a, params int[] nums)//метод Евклида
        {
            a = Math.Abs(a);
            nums[0] = Math.Abs(nums[0]);

            if (a == 0) return nums[0];
            while (nums[0] != 0)
            {
                if (a > nums[0])
                {
                    a -= nums[0];
                }
                else
                {
                    nums[0] -= a;
                }
            }
            if (nums.Length <= 1)
            {
                return a;
            }
            return NOD(a, nums.Skip(1).ToArray());
        }

        public static int NOD(params int[] nums)
        {
            return NOD(nums[0], nums.Skip(1).ToArray());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            nums = new int[0];
            input = textBox_num1.Text;
            string[] splited_input = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            foreach (string elem in splited_input)
            {
                nums = nums.Append(i).ToArray();
                if (!Int32.TryParse(elem, out nums[i]))
                    MessageBox.Show("Не все элементы возможно преобразовать в числа");
                i++;
            }

            if (splited_input.Length > 1)
                textBox_NOD.Text = NOD(nums).ToString();
        }
    }
}
