using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
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

namespace Adressbuch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            addContact add = new addContact();

            main.Content = add;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Möchten Sie wirklich diesen Kontakt löschen", "Kontakt löschen", MessageBoxButton.YesNo);
        }

        private void btnContacts_Click(object sender, RoutedEventArgs e)
        {
            contactPage con = new();

            main.Content = con;
        }

        private void btnCalender_Click(object sender, RoutedEventArgs e)
        {
            calender cal = new();

            main.Content = cal;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
