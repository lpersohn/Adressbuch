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
    public partial class EditPage : UserControl
    {
        public EditPage()
        {
            InitializeComponent();
        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            List<string[]> contacts = new();

            ContactPage contactP = new();

            MainWindow main = new();

            Contact c = new();

            int counter = 0;

            string contact = NumorNN.Text + ";" + Vorname.Text + ";" + Nachname.Text + ";" + Birthday.Text + ";" + Adress.Text + ";" + Wohnort.Text + ";" + PLZ.Text + ";" + Number.Text + ";" + Email.Text;

            string[] cont = contact.Split(';');

            using StreamReader str = File.OpenText(c.path);
            {
                string line;

                while ((line = str.ReadLine()) != null)
                {
                    string[] data = line.Split(';');

                    contacts.Add(data);

                    counter++;
                }

                for (int i = 0; i < counter; i++)
                {
                    if (contacts[i][0] == NumorNN.Text)
                    {
                        contacts[i] = cont;
                    }
                }
            }

            str.Close();

            using StreamWriter sw = new(c.path);
            {
                foreach (string[] con in contacts)
                {
                    sw.WriteLine(con[0] + ";" + con[1] + ";" + con[2] + ";" + con[3] + ";" + con[4] + ";" + con[5] + ";" + con[6] + ";" + con[7] + ";" + con[8]);
                }
            }

            sw.Close();

            main.contactList.SelectedItem = null;

            editP.Content = contactP.Content;

            using StreamReader sr = File.OpenText(c.path);
            {
                string lines = sr.ReadLine();

                string[] datas = lines.Split(';');

                contactP.Name.Content = datas[1] + " " + datas[2];

                contactP.NumOrNN.Content = "Mitarbeiternummer oder Spitzname: " + datas[0];

                contactP.Birthday.Content = "Geburtstag: " + datas[3];

                contactP.Adress.Content = datas[4] + "," + datas[6] + "," + datas[5];

                contactP.Number.Content = "Telefonnummer: " + datas[7];

                contactP.Email.Content = "E-Mail-Adresse: " + datas[8];
            }
        }

        private void BtnBreak_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new();

            ContactPage contactP = new();

            Contact c = new();

            main.contactList.SelectedItem = null;

            editP.Content = contactP.Content;

            using StreamReader sr = File.OpenText(c.path);
            {
                string lines = sr.ReadLine();

                string[] data = lines.Split(';');

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
