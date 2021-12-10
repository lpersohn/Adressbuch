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
    /// Interaktionslogik für editPage.xaml
    /// </summary>
    public partial class editPage : UserControl
    {
        public editPage()
        {
            InitializeComponent();

            MainWindow main = new();

            string name = (string)main.contacts.SelectedItem;

            string[] namesplit = name.Split('(', ')', ' ');

            contact c = new();

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineteil = line.Split(';');

                    if (lineteil[1] == namesplit[0])
                    {
                        NumorNN.Text = lineteil[0];

                        Vorname.Text = lineteil[1];

                        Nachname.Text = lineteil[2];

                        Birthday.Text = lineteil[3];

                        Adress.Text = lineteil[4];

                        Wohnort.Text = lineteil[5];

                        PLZ.Text = lineteil[6];

                        Number.Text = lineteil[7];

                        Email.Text = lineteil[8];
                    }
                }
            }
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
