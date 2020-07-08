using System;
using System.Threading;
using System.Windows;

namespace WpfApp.TimerTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Timer _timer;

        public MainWindow()
        {
            InitializeComponent();

            _timer = new Timer(new TimerCallback(Tick), null, 1, 1);

        }

        private void Tick(object state)
        {
            this.Dispatcher.Invoke(() =>
            {
                TickLable.Content = DateTime.Now.ToString("HH:mm:ss");
            });
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _timer.Dispose();
        }
    }
}
