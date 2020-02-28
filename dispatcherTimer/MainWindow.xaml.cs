using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace dispatcherTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer dispatcher = new DispatcherTimer();

            dispatcher.Interval = TimeSpan.FromSeconds(1);

            dispatcher.Tick += dateTimer;

            dispatcher.Start();

            actualTime.Content = DateTime.Now.ToLocalTime();
        }

        private void dateTimer(object sender, EventArgs e)
        {
            actualTime.Content = DateTime.Now.ToLocalTime();
        }
    }
}
