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
    /// Interaktionslogik für editPage.xaml
    /// </summary>
    public partial class editPage : UserControl
    {
        public editPage()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            contactPage contactP = new();

            editP.Content = contactP.Content;
        }

        private void btnBreak_Click(object sender, RoutedEventArgs e)
        {
            contactPage contactP = new();

            editP.Content = contactP.Content;
        }
    }
}
