using System;
using System.IO;
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

            calender cal = new();

            contacts.Items.Clear();

            main.Content = cal;

            contact c = new();

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineteil = line.Split(';');

                    contacts.Items.Add(lineteil[1] + " " + lineteil[2] + "(" + lineteil[3] + ")");
                }
            }
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
            contacts.Items.Clear();

            contactPage contactP = new();

            contact c = new();

            main.Content = contactP;

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line= sr.ReadLine()) != null)
                {
                    string[] lineteil = line.Split(';');

                    contacts.Items.Add(lineteil[1] + " " + lineteil[2] +"(" + lineteil[0] + ")");
                }

                using StreamReader tr = File.OpenText(c.path);
                {
                    string lines = tr.ReadLine();

                    string[] lineteil = lines.Split(';');

                    contactP.Name.Content = lineteil[1] + " " + lineteil[2];
                                
                    contactP.NumorNN.Content = "Mitarbeiternummer oder Spitzname: " + lineteil[0];

                    contactP.Birthday.Content = "Geburtstag: " + lineteil[3];

                    contactP.Adress.Content = lineteil[4] + "," + lineteil[6] + "," + lineteil[5];

                    contactP.Number.Content = "Telefonnummer: " + lineteil[7];

                    contactP.Email.Content = "E-Mail-Adresse: " + lineteil[8];
                }
            }
        }

        private void btnCalender_Click(object sender, RoutedEventArgs e)
        {
            calender cal = new();

            contacts.Items.Clear();

            main.Content = cal;

            contact c = new();

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineteil = line.Split(';');

                    contacts.Items.Add(lineteil[1] + " " + lineteil[2] + "(" + lineteil[3] + ")");
                }
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            contacts.Items.Clear();

            contact c = new();

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineteil = line.Split(';');

                    if (lineteil[1] == searchName.Text || lineteil[2] == searchName.Text)
                    {
                        contacts.Items.Add(lineteil[1] + " " + lineteil[2] + "(" + lineteil[0] + ")");
                    }
                }
            }
        }

        private void contacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            contact c = new();

            string name = (string)contacts.SelectedItem;

            string[] namesplit = name.Split('(', ')', ' ');

            contactPage contactP = new();

            main.Content = contactP;

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineteil = line.Split(';');

                    if (lineteil[0] == namesplit[2] || lineteil[3] == namesplit[2])
                    {
                        contactP.Name.Content = lineteil[1] + " " + lineteil[2];

                        contactP.NumorNN.Content = "Mitarbeiternummer oder Spitzname: "+lineteil[0];

                        contactP.Birthday.Content = "Geburtstag: "+lineteil[3];

                        contactP.Adress.Content = lineteil[4] + "," + lineteil[6] + "," + lineteil[5];

                        contactP.Number.Content = "Telefonnummer: "+lineteil[7];

                        contactP.Email.Content = "E-Mail-Adresse: "+lineteil[8];
                    }
                }
            }

        }
    }
}
