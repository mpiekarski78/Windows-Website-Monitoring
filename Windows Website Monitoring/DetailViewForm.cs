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

namespace Windows_Website_Monitoring
{
    public partial class DetailViewForm : Form
    {

        private Dictionary<string, string> _websitesList = new Dictionary<string, string>();
        private List<string> _removedWebsites = new List<string>();

        public event WebstitesListChangedHandler WebstitesListChanged;
        public delegate void WebstitesListChangedHandler(List<string> removedWebsites);

        string checkSelected;

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
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }

        private void status_check()
        {

            if (listViewMain.Items.Count > 0)
            {
                foreach (ListViewItem item in listViewMain.Items)
                {
                    // UpdateStatus(item); //TODO
                    getFullDetails(item);  //TODO
                }
                

            }
        }

        //getFullDetails -> ListViewItem
        private void getFullDetails(ListViewItem item) {

            foreach (var element in MainForm._fullDetailsList)
            {

                if (item.SubItems[0].Text == element.WebsiteUrl)
                {

                    //Console.WriteLine(element.WebsiteName);
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
                        item.BackColor = Color.DodgerBlue;
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


            //czyszczenie chart
            if (checkSelected != listViewMain.SelectedItems[0].ToString())
            {
                checkSelected = listViewMain.SelectedItems[0].ToString();
                foreach (var series in chartResponseTime.Series)
                {
                    series.Points.Clear();
                }
            }

            //przygotowanie formatu int ze stringa z listView [3] - na około QQ
            string responseTimeFormatToInt = listViewMain.SelectedItems[0].SubItems[3].Text.Replace(":", ".");
            responseTimeFormatToInt = responseTimeFormatToInt.Replace("s", "");
            responseTimeFormatToInt = responseTimeFormatToInt.Replace("e", "");
            responseTimeFormatToInt = responseTimeFormatToInt.Replace("c", "");
            responseTimeFormatToInt = responseTimeFormatToInt.Replace(" ", "");
            //update chart
            
            chartResponseTime.Series["Response Time"].Points.AddXY(DateTime.Now, responseTimeFormatToInt);

            chartResponseTime.Palette = ChartColorPalette.SemiTransparent;


            //limit chart
            if (chartResponseTime.Series[0].Points.Count > 10)
            {
                chartResponseTime.Series[0].Points.RemoveAt(0);
                chartResponseTime.ResetAutoValues();
            }


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


        private void FormDetailedView_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            
            _websitesList = ConfigManager.GetSectionSettings(CustomConfigSections.Websites);

            PopulateWebsiteList();

            first_run(); //pierwsze sprawdzenie

            listViewMain.Items[0].Selected = true; //zaznaczenie pierwszego wpisu w listViewMain

            checkSelected = listViewMain.Items[0].ToString(); //przypisanie pierwszego zaznaczenia.

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

        }

        private void chartResponseTime_Click(object sender, EventArgs e)
        {

        }
    }
}
