using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfTemplateExamples
{
    /// <summary>
    /// Логика взаимодействия для Example1.xaml
    /// </summary>
    public partial class Example1 : Window
    {
        public Example1()
        {
            InitializeComponent();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["ToggleEnabled"] = !(sender as CheckBox).IsChecked;
        }
    }
}
