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
    public partial class AddContact : UserControl
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ContactPage contactP = new();

            Contact c = new();

            using (StreamReader sr = new(c.path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(Kennung.Text))
                    {
                        MessageBox.Show("Diese Mitarbeiternummer bzw. dieser Spitzname ist schon vergeben! Bitte geben Sie etwas anderes ein.", "Mitarbeiternummer/Spitzname vergeben", MessageBoxButton.OK);

                        Kennung.Clear();

                        Kennung.Focus();

                        return;
                    }
                    else if (line.Contains(Email.Text))
                    {
                        MessageBox.Show("Diese Email ist schon vergeben. Bitte geben Sie eine andere Email ein.", "Email vergeben", MessageBoxButton.OK);

                        Email.Clear();

                        Email.Focus();

                        return;
                    }
                }
            };

            string contactData = Kennung.Text+";"+Vorname.Text+";"+Nachname.Text+";"+Geburtstag.Text+";"+Adresse.Text+";"+Wohnort.Text+";"+Postleitzahl.Text+";"+Telefon.Text+";"+Email.Text;

            using (TextWriter sw = File.AppendText(c.path))
            {
                sw.WriteLine(contactData);
            }

            addC.Content = contactP.Content;
        }

        private void BtnBreak_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new();

            ContactPage contactP = new();

            Contact c = new();

            main.contactList.SelectedItem = null;

            addC.Content = contactP.Content;

            using StreamReader tr = File.OpenText(c.path);
            {
                string line = tr.ReadLine();

                string[] data = line.Split(';');

                contactP.Name.Content = data[1] + " " + data[2];

                contactP.NumOrNN.Content = "Mitarbeiternummer oder Spitzname: " + data[0];

                contactP.Birthday.Content = "Geburtstag: " + data[3];

                contactP.Adress.Content = data[4] + "," + data[6] + "," + data[5];

                contactP.Number.Content = "Telefonnummer: " + data[7];

                contactP.Email.Content = "E-Mail-Adresse: " + data[8];
            }
        }
    }
}
