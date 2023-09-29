using System;
using System.Windows;

namespace lab1
{
    public partial class MainWindow : Window
    {
        public int n = 16;//вариант 9
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        public double AvgInfo(double[] prob)
        {
            double info = 0;
            for (int i = 0; i < n; i++)
            {
                info += prob[i] * Math.Log(prob[i], 2);
            }
            return -info;
        }
        public double[] probability()
        {
            double[] prob = new double[n];
            double S = 0;
            for (int i = 0; i < n; i++)
            {
                prob[i] = rnd.NextDouble();
                S += prob[i];
            }
            S = 1 / S;
            for (int i = 0; i < n; i++)
            {
                prob[i] = prob[i] * S;
            }
            return prob;
        }
        public double MaxEntropy(double N) 
        {
            double H = Math.Log(N,2);
            return H;
        }
        private void generate_btn_Click(object sender, RoutedEventArgs e)
        {
            prob_display_text.Text = "";
            double[] prob = new double[n];
            prob = probability();
            prob_display_text.Text += String.Join("; ", prob);
            max_entopy_text.Content = "" + MaxEntropy(n);
            avg_info_text.Content = "" + AvgInfo(prob);
        }
    }
}
