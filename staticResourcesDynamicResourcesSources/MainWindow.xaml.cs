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

namespace DataContextAndTheINotifyPropertyChangedInterface
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void select_Click(object sender, RoutedEventArgs e)
        {
            (this.Resources["editingModes"] as InkEditingModes).EditingMode = InkCanvasEditingMode.Select;
        }

        private void draw_Click(object sender, RoutedEventArgs e)
        {
            (this.Resources["editingModes"] as InkEditingModes).EditingMode = InkCanvasEditingMode.Ink;
        }
    }
}
