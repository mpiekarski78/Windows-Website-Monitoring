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
using System.Diagnostics;

//Formularz (MainForm) - głowny form - strona głowna
namespace Windows_Website_Monitoring
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> _websitesList = new Dictionary<string, string>();
        private System.Windows.Forms.Timer timer1;

        int layout = 0; //początkowy layout

        public MainForm()
        {
            InitializeComponent();

            buttonConfig.Image = IconChar.Cog.ToBitmap(30, Color.Black);
            buttonDetails.Image = IconChar.List.ToBitmap(30, Color.Black);
            buttonLayout.Image = IconChar.WindowMaximize.ToBitmap(30, Color.Black);
                     

        }

        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
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

        private async Task UpdateStatus(ListViewItem item) {
            bool urlStatus;
            string status;

            if (item.Text != "") {
                //checking websites

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(item.Text);
                request.Timeout = 15000;
                request.Method = "HEAD";

                System.Diagnostics.Stopwatch timer = new Stopwatch(); //response time
                timer.Start(); //response time

                List<Task> tasks = new List<Task>();
                tasks.Add(Task.Run(() =>
                {
                    try
                    {
                        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                        {
                            urlStatus = (response.StatusCode == HttpStatusCode.OK);
                        }
                    }
                    catch (WebException)
                    {
                        urlStatus = false;
                    }

                    timer.Stop(); //response time
                    TimeSpan ts = timer.Elapsed;  //response time
                    var elapsedTime = ts.ToString(@"ms\:ff");  //response time

                    if (urlStatus == true) {
                        status = "Online"; // Text
                        item.SubItems[3].Text = elapsedTime + " sec";
                    } else {
                        status = "Error"; // Text
                        item.SubItems[3].Text = "-" ;
                    }

                    item.SubItems[2].Text = status;

                    if (urlStatus == true) {
                        item.BackColor = Color.Green;
                        item.ForeColor = Color.White;
                    } else {
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.White;
                    }

                }));

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        status_check();
        }

        //pierwsze uruchomienie
        private void first_run()
        {
            if (listViewMain.Items.Count > 0)
            {
                foreach (ListViewItem item in listViewMain.Items)
                {
                    item.SubItems[2].Text = "Wait";
                    item.BackColor = Color.Yellow;
                    item.ForeColor = Color.Black;

                }
            }
        }


        // MainForm Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            listViewMain.Columns[0].Width = 0;

            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            PopulateWebsiteList();

            first_run(); //pierwsze sprawdzenie
            InitTimer(); //uruchomienie sprawdzania działania stron
       
        }

        //add rows - nowa metoda do dodawania nowych pozycji URL + name
        public void Add(string url, String name, string status, string response)
        {
            String[] row = { url, name, status, response };
            ListViewItem item = new ListViewItem(row);
            item.Name = url;

            listViewMain.Items.Add(item);
        }

        public void PopulateWebsiteList() {
            foreach (var website in _websitesList) {
                if (website.Key != "" && website.Value != "") {
                    String[] row = { website.Value, website.Key, "Wait","-"};
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
        private void buttonConfig_Click(object sender, EventArgs e) {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.InitializeForm(_websitesList);
            settingsForm.WebstitesListChanged += settingsForm_WebstitesListChanged;
            settingsForm.ShowDialog(); // Shows SettingsForm
        }

        void settingsForm_WebstitesListChanged(List<string> removedWebsites) {
            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            foreach (var removedWebsite in removedWebsites) {
                listViewMain.Items.RemoveByKey(removedWebsite);
            }

            foreach (var website in _websitesList) {
                if (!listViewMain.Items.ContainsKey(website.Value)) {
                    Add(website.Value, website.Key, "Wait","-");
                    UpdateStatus(listViewMain.Items[listViewMain.Items.IndexOfKey(website.Value)]);
                }
            }

        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            FormDetailedView formDetailedView = new FormDetailedView();
            formDetailedView.InitializeForm(_websitesList);
            formDetailedView.WebstitesListChanged += settingsForm_WebstitesListChanged;
            formDetailedView.ShowDialog(); // Shows SettingsForm
        }

        private void buttonLayout_Click(object sender, EventArgs e)
        {
            if (layout == 0)
            {
                // przekierowanie okienka na prawą stronię
                AppBarHelper.AppBarMessage = "Website Monitoring";
                AppBarHelper.SetAppBar(this, AppBarEdge.Right);
                layout = 1;
            }

            else if (layout == 1)
            {
                // przekierowanie okienka -reset
                AppBarHelper.AppBarMessage = "Website Monitoring";
                AppBarHelper.SetAppBar(this, AppBarEdge.None);
                
                layout = 0;
            }
        }
    }
}