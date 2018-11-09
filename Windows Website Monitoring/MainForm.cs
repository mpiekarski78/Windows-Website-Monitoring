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
using System.Runtime.InteropServices;

//Formularz (MainForm) - głowny form - strona głowna
namespace Windows_Website_Monitoring
{
    public partial class MainForm : Form, IMessageFilter {
        #region Imports
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture(); 
        #endregion

        #region Private Members
        private HashSet<Control> _controlsToMove = new HashSet<Control>();
        private Dictionary<string, string> _websitesList = new Dictionary<string, string>();
        private System.Windows.Forms.Timer _timer; 
        private LayoutTypes _layout = LayoutTypes.Standard; //początkowy layout
        #endregion

        #region Constructor
        public MainForm() {
            InitializeComponent();

            buttonConfig.Image = IconChar.Cog.ToBitmap(30, Color.Black);
            buttonDetails.Image = IconChar.List.ToBitmap(30, Color.Black);
            buttonLayout.Image = IconChar.WindowMaximize.ToBitmap(30, Color.Black);
            buttonExit.Image = IconChar.PowerOff.ToBitmap(30, Color.Black);

            Application.AddMessageFilter(this);

            _controlsToMove.Add(this);
            _controlsToMove.Add(this.labelTitleBar);
        }
        #endregion

        #region Public Methods
        public bool PreFilterMessage(ref Message m) {
            if (m.Msg == WM_LBUTTONDOWN && _controlsToMove.Contains(Control.FromHandle(m.HWnd))) {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }
        #endregion

        #region Private Methods
        //add rows - nowa metoda do dodawania nowych pozycji URL + name
        private void Add(string url, String name, string status, string response) {
            String[] row = { url, name, status, response };
            ListViewItem item = new ListViewItem(row);
            item.Name = url;

            listViewMain.Items.Add(item);
        }

        private void PopulateWebsiteList() {
            foreach (var website in _websitesList) {
                if (website.Key != "" && website.Value != "") {
                    String[] row = { website.Value, website.Key, "Wait", "-" };
                    ListViewItem item = new ListViewItem(row);

                    item.Name = website.Value;
                    item.SubItems[2].Text = "Wait";
                    item.BackColor = Color.Yellow;
                    item.ForeColor = Color.Black;

                    listViewMain.Items.Add(item);
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
            if (listViewMain.Items.Count > 0) {
                foreach (ListViewItem item in listViewMain.Items) {
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
                        item.SubItems[3].Text = elapsedTime + " sec";
                    } else {
                        status = "Error"; // Text
                        item.SubItems[3].Text = "-";
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
        #endregion

        #region Private Event Handlers
        private void MainForm_Load(object sender, EventArgs e) {
            Control.CheckForIllegalCrossThreadCalls = false;

            listViewMain.Columns[0].Width = 0;

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
            FormDetailedView formDetailedView = new FormDetailedView();
            formDetailedView.InitializeForm(_websitesList);
            formDetailedView.WebstitesListChanged += settingsForm_WebstitesListChanged;
            formDetailedView.ShowDialog(); // Shows SettingsForm
        }

        private void buttonLayout_Click(object sender, EventArgs e) {
            if (_layout == LayoutTypes.Standard) {
                // przekierowanie okienka na prawą stronię
                AppBarHelper.AppBarMessage = "Website Monitoring";
                AppBarHelper.SetAppBar(this, AppBarEdge.Right);

                _layout = LayoutTypes.Docked;
            } else if (_layout == LayoutTypes.Docked) {
                // przekierowanie okienka -reset
                AppBarHelper.AppBarMessage = "Website Monitoring";
                AppBarHelper.SetAppBar(this, AppBarEdge.None);

                _layout = LayoutTypes.Standard;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void settingsForm_WebstitesListChanged(List<string> removedWebsites) {
            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            foreach (var removedWebsite in removedWebsites) {
                listViewMain.Items.RemoveByKey(removedWebsite);
            }

            foreach (var website in _websitesList) {
                if (!listViewMain.Items.ContainsKey(website.Value)) {
                    Add(website.Value, website.Key, "Wait", "-");
                    UpdateStatus(listViewMain.Items[listViewMain.Items.IndexOfKey(website.Value)]);
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
        #endregion
    }
}