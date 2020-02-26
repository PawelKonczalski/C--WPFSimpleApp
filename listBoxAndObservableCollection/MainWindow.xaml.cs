using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace listBoxAndObservableCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> listOfNames = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();

            listOfNames.Add("Tom");
            listOfNames.Add("Mila");
            listOfNames.Add("Alex");
            listOfNames.Add("Angelina");

            ListOfName.ItemsSource = listOfNames;
        }
        private void ListBox_SelectionChange(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(ListOfName.SelectedIndex.ToString());
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listOfNames.Add(NameToAdd.Text);
            //ListOfName.Items.Add(NameToAdd.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int selectedNameInde = ListOfName.SelectedIndex;

            if (selectedNameInde != -1)
                listOfNames.RemoveAt(selectedNameInde);
                //ListOfName.Items.RemoveAt(selectedNameInde);
        }
    }
}
