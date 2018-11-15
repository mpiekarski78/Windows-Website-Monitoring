using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Windows_Website_Monitoring.Library;
using ARSoft.Tools.Net.Dns;
using ARSoft.Tools.Net;
using Whois;
using System.IO;

namespace Windows_Website_Monitoring
{
    public partial class DetailViewForm : Form
    {

        private Dictionary<string, string> _websitesList = new Dictionary<string, string>();
        private List<string> _removedWebsites = new List<string>();

        public event WebstitesListChangedHandler WebstitesListChanged;
        public delegate void WebstitesListChangedHandler(List<string> removedWebsites);

        string checkSelected;
        string ip;

        public DetailViewForm()
        {
            InitializeComponent();
        }

        public void InitializeForm(Dictionary<string, string> websitesList)
        {
            _websitesList = websitesList;
        }

        public void InitTimer()
        {
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; //NOTE: in miliseconds
            timer1.Start();
        }

        private void status_check()
        {

            if (listViewMain.Items.Count > 0)
            {
                foreach (ListViewItem item in listViewMain.Items)
                {
                    getFullDetails(item); 
                }
                

            }
        }

        //NOTE: getFullDetails -> ListViewItem
        private void getFullDetails(ListViewItem item) {

            foreach (var element in MainForm._fullDetailsList)
            {

                if (item.SubItems[0].Text == element.WebsiteUrl)
                {

                    //DEBUG: Console.WriteLine(element.WebsiteName);
                    item.SubItems[0].Text = element.WebsiteUrl;
                    item.SubItems[1].Text = element.WebsiteName;
                    item.SubItems[2].Text = element.WebsiteStatus;
                    item.SubItems[3].Text = element.WebsiteResponse;
                    item.SubItems[4].Text = "ToDo";
                    item.SubItems[5].Text = "ToDo";
           
            switch (element.WebsiteStatus)
            {
                case "Online":
                    {
                        item.BackColor = Color.Green;
                        item.ForeColor = Color.White;
                        break;
                    }
                case "404":
                    {
                        item.BackColor = Color.DimGray;
                        item.ForeColor = Color.White;
                        break;
                    }
                default:
                    {
                   
                        item.BackColor = Color.OrangeRed;
                        item.ForeColor = Color.White;
                        break;
                    }
            }
                }
            }
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            status_check();
       
            labelWebsiteName.Text = listViewMain.SelectedItems[0].SubItems[1].Text;


            //NOTE: clear chart
            if (checkSelected != listViewMain.SelectedItems[0].ToString())
            {
                checkSelected = listViewMain.SelectedItems[0].ToString();
                foreach (var series in chartResponseTime.Series)
                {
                    series.Points.Clear();
                }

                WebsiteIntoUpdate(listViewMain.SelectedItems[0].SubItems[0].Text); //NOTE: Update richboxes 
            }

            //NOTE: string format from string to int from listView[3] - crappy version
            string responseTimeFormatToInt = listViewMain.SelectedItems[0].SubItems[3].Text.Replace(":", ".");
            responseTimeFormatToInt = responseTimeFormatToInt.Replace("s", "");
            responseTimeFormatToInt = responseTimeFormatToInt.Replace("e", "");
            responseTimeFormatToInt = responseTimeFormatToInt.Replace("c", "");
            responseTimeFormatToInt = responseTimeFormatToInt.Replace(" ", "");

            //NOTE: update chart
            chartResponseTime.Series["Response Time"].Points.AddXY(DateTime.Now, responseTimeFormatToInt);
            //NOTE: chart colors (not for points)
            chartResponseTime.Palette = ChartColorPalette.SemiTransparent;


            //NOTE: limit chart (display up-to x columns)
            if (chartResponseTime.Series[0].Points.Count > 10)
            {
                chartResponseTime.Series[0].Points.RemoveAt(0);
                chartResponseTime.ResetAutoValues();
            }

            eventsBoxUpdate(); //NOTE: update events box
        }

        //NOTE: first run
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
            eventsBoxUpdate(); //NOTE: update events box

        }

        private void eventsBoxUpdate()
        {
            //NOTE: EVENTS Box update
            richTextBoxEventLog.Clear();

            foreach (var element in MainForm._eventDetailsList)
            {
                //Console.WriteLine(element.WebsiteName); //DEBUG
                //Console.WriteLine(listViewMain.SelectedItems[0].SubItems[1].Text); //DEBUG
                if (element.WebsiteName == listViewMain.SelectedItems[0].SubItems[1].Text)
                {                    
                    richTextBoxEventLog.AppendText("\r\n" + element.WebsiteName + " - " + element.Description + " at  " + element.EventTime.ToString("HH:mm:ss:tt") + " on " + element.EventTime.ToString("dddd, dd MMMM yyyy"));
                }

}


        }

        //NOTE richTextBoxWebsiteOverview / WHOIS and events sections update
        private void WebsiteIntoUpdate(string URL)
        {

            //NOTE: Clear richTextBoxWebsiteOverview
            richTextBoxWebsiteOverview.Clear();
            //NOTE: Get IP from URL
            Uri webUri = new Uri(URL);
            try
            {
                ip = Dns.GetHostAddresses(webUri.Host)[0].ToString();
            }
            catch (System.Net.Sockets.SocketException)
            {
                //handle Exception
            }
            //Console.WriteLine(ip); //DEBUG
            if (ip == null)
            {
                ip = "Can't resolve host server IP. Try again later. ";
            }
            richTextBoxWebsiteOverview.AppendText("IP Address: " + ip.ToString() + "\r\n\r\n");


            //NOTE: Get DNS info
            string host = webUri.Host.ToLower();
            if (host.StartsWith("www."))
            {
                host = host.Replace("www.", "");
            }

            DnsMessage dnsMessage = DnsClient.Default.Resolve(DomainName.Parse(host), RecordType.A);
            if ((dnsMessage == null) || ((dnsMessage.ReturnCode != ReturnCode.NoError) && (dnsMessage.ReturnCode != ReturnCode.NxDomain)))
            {
                throw new Exception("DNS request failed");
            }
            else
            {
                richTextBoxWebsiteOverview.AppendText("Nameserver records: \r\n");
                foreach (DnsRecordBase dnsRecord in dnsMessage.AnswerRecords)
                {
                    ARecord aRecord = dnsRecord as ARecord;
                    if (aRecord != null)
                    {
                        //Console.WriteLine(aRecord.Address.ToString()); //DEBUG
                        richTextBoxWebsiteOverview.AppendText(aRecord.Address.ToString() + "\r\n");
                    }
                }
            }
            //NOTE: Get server type
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            try
            {
                WebResponse response = request.GetResponse();
                //Console.Out.WriteLine(response.Headers.Get("Server")); //DEBUG
                richTextBoxWebsiteOverview.AppendText("\r\n Web Server Type: " + response.Headers.Get("Server") + "\r\n");

            }
            catch (System.Net.WebException)
            {
                //handle Exception
                richTextBoxWebsiteOverview.AppendText("Web Server Type: Unknown"  + "\r\n");
            }


            //WHOIS
            richTextBox3rdParty.Clear();
            richTextBox3rdParty.AppendText("Loading WHOIS information...");

            Task.Run(() =>
            {
                var whois = new WhoisLookup();
                try
                {
                    var whoisResponse = whois.Lookup(host);

                    //Console.WriteLine(whoisResponse.Content); //DEBUG
                    richTextBox3rdParty.Clear();
                    richTextBox3rdParty.AppendText(whoisResponse.Content);
                }
                catch (Whois.WhoisException)
                {
                    //handle exception
                    richTextBox3rdParty.Clear();
                    richTextBox3rdParty.AppendText("Unable to perform WHOIS action.");
                }

            });
        }



        private void FormDetailedView_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            
            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            PopulateWebsiteList();

            first_run(); //NOTE: first run
            listViewMain.Items[0].Selected = true; //NOTE: mark first listViewMain item (default)
            checkSelected = listViewMain.Items[0].ToString(); //NOTE: marked item -> checkSelected

            WebsiteIntoUpdate(listViewMain.SelectedItems[0].SubItems[0].Text);


            InitTimer(); //checking website in a loop
        }


        //NOTE:add rows to listViewMain
        public void Add(string url, String name, string status, string response)
        {
            String[] row = { url, name, status, response };
            ListViewItem item = new ListViewItem(row);
            item.Name = url;

            listViewMain.Items.Add(item);
        }

               
        public void PopulateWebsiteList()
        {
            foreach (var website in _websitesList)
            {
                if (website.Key != "" && website.Value != "")
                {
                    String[] row = { website.Value, website.Key, "Wait", "-" ,"",""};
                    ListViewItem item = new ListViewItem(row);
                    item.Name = website.Value;

                    listViewMain.Items.Add(item);
                }
            }
        }

        private void listViewMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NOTE: Probably will never be used.
        }

        private void chartResponseTime_Click(object sender, EventArgs e)
        {
            //NOTE: Probably will never be used.
        }

        private void labelUrlInfo_Click(object sender, EventArgs e)
        {
            //NOTE: Probably will never be used.
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.Filter = "All files (*.txt) | *.txt";
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = oSaveFileDialog.FileName;
                using (File.Create(Path.GetFullPath(oSaveFileDialog.FileName))) ;
                richTextBoxEventLog.SaveFile(Path.GetFullPath(oSaveFileDialog.FileName), RichTextBoxStreamType.PlainText);
            }
        }
    }
}
