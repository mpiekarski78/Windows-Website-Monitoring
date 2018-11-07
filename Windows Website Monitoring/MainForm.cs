using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using tip2tail.WinFormAppBarLib;
using Windows_Website_Monitoring.Library;
using FontAwesome.Sharp;

//Formularz (MainForm) - głowny form - strona głowna
namespace Windows_Website_Monitoring
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> _websitesList = new Dictionary<string, string>();
        private System.Windows.Forms.Timer timer1;

        public MainForm()
        {
            InitializeComponent();

            pictureBoxConfiguration.Image = IconChar.Cog.ToBitmap(30, Color.Black);
        }

        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 20000; // in miliseconds
            timer1.Start();
        }

        private void status_check()
        {
            if (listViewMain.Items.Count > 0)
            {
                foreach (ListViewItem item in listViewMain.Items)
                {
                    UpdateStatus(item);
                }
            }
        }

        private void UpdateStatus(ListViewItem item) {
            bool urlStatus;
            string status;

            if (item.Text != "") {
                //checking websites

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(item.Text);
                request.Timeout = 15000;
                request.Method = "HEAD";
                try {
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                        urlStatus = (response.StatusCode == HttpStatusCode.OK);
                    }
                } catch (WebException) {
                    urlStatus = false;
                }

                if (urlStatus == true) {
                    status = "Online"; // Text
                } else {
                    status = "Error"; // Text
                }

                item.SubItems[2].Text = status;

                if (urlStatus == true) {
                    item.BackColor = Color.Green;
                    item.ForeColor = Color.White;
                } else {
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status_check();
        }

        // MainForm Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            // przekierowanie okienka na prawą stronię
            AppBarHelper.AppBarMessage = "TestAppBarApplication";
            AppBarHelper.SetAppBar(this, AppBarEdge.Right);

            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            PopulateWebsiteList();

            status_check(); //pierwsze sprawdzenie

            InitTimer(); //uruchomienie sprawdzania działania stron
        }

        //add rows - nowa metoda do dodawania nowych pozycji URL + name
        public void Add(string url, String name, string status)
        {
            String[] row = { url, name, status };
            ListViewItem item = new ListViewItem(row);
            item.Name = url;

            listViewMain.Items.Add(item);
        }

        public void PopulateWebsiteList() {
            foreach (var website in _websitesList) {
                if (website.Key != "" && website.Value != "") {
                    String[] row = { website.Value, website.Key, "Pending" };
                    ListViewItem item = new ListViewItem(row);
                    item.Name = website.Value;

                    listViewMain.Items.Add(item);
                }
            }
        }

        private void labelStatusOverview_Click(object sender, EventArgs e)
        {

        }

        //kliknięcie w obrazek (opcje) powoduje otwarcie nowego okna SettingsForm
        private void pictureBoxConfiguration_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.InitializeForm(_websitesList);
            settingsForm.WebstitesListChanged += settingsForm_WebstitesListChanged;
            settingsForm.Show(); // Shows SettingsForm
        }

        void settingsForm_WebstitesListChanged(List<string> removedWebsites) {
            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            foreach (var removedWebsite in removedWebsites) {
                listViewMain.Items.RemoveByKey(removedWebsite);
            }

            foreach (var website in _websitesList) {
                if (!listViewMain.Items.ContainsKey(website.Value)) {
                    Add(website.Value, website.Key, "Pending");
                    UpdateStatus(listViewMain.Items[listViewMain.Items.IndexOfKey(website.Value)]);
                }
            }

        }
    }
}