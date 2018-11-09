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
        #region Private Members
        private Dictionary<string, string> _websitesList = new Dictionary<string, string>();
        private List<string> _removedWebsites = new List<string>();
        #endregion

        #region Public Events
        public event WebstitesListChangedHandler WebstitesListChanged;
        public delegate void WebstitesListChangedHandler(List<string> removedWebsites);
        #endregion

        #region Constructor
        public SettingsForm() {
            InitializeComponent();

            buttonAdd.Image = IconChar.Plus.ToBitmap(30, Color.Black);
            buttonRemove.Image = IconChar.Minus.ToBitmap(30, Color.Black);
            buttonSave.Image = IconChar.CheckSquare.ToBitmap(30, Color.Black);
            buttonCancel.Image = IconChar.Times.ToBitmap(30, Color.Black);
        }
        #endregion

        #region Public Methods
        public void InitializeForm(Dictionary<string, string> websitesList) {
            _websitesList = websitesList;
        }
        #endregion

        #region Private Methods
        //add rows - nowa metoda do dodawania nowych pozycji URL + name
        private void Add(string name, string url) {
            string[] row = { name, url };

            ListViewItem item = new ListViewItem(row);

            item.Name = name;
            item.Tag = url;

            listViewWebsites.Items.Add(item);
        } 
        #endregion

        #region Private Event Handlers
        //Load Form2
        private void SettingsForm_Load(object sender, EventArgs e) {
            //wczytanie danych z pliku
            {
                foreach (var website in _websitesList) {
                    if (website.Key != "" && website.Value != "") {
                        Add(website.Key, website.Value);
                    }
                }
            }
        }

        //Kliknięcie w przycisk "Add" powoduje dodanie pozycji z pól (textBox) textBoxNewUrl i textBoxWebsiteName
        private void buttonAdd_Click(object sender, EventArgs e) {
            if (Uri.IsWellFormedUriString(textBoxWebSiteUrl.Text, UriKind.Absolute)) {
                Add(textBoxWebsiteName.Text, textBoxWebSiteUrl.Text);

                //wyczyszczenie pól
                textBoxWebsiteName.Text = "";
                textBoxWebSiteUrl.Text = "";

                this.buttonSave.Enabled = true;
            } else {
                MessageBox.Show("Incorrect URL. Please verify the URL and try again.", "Error");
            }
        }

        //usuwanie pozycji po kliknięciu "Remove selected"
        private void buttonRemove_Click(object sender, EventArgs e) {
            if (listViewWebsites.SelectedItems.Count == 1) {
                _removedWebsites.Add(listViewWebsites.SelectedItems[0].Text.ToString());

                //usuwanie z boxa
                listViewWebsites.SelectedItems[0].Remove();
                this.buttonSave.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            //zapisywanie do pliku
            foreach (ListViewItem item in listViewWebsites.Items) {
                if (!ConfigManager.SettingExists(CustomConfigSections.Websites, item.Name))
                    ConfigManager.AddSetting(CustomConfigSections.Websites, item.Name, item.Tag.ToString());
            }

            //usuwanie z pliku
            foreach (var removedWebsite in _removedWebsites) {
                ConfigManager.RemoveSetting(CustomConfigSections.Websites, removedWebsite); 
            }

            this.WebstitesListChanged?.Invoke(_removedWebsites);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            if (this.buttonSave.Enabled) {
                if (MessageBox.Show("Your changes will be lost.\nPress OK to continue,\n or Cancel to stay on the current form.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK) {
                    this.Close();
                }
            } else
                this.Close();
        } 

        private void listViewWebsites_SelectedIndexChanged(object sender, EventArgs e) {
            if (listViewWebsites.SelectedItems.Count == 1)
                buttonRemove.Visible = true;
            else
                buttonRemove.Visible = false;
        }
        #endregion
    }
}