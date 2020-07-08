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

namespace WpfApp.TimerTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer _timer;

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
