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
    /// Interaktionslogik für contactPage.xaml
    /// </summary>
    public partial class ContactPage : UserControl
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Contact c = new();

            EditPage editP = new();

            contactP.Content = editP.Content;

            using StreamReader sr = File.OpenText(c.path);
            {
                string data;

                while ((data = sr.ReadLine()) != null)
                {
                    string[] dataSplit = data.Split(';');

                    if ((string)NumOrNN.Content == dataSplit[0])
                    {
                        editP.NumorNN.Text = dataSplit[0];

                        editP.Vorname.Text = dataSplit[1];

                        editP.Nachname.Text = dataSplit[2];

                        editP.Birthday.Text = dataSplit[3];

                        editP.Adress.Text = dataSplit[4];

                        editP.Wohnort.Text = dataSplit[5];

                        editP.PLZ.Text = dataSplit[6];

                        editP.Number.Text = dataSplit[7];

                        editP.Email.Text = dataSplit[8];
                    }
                }
            }
        }
    }
}
