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

namespace menusAndBuilt_inCommands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            /*   ApplicationCommands.Close.InputGestures.Add(
                   new KeyGesture(Key.Q, ModifierKeys.Control)
                   );
                   */
            EditingCommands.IncreaseFontSize.InputGestures.Add(new KeyGesture(Key.F3, ModifierKeys.Shift));
            ApplicationCommands.Copy.InputGestures.Clear();
            ApplicationCommands.Copy.InputGestures.Add(new KeyGesture(Key.Q, ModifierKeys.Alt));
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void CommandBindings_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBindings_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CommandBindings_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBindings_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            HelpBox helpBox = new HelpBox();
            helpBox.Show();
        }
    }
}
