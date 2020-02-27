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

namespace dataGrid
{
    public partial class MainWindow : Window
    {
        ObservableCollection<PersonData> listOfPeople = new ObservableCollection<PersonData>();
        public MainWindow()
        {
            InitializeComponent();

            listOfPeople.Add(new PersonData()
            {
                Name = "Alex",
                Age = 18,
                Email = "alex@gmail.com",
                IsSubscribedToNewsleter = true,
                Website = new Uri("http://google.pl")
            });

            listOfPeople.Add(new PersonData()
            {
                Name = "Mila",
                Age = 32,
                Email = "mila@gmail.com",
                Sex = PersonData.Gender.Famale,
                Description = "Mila description"
            });
            
            listOfPeople.Add(new PersonData()
            {
                Name = "John",
                Age = 54,
                Email = "john@gmail.com",
                Image = "img1.jpg"
            });
            
            listOfPeople.Add(new PersonData()
            {
                Name = "Ginger",
                Age = 14,
                Email = "ginger@gmail.com",
                Sex = PersonData.Gender.Famale
            });

            dataGridOfPeople.ItemsSource = listOfPeople;
            ComboBoxColumnSex.ItemsSource = Enum.GetValues(typeof(PersonData.Gender));
        }
    } 
}
