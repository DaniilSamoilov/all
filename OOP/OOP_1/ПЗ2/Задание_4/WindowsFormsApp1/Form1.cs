using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        
        static int mtx1_row;
        static int mtx1_col;
        static int mtx2_row;
        static int mtx2_col;
        static int mtx3_row;
        static int mtx3_col;
        double[,] mtx1;
        double[,] mtx2;
        double[,] mtx3;
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBox1.Text, out mtx1_col))
                MessageBox.Show("Не все элементы возможно преобразовать в числа");
            if (!Int32.TryParse(textBox2.Text, out mtx1_row))
                MessageBox.Show("Не все элементы возможно преобразовать в числа");
            if (!Int32.TryParse(textBox3.Text, out mtx2_col))
                MessageBox.Show("Не все элементы возможно преобразовать в числа");

            mtx1 = new double[mtx1_row, mtx1_col];
            dataGridView1.ColumnCount = mtx1_col ;
            dataGridView1.RowCount = mtx1_row;

            mtx2 = new double[mtx1_col, mtx2_col];
            dataGridView2.ColumnCount = mtx2_col;
            dataGridView2.RowCount = mtx1_col;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            get_Values_From_Grid(dataGridView1, ref mtx1);
            get_Values_From_Grid(dataGridView2, ref mtx2);

            mtx1_row = mtx1.GetUpperBound(0) + 1;
            mtx1_col = mtx1.Length / mtx1_row;

            mtx2_row = mtx2.GetUpperBound(0) + 1;
            mtx2_col = mtx2.Length / mtx2_row;

            mtx3_row = mtx1_row;
            mtx3_col = mtx2_col;
            mtx3 = new double[mtx3_row, mtx3_col];

            for(int i =0; i < mtx3_row; i++)
            {
                for(int j = 0; j < mtx3_col; j++)
                {
                    double elem = 0;
                    for(int k = 0;k< mtx1_col; k++)
                    {
                        elem += mtx1[i, k] * mtx2[k, j];
                    }
                    mtx3[i, j]= elem;
                }
                set_values_in_grid(ref dataGridView3, mtx3);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mtx1_row; i++)
            {
                for (int j = 0; j < mtx1_col; j++)
                {
                    mtx1[i,j]=rnd.Next(0,20);
                }
            }

            for (int i = 0; i < mtx1_col; i++)
            {
                for (int j = 0; j < mtx2_col; j++)
                {
                    mtx2[i, j] = rnd.Next(0, 20);
                }
            }

            set_values_in_grid(ref dataGridView1, mtx1);
            set_values_in_grid(ref dataGridView2, mtx2);
        }
        
       


        public static void set_values_in_grid(ref DataGridView grid, double[,] arr)
        {
            int rows = arr.GetUpperBound(0) + 1;

            grid.ColumnCount = rows;
            grid.RowCount = arr.Length / rows;

            for (int i = 0; i <  rows ; i++)
            {
                for (int j = 0; j < arr.Length/rows; j++)
                {
                    grid.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
        }

        private static void get_Values_From_Grid(DataGridView grid, ref double[,] matrix)
        {
            int columns = grid.ColumnCount;
            int rows = grid.RowCount;
            // Iterate over cells in Grid, copying to matrix array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToDouble(grid.Rows[i].Cells[j].Value);
                }
            }
        }
    }
}
