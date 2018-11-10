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
    public partial class MainForm : BaseForm {
        #region Private Members
        private HashSet<Control> _controlsToMove = new HashSet<Control>();
        private Dictionary<string, string> _websitesList = new Dictionary<string, string>();
        private System.Windows.Forms.Timer _timer; 
        private LayoutTypes _layout = LayoutTypes.Standard; //początkowy layout
        public List<KeyValuePair<string, string>> eventTime = new List<KeyValuePair<string, string>>();
        public string checkSelected;
        #endregion


        #region Constructor
        public MainForm() {
            InitializeComponent();

            buttonConfig.Image = IconChar.Cog.ToBitmap(30, Color.Black);
            buttonDetails.Image = IconChar.List.ToBitmap(30, Color.Black);
            buttonLayout.Image = IconChar.WindowMaximize.ToBitmap(30, Color.Black);
            buttonExit.Image = IconChar.PowerOff.ToBitmap(30, Color.Black);

            this.AddMoveEnabledControl(this.labelTitleBar);


        }
        #endregion
     
        #region Private Methods
        //add rows - nowa metoda do dodawania nowych pozycji URL + name
        private void Add(String name, string url) {
            String[] row = { name, "Wait", "-" };

            ListViewItem item = new ListViewItem(row);

            item.Name = name;
            item.Tag = url;

            item.BackColor = Color.Yellow;
            item.ForeColor = Color.Black;

            listViewWebsites.Items.Add(item);
        }


        private void AddToEvents(string name, string url, string error, string eventsNum)
        {
            String[] row = { name, error, eventsNum };

            ListViewItem item = new ListViewItem(row);

            item.Tag = url;

            item.Name = name;
            item.Name = error;
            item.Name = eventsNum;
            

            item.BackColor = Color.Yellow;
            item.ForeColor = Color.Black;
            
            listViewEvents.Items.Add(item);
        }


        private void PopulateWebsiteList() {
            foreach (var website in _websitesList) {
                if (website.Key != "" && website.Value != "") {
                    String[] row = { website.Key, "Wait", "-" };
                    ListViewItem item = new ListViewItem(row);

                    item.Name = website.Key;
                    item.Tag = website.Value;

                    item.SubItems[1].Text = "Wait";
                    item.BackColor = Color.Yellow;
                    item.ForeColor = Color.Black;

                    listViewWebsites.Items.Add(item);
                }
            }
        }

        private void InitTimer() {
            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Interval = 2000; // in miliseconds
            _timer.Start();
        }

        private void CheckStatus() {
            if (listViewWebsites.Items.Count > 0) {
                foreach (ListViewItem item in listViewWebsites.Items) {
                    UpdateStatus(item);
                }
            }
        }

        private async Task UpdateStatus(ListViewItem item) {
            bool urlStatus;
            string status;

            if (item.Text != "") {
                //checking websites

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(item.Tag.ToString());
                request.Timeout = 15000;
                request.Method = "HEAD";

                System.Diagnostics.Stopwatch timer = new Stopwatch(); //response time
                timer.Start(); //response time

                List<Task> tasks = new List<Task>();
                tasks.Add(Task.Run(() => {
                    try {
                        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                            urlStatus = (response.StatusCode == HttpStatusCode.OK);
                        }
                    } catch (WebException) {
                        urlStatus = false;
                    }

                    timer.Stop(); //response time
                    TimeSpan ts = timer.Elapsed;  //response time
                    var elapsedTime = ts.ToString(@"ms\:ff");  //response time

                    if (urlStatus == true) {
                        status = "Online"; // Text
                        item.SubItems[2].Text = elapsedTime + " sec";
                    } else {
                        status = "Error"; // Text
                        item.SubItems[2].Text = "-";

                        //add time to eventTime list
                        eventTime.Add(new KeyValuePair<string, string>(item.SubItems[0].Text, DateTime.Now.ToString()));

                        //check if error exists
                        if (listViewEvents.Items.Count == 0)
                        {
                            AddToEvents(item.SubItems[0].Text, item.SubItems[1].Text, status, "1");

                        }
                        else
                        {
                        foreach (ListViewItem i in listViewEvents.Items)
                        {


                            if (!(item.SubItems[0].Text).Equals(i.SubItems[0].Text))
                            {
                                    // Console.WriteLine("Nowe:" + item.SubItems[0].Text.Trim() + item.SubItems[0].Text.Trim().Length + i.SubItems[0].Text.Trim() + i.SubItems[0].Text.Trim().Length);
                                     //AddToEvents(item.SubItems[0].Text, item.SubItems[1].Text, status, "1"); //BUGGG
                                    

                                }
                                else
                                {
                                    int eventNum = Int32.Parse(i.SubItems[2].Text) + 1 ;
                                    i.SubItems[2].Text = eventNum.ToString();
                                    
                                }
                            }
                        }

                    }

                    item.SubItems[1].Text = status;

                    if (urlStatus == true) {
                        item.BackColor = Color.Green;
                        item.ForeColor = Color.White;
                    } else {
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.White;
                    }

                }));

            }


            //otwieranie okienka jeżeli zaznaczony event
            checkSelected = listViewEvents.SelectedItems[0].ToString();
            if (checkSelected != null)
            {
                // Console.WriteLine(checkSelected);
                EventTime eventTimeForm = new EventTime();
                listViewEvents.SelectedItems.Clear();
                                
                eventTimeForm.ShowDialog(this); // Shows Event Time Form

                checkSelected = "";
                

            }
            


        }
        #endregion



        #region Private Event Handlers
        private void MainForm_Load(object sender, EventArgs e) {
            Control.CheckForIllegalCrossThreadCalls = false;

            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            PopulateWebsiteList();

            InitTimer(); //uruchomienie sprawdzania działania stron

        }

        private void buttonConfig_Click(object sender, EventArgs e) {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.InitializeForm(_websitesList);
            settingsForm.WebstitesListChanged += settingsForm_WebstitesListChanged;
            settingsForm.ShowDialog(); // Shows SettingsForm
        }

        private void buttonDetails_Click(object sender, EventArgs e) {
            DetailVewForm detailViewForm = new DetailVewForm();
            detailViewForm.InitializeForm(_websitesList);
            detailViewForm.WebstitesListChanged += settingsForm_WebstitesListChanged;
            detailViewForm.ShowDialog(); // Shows Detailed View Form
        }

        private void buttonLayout_Click(object sender, EventArgs e) {
            Console.WriteLine(_layout);
            if (_layout == LayoutTypes.Standard) {
                // przekierowanie okienka na prawą stronię
                this.ShowInTaskbar = false;
                AppBarHelper.AppBarMessage = "Website Monitoring";
                AppBarHelper.SetAppBar(this, AppBarEdge.Right);

                
                
                _layout = LayoutTypes.Docked;

            } else if (_layout == LayoutTypes.Docked) {
                // przekierowanie okienka -reset
                this.ShowInTaskbar = true;
                AppBarHelper.AppBarMessage = "Website Monitoring";
                AppBarHelper.SetAppBar(this, AppBarEdge.None);

                

                _layout = LayoutTypes.Standard;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            //reset pozycji przed zamknięciem
            if (_layout == LayoutTypes.Docked)
            {
             
                 AppBarHelper.SetAppBar(this, AppBarEdge.None);
            }
                this.Close();
        }

        private void settingsForm_WebstitesListChanged(List<string> removedWebsites) {
            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            foreach (var removedWebsite in removedWebsites) {
                listViewWebsites.Items.RemoveByKey(removedWebsite);
            }

            foreach (var website in _websitesList) {
                if (!listViewWebsites.Items.ContainsKey(website.Key)) {
                    Add(website.Key, website.Value);
                    UpdateStatus(listViewWebsites.Items[listViewWebsites.Items.IndexOfKey(website.Key)]);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            CheckStatus();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void listViewWebsites_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) {
            ListViewExtensions.ListView_DrawColumnHeader(this.listViewWebsites, sender, e);
        }

        private void listViewWebsites_DrawItem(object sender, DrawListViewItemEventArgs e) {
            ListViewExtensions.ListView_DrawItem(sender, e);
        }

        private void listViewWebsites_DrawSubItem(object sender, DrawListViewSubItemEventArgs e) {
            ListViewExtensions.ListView_DrawSubItem(sender, e);
        }

        private void listViewEvents_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) {
            ListViewExtensions.ListView_DrawColumnHeader(this.listViewEvents, sender, e);
        }

        private void listViewEvents_DrawItem(object sender, DrawListViewItemEventArgs e) {
            ListViewExtensions.ListView_DrawItem(sender, e);
        }

        private void listViewEvents_DrawSubItem(object sender, DrawListViewSubItemEventArgs e) {
            ListViewExtensions.ListView_DrawSubItem(sender, e);
        }
        #endregion
    }
}