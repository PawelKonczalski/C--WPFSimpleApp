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

namespace DataTriggers
{
    /// <summary>
    /// Interaction logic for ImagesWithTitles.xaml
    /// </summary>
    public partial class ImagesWithTitles : UserControl
    {
        private double szerokosc;
        public double Szerokosc
        {
            get
            {
                return szerokosc;
            }
            set
            {               
                szerokosc = value;
                this.Width = szerokosc / 2;
            }
        }
    
        public List<MyImages> ImagesSource
        {
            get
            {
                return (List<MyImages>)GetValue(ImagesSourceProperty);
            }
            set
            {
                SetValue(ImagesSourceProperty, value);
            }
        }

        public static readonly DependencyProperty ImagesSourceProperty =
            DependencyProperty.Register(
            "ImagesSource", //tu powinna być nazwa property
            typeof(List<MyImages>),
            typeof(ImagesWithTitles),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback((s,e) =>
            {
                var source = s as ImagesWithTitles;

                source.itemsControl.ItemsSource = (List<MyImages>)e.NewValue;
            }
             ))
            );

        

        public ImagesWithTitles()
        {
            InitializeComponent();
           
        }
    }
}
