﻿using System;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InkEditingModes inkEditing = new InkEditingModes();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = inkEditing;
        }

        private void select_Click(object sender, RoutedEventArgs e)
        {
            inkEditing.EditingMode = InkCanvasEditingMode.Select;
        }

        private void draw_Click(object sender, RoutedEventArgs e)
        {
            inkEditing.EditingMode = InkCanvasEditingMode.Ink;
        }
    }
}
