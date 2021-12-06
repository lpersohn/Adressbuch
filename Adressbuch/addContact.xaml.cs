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

namespace Adressbuch
{
    /// <summary>
    /// Interaktionslogik für addContact.xaml
    /// </summary>
    public partial class addContact : UserControl
    {
        public addContact()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            contactPage contactP = new();

            addC.Content = contactP.Content;
        }

        private void btnBreak_Click(object sender, RoutedEventArgs e)
        {
            contactPage contactP = new();

            addC.Content = contactP.Content;
        }
    }
}
