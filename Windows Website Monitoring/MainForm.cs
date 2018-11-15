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
using System.Configuration;
using tip2tail.WinFormAppBarLib;
using Windows_Website_Monitoring.Library;
using FontAwesome.Sharp;
using System.Diagnostics;
using System.Net.Http;

//NOTE: Main form (MainForm) - main app screen
namespace Windows_Website_Monitoring
{
    public partial class MainForm : BaseForm {
        #region Private Members
        private HashSet<Control> _controlsToMove = new HashSet<Control>();
        private Dictionary<string, string> _websitesList = new Dictionary<string, string>();
        private Timer _timer; 
        private LayoutTypes _layout = LayoutTypes.Standard; //NOTE: initial layout
        public static List<EventDetail> _eventDetailsList = new List<EventDetail>();
        public static List<FullDetail> _fullDetailsList = new List<FullDetail>(); //NOTE: MainForm -> DetailsViewForm
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
        //NOTE: add rows - add new items to the listView
        private void Add(string name, string url) {
            String[] row = { name, "Wait", "-" };

            ListViewItem item = new ListViewItem(row);

            item.Name = name;
            item.Tag = url;

            item.BackColor = Color.Yellow;
            item.ForeColor = Color.Black;

            listViewWebsites.Items.Add(item);
        }

        private void AddToEvents(string name, string url, string error)
        {
            string[] row = { name, error, "1" };

            ListViewItem item = new ListViewItem(row);

            item.Tag = url;

            item.Name = name;

            if (error == "404")
            {
                item.BackColor = Color.DodgerBlue;
                item.ForeColor = Color.White;
            }
            else
            {
                item.BackColor = Color.OrangeRed;
                item.ForeColor = Color.White;
            }
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
            _timer = new Timer();
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Interval = 2000; //NOTE: in miliseconds
            _timer.Start();
        }

        private void CheckStatus() {
            if (listViewWebsites.Items.Count > 0) {
                foreach (ListViewItem item in listViewWebsites.Items) {
                     UpdateStatus(item);  //TODO: (optional) async wasn't working the wait it suppose to. 
                }
            }
        }

        private async Task UpdateStatus(ListViewItem item) {
            HttpStatusCode statusCode = HttpStatusCode.NotImplemented;
            string statusDescription = "";
            bool errorOccured = false;
            DateTime eventTime = DateTime.MinValue;

            if (item.Text != "")
            {
                Stopwatch timer = new Stopwatch(); //NOTE: for the response time 
                timer.Start(); //NOTE: for the response time (START)

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.Timeout = TimeSpan.FromMilliseconds(10000);
                        HttpResponseMessage response = await client.GetAsync(item.Tag.ToString());

                        statusCode = response.StatusCode;
                        LogSiteInfo(item, statusCode);
                        statusDescription = statusCode.ToString();
                    }
                }

                //NOTE: timeout is not propagated as TimeoutException, but as TaskCanceledException.
                catch (TaskCanceledException e)
                {
                    //NOTE: handle somehow
                    //DEBUG: Console.WriteLine("TaskCanceledException");
                    LogSiteWarning(item, e);
                    statusCode = HttpStatusCode.GatewayTimeout;
                    statusDescription = "Timeout";
                }
                catch (HttpRequestException e)
                {
                    //DEBUG: Console.WriteLine("HttpRequestException");
                    LogSiteError(item, e, true);
                    statusCode = HttpStatusCode.BadGateway;
                    statusDescription = "Down";
                }

                timer.Stop(); //NOTE: for the response time (END)
                TimeSpan ts = timer.Elapsed;  //NOTE: from the response time
                var elapsedTime = $"{ts.ToString(@"ms\:ff")} sec";  //NOTE: from the response time

                switch (statusCode) {
                    case HttpStatusCode.OK: {
                            statusDescription = "Online";
                            
                            item.BackColor = Color.Green;
                            item.ForeColor = Color.White;

                            break;
                        }
                    case HttpStatusCode.NotFound: {
                            statusDescription = "404";

                            item.BackColor = Color.DodgerBlue;
                            item.ForeColor = Color.White;

                            errorOccured = true;
                            eventTime = DateTime.Now;

                            break;
                        }
                    default: {
                            statusDescription = "Down";
                            elapsedTime = "-";

                            item.BackColor = Color.OrangeRed;
                            item.ForeColor = Color.White;

                            errorOccured = true;
                            eventTime = DateTime.Now;

                            break;
                        }
                }

                item.SubItems[1].Text = statusDescription;
                item.SubItems[2].Text = elapsedTime;

                if (errorOccured) {
                    _eventDetailsList.Add(new EventDetail {
                        WebsiteName = item.SubItems[0].Text,
                        Description = $"{statusDescription} ({statusCode})",
                        EventTime = eventTime
                    });

                    if (listViewEvents.Items.Count == 0) {
                        AddToEvents(item.SubItems[0].Text, item.SubItems[1].Text, statusDescription);
                    } else {
                        if (listViewEvents.Items.ContainsKey(item.SubItems[0].Text)) {
                            var eventItemIndex = listViewEvents.Items.IndexOfKey(item.SubItems[0].Text);
                            var eventItem = listViewEvents.Items[eventItemIndex];
                            int eventNum = Int32.Parse(eventItem.SubItems[2].Text) + 1;

                            eventItem.SubItems[2].Text = eventNum.ToString();
                        } else {
                            AddToEvents(item.SubItems[0].Text, item.SubItems[1].Text, statusDescription);
                        }
                    }
                    
                }

                //NOTE: Add to _fullDetailsList
                _fullDetailsList.Add(new FullDetail
                {
                    WebsiteUrl = item.Tag.ToString(),
                    WebsiteName = item.SubItems[0].Text,
                    WebsiteStatus = statusDescription,
                    WebsiteResponse = elapsedTime
                });

                

            }

            //NOTE: open the event window if any item is selected 
            if (listViewEvents.SelectedItems.Count > 0)
            {
                checkSelected = listViewEvents.SelectedItems[0].ToString();
                //DEBUG: Console.WriteLine(checkSelected);
                EventTime eventTimeForm = new EventTime();
                listViewEvents.SelectedItems.Clear();
                                
                eventTimeForm.ShowDialog(this); //NOTE: Open EventTime Form

                checkSelected = "";
            }
        }

        private void LogSiteInfo(ListViewItem item, HttpStatusCode httpStatusCode) {
            LogManager.LogInformation($"{item.Text} ({item.Tag.ToString()}) - {httpStatusCode.ToString()}");
        }

        private void LogSiteWarning(ListViewItem item, Exception exception) {
            LogManager.LogWarning($"Site {item.Text}({item.Tag.ToString()}) logged {exception.GetType()}: {exception.Message} ---> {exception.InnerException?.GetType()}: {exception.InnerException?.Message}");
        }

        private void LogSiteError(ListViewItem item, Exception exception, bool includeExceptionDetails = false) {
            if (includeExceptionDetails) {
                LogManager.LogError($"{item.Text} ({item.Tag.ToString()}) logged {exception.GetType()}: {exception.Message} ---> {exception.InnerException?.GetType()}: {exception.InnerException?.Message}", exception); 
            } else {
                LogManager.LogError($"{item.Text} ({item.Tag.ToString()}) logged {exception.GetType()}: {exception.Message} ---> {exception.InnerException?.GetType()}: {exception.InnerException?.Message}");
            }
        }
        #endregion

        #region Private Event Handlers
        private void MainForm_Load(object sender, EventArgs e) {
            Control.CheckForIllegalCrossThreadCalls = false;

            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            PopulateWebsiteList();

            InitTimer(); //NOTE: checking websites in a loop
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (_layout == LayoutTypes.Docked) {
                AppBarHelper.SetAppBar(this, AppBarEdge.None);
            }
        }

        private void buttonConfig_Click(object sender, EventArgs e) {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.InitializeForm(_websitesList);
            settingsForm.WebstitesListChanged += settingsForm_WebstitesListChanged;
            settingsForm.ShowDialog(); //NOTE: open SettingsForm
        }

        private void buttonDetails_Click(object sender, EventArgs e) {
            DetailViewForm detailViewForm = new DetailViewForm();
            detailViewForm.InitializeForm(_websitesList);
            detailViewForm.WebstitesListChanged += settingsForm_WebstitesListChanged;
            detailViewForm.ShowDialog(); //NOTE: open Detailed View Form
        }

        private void buttonLayout_Click(object sender, EventArgs e) {
            var prevLayout = _layout;
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

            LogManager.LogDebug($"Changed layout from {prevLayout.ToString()} to {_layout.ToString()}");
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void settingsForm_WebstitesListChanged(List<string> removedWebsites) {
            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            foreach (var removedWebsite in removedWebsites) {
                listViewWebsites.Items.RemoveByKey(removedWebsite);
            }

            foreach (var website in _websitesList) {
                if (!listViewWebsites.Items.ContainsKey(website.Key)) {
                    Add(website.Key, website.Value);
                    await UpdateStatus(listViewWebsites.Items[listViewWebsites.Items.IndexOfKey(website.Key)]);
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

        private void labelTitleBar_Click(object sender, EventArgs e)
        {

        }
    }
}