using System;
using System.IO;
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

            contact c = new();

            string con = Kennung.Text+";"+Vorname.Text+";"+Nachname.Text+";"+Geburtstag.Text+";"+Adresse.Text+";"+Wohnort.Text+";"+Postleitzahl.Text+";"+Telefon.Text+";"+Email.Text;

            using (TextWriter sw = File.AppendText(c.path))
            {
                sw.WriteLine(con);
            }

            addC.Content = contactP.Content;
        }

        private void btnBreak_Click(object sender, RoutedEventArgs e)
        {
            contactPage contactP = new();

            addC.Content = contactP.Content;
        }
    }
}
