using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Async
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread thread1;
        Thread thread2;
        Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startTread1_Click(object sender, RoutedEventArgs e)
        {
            if (thread1 == null || !thread1.IsAlive)
            {
                thread1 = new Thread(()=>doWork(ball1));
                thread1.Priority = ThreadPriority.Lowest;
                thread1.Start();
                
            }
        }

        private void startTread2_Click(object sender, RoutedEventArgs e)
        {
            if (thread2 == null || !thread2.IsAlive)
            {
                thread2 = new Thread(() => doWork(ball2));
                thread2.Priority = ThreadPriority.Highest;
                thread2.Start();
            }
        }
        void doWork(Ellipse ball)
        {
            while (true)
            {
                this.Dispatcher.Invoke(new Action(() =>
                {
                    lock (rand)
                    {
                        Thickness margin = ball.Margin;
                        margin.Top += rand.Next(9,12);
                        ball.Margin = margin;
                    }
                }));
                Thread.Sleep(1000);
            }
        }

        private void stopTread1_Click(object sender, RoutedEventArgs e)
        {
            if (thread1 != null || thread1.IsAlive)
            {
                thread1.Abort();
            }
        }

        private void stopTread2_Click(object sender, RoutedEventArgs e)
        {
            if (thread2 != null || thread2.IsAlive)
            {
                thread2.Abort();
            }
        }

        private void stopBothTreads_Click(object sender, RoutedEventArgs e)
        {
            stopTread1_Click(null, null);
            stopTread2_Click(null, null);
        }

        private void startBothThreads_Click(object sender, RoutedEventArgs e)
        {
            startTread1_Click(null, null);
            startTread2_Click(null, null);
        }

        
    }
}
