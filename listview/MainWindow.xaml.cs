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
        ObservableCollection<PersonData> listOfNames = new ObservableCollection<PersonData>();
        public MainWindow()
        {
            InitializeComponent();

            listOfNames.Add(new PersonData() { Name="Tom", Age=43, Email="tom@gmail.com" });
            listOfNames.Add(new PersonData() { Name = "Mila", Age = 19, Email = "mila@gmail.com" });
            listOfNames.Add(new PersonData() { Name = "Alex", Age = 25, Email = "alex@gmail.com" });
            listOfNames.Add(new PersonData() { Name = "Jess", Age = 33, Email = "Jess@gmail.com" });

            ListOfName.ItemsSource = listOfNames;
        }
        private void ListBox_SelectionChange(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(ListOfName.SelectedIndex.ToString());
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listOfNames.Add(new PersonData() { Name = NameToAdd.Text, Age = Convert.ToInt32(AgeToAdd.Text), Email = EmailToAdd.Text });
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
