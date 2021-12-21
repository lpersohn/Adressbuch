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
        public string data;

        public MainWindow()
        {
            InitializeComponent();

            Calender cal = new();

            Contact c = new();

            main.Content = cal;

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');

                    contactList.Items.Add(data[1] + " " + data[2] + "(" + data[3] + ")");
                }
            }

            contactList.Items.SortDescriptions.Add(new SortDescription("", ListSortDirection.Ascending));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddContact add = new();

            main.Content = add;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var Result = MessageBox.Show("Möchten Sie wirklich den ausgewählten Kontakt löschen?", "Kontakt löschen?", MessageBoxButton.YesNo);

            if (Result == MessageBoxResult.Yes)
            {
                List<string[]> contacts = new();

                Contact c = new();

                int counter = 0;

                using StreamReader sr = File.OpenText(c.path);
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(';');

                        contacts.Add(data);

                        counter++;
                    }

                    for (int i = 0; i < counter;)
                    {
                        if (contacts[i][0] == data)
                        {
                            contacts.RemoveAt(i);

                            counter--;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    sr.Close();

                    using StreamWriter sw = new(c.path);
                    {
                        foreach (string[] con in contacts)
                        {
                            sw.WriteLine(con[0] + ";" + con[1] + ";" + con[2] + ";" + con[3] + ";" + con[4] + ";" + con[5] + ";" + con[6] + ";" + con[7] + ";" + con[8]);
                        }
                    }

                    sw.Close();
                }

                MessageBox.Show("Der Kontakt wurde gelöscht", "Kontakt gelöscht!", MessageBoxButton.OK);
            }
        }

        private void BtnContacts_Click(object sender, RoutedEventArgs e)
        {
            ContactPage contactP = new();

            Contact c = new();

            main.Content = contactP.contactP;

            contactList.Items.Clear();

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');

                    contactList.Items.Add(data[1] + " " + data[2] + "(" + data[0] + ")");
                }

                using StreamReader tr = File.OpenText(c.path);
                {
                    string lines = tr.ReadLine();

                    string[] data = lines.Split(';');

                    contactP.Name.Content = data[1] + " " + data[2];

                    contactP.NumOrNN.Content = data[0];

                    contactP.Birthday.Content = "Geburtstag: " + data[3];

                    contactP.Adress.Content = data[4] + "," + data[6] + "," + data[5];

                    contactP.Number.Content = "Telefonnummer: " + data[7];

                    contactP.Email.Content = "E-Mail-Adresse: " + data[8];
                }
            }

            contactList.Items.SortDescriptions.Add(new SortDescription("", ListSortDirection.Ascending));
        }

        private void BtnCalender_Click(object sender, RoutedEventArgs e)
        {
            Calender cal = new();

            contactList.Items.Clear();

            main.Content = cal;

            Contact c = new();

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');

                    contactList.Items.Add(data[1] + " " + data[2] + "(" + data[3] + ")");
                }
            }
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            contactList.Items.Clear();

            Contact c = new();

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');

                    if (data[0].ToLower() == searchName.Text.ToLower() || data[1].ToLower() == searchName.Text.ToLower() || data[2].ToLower() == searchName.Text.ToLower() || data[3] == searchName.Text || data[4].ToLower() == searchName.Text.ToLower() || data[5].ToLower() == searchName.Text.ToLower() || data[6] == searchName.Text || data[7] == searchName.Text || data[8].ToLower() == searchName.Text.ToLower())
                    {
                        contactList.Items.Add(data[1] + " " + data[2] + "(" + data[0] + ")");
                    }
                    else if (searchName.Text == "")
                    {
                        contactList.Items.Add(data[1] + " " + data[2] + "(" + data[0] + ")");
                    }
                }
            }

            contactList.Items.SortDescriptions.Add(new SortDescription("", ListSortDirection.Ascending));
        }

        private void SearchName_TouchEnter(object sender, TouchEventArgs e)
        {
            contactList.Items.Clear();

            Contact c = new();

            using StreamReader sr = File.OpenText(c.path);
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');

                    if (data[0].ToLower() == searchName.Text.ToLower() || data[1].ToLower() == searchName.Text.ToLower() || data[2].ToLower() == searchName.Text.ToLower() || data[3] == searchName.Text || data[4].ToLower() == searchName.Text.ToLower() || data[5].ToLower() == searchName.Text.ToLower() || data[6] == searchName.Text || data[7] == searchName.Text || data[8].ToLower() == searchName.Text.ToLower())
                    {
                        contactList.Items.Add(data[1] + " " + data[2] + "(" + data[0] + ")");
                    }
                    else if (searchName.Text == "")
                    {
                        contactList.Items.Add(data[1] + " " + data[2] + "(" + data[0] + ")");
                    }
                }
            }

            contactList.Items.SortDescriptions.Add(new SortDescription("", ListSortDirection.Ascending));
        }

        private void Contacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact c = new();

            ContactPage contactP = new();

            if (contactList.SelectedItem != null)
            {
                string name = (string)contactList.SelectedItem;

                string[] dataSplit = name.Split('(', ')', ' ');

                main.Content = contactP;

                using StreamReader sr = File.OpenText(c.path);
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] contact = line.Split(';');

                        if (contact[0] == dataSplit[2])
                        {
                            contactP.Name.Content = contact[1] + " " + contact[2];

                            contactP.NumOrNN.Content = contact[0];

                            contactP.Birthday.Content = "Geburtstag: " + contact[3];

                            contactP.Adress.Content = contact[4] + "," + contact[6] + "," + contact[5];

                            contactP.Number.Content = "Telefonnummer: " + contact[7];

                            contactP.Email.Content = "E-Mail-Adresse: " + contact[8];

                            data = contact[0];

                            contactList.Items.SortDescriptions.Add(new SortDescription("", ListSortDirection.Ascending));
                        }
                        else if (contact[3] == dataSplit[2])
                        {
                            contactP.Name.Content = contact[1] + " " + contact[2];

                            contactP.NumOrNN.Content = contact[0];

                            contactP.Birthday.Content = "Geburtstag: " + contact[3];

                            contactP.Adress.Content = contact[4] + "," + contact[6] + "," + contact[5];

                            contactP.Number.Content = "Telefonnummer: " + contact[7];

                            contactP.Email.Content = "E-Mail-Adresse: " + contact[8];

                            data = contact[0];
                        }
                    }
                }
            }
        }
    }
}