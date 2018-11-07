using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Website_Monitoring.Library;


//Formularz (Form2) - otwiera konfigurację stron URLs+names. Dodawanie i usuwanie

namespace Windows_Website_Monitoring
{
    public partial class SettingsForm : Form
    {
        private Dictionary<string, string> _websitesList = new Dictionary<string, string>();
        private List<string> _removedWebsites = new List<string>();

        public event WebstitesListChangedHandler WebstitesListChanged;
        public delegate void WebstitesListChangedHandler(List<string> removedWebsites);

        Form originalForm;

        public SettingsForm() {
            InitializeComponent();

            pictureBoxApply.Image = IconChar.CheckSquare.ToBitmap(60, Color.Black);
        }

        public void InitializeForm(Dictionary<string, string> websitesList) {
            _websitesList = websitesList;
        }

        //zamykanie okineka przez kliknięcie na image (na dole strony po prawej stronie)
        private void pictureBoxApply_Click(object sender, EventArgs e)
        {
            this.WebstitesListChanged?.Invoke(_removedWebsites);

            this.Close();
        }

        //Load Form2
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //wczytanie danych z pliku
            {
                foreach (var website in _websitesList)
                {
                    if (website.Key != "" && website.Value != "")
                    {
                        Add(website.Value, website.Key);
                    }
                }
            }
        }

        //add rows - nowa metoda do dodawania nowych pozycji URL + name
        public void Add(string url, String name)
        {
            String[] row = { url, name };
            ListViewItem item = new ListViewItem(row);

            listViewWebsites.Items.Add(item);
        }

        //Kliknięcie w przycisk "Add" powoduje dodanie pozycji z pól (textBox) textBoxNewUrl i textBoxWebsiteName
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(textBoxNewUrl.Text, UriKind.Absolute))
            {

                Add(textBoxNewUrl.Text, textBoxWebsiteName.Text);

                //zapisywanie do pliku
                ConfigManager.AddSetting(CustomConfigSections.Websites, textBoxWebsiteName.Text, textBoxNewUrl.Text);

                //wyczyszczenie pól
                textBoxNewUrl.Text = "";
                textBoxWebsiteName.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrect URL. Please verify the URL and try again.",  "Error");
            }
        }

        //usuwanie pozycji po kliknięciu "Remove selected"
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewWebsites.SelectedItems.Count == 1) {
                _removedWebsites.Add(listViewWebsites.SelectedItems[0].Text.ToString());

                //usuwanie z pliku
                ConfigManager.RemoveSetting(CustomConfigSections.Websites, listViewWebsites.SelectedItems[0].SubItems[1].Text.ToString());

                //usuwanie z boxa
                listViewWebsites.SelectedItems[0].Remove();
            }
        }
    }
}