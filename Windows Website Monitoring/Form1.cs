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
using System.Globalization;
using System.Threading;
using tip2tail.WinFormAppBarLib;



//Formularz (Form1) - głowny form - strona głowna
namespace Windows_Website_Monitoring
{
    public partial class Form1 : Form
    {
        private string _filePath = System.IO.Path.Combine(System.IO.Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).Parent.Parent.FullName, @"Resources\data.txt");

        

        public Form1()
        {
            InitializeComponent();

        }

        private System.Windows.Forms.Timer timer1;
        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 20000; // in miliseconds
            timer1.Start();
            
            
        }




        private void status_check()
        {
            
                bool urlStatus;

                //add columns

                listViewMain.Items.Clear(); //czyszczenie listeView

                string status;


                //wczytanie z pliku 
                string[] lines = System.IO.File.ReadAllLines(_filePath);
                if (lines.Length > 0)

                {
                    int s = 0; // liczenie pól w listView
                    foreach (string line in lines)
                    {
                        if (line != "")
                        {

                            List<string> stringList = line.Split('#').ToList();

                            //checking websites

                            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(stringList[0]);
                            request.Timeout = 15000;
                            request.Method = "HEAD";
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

                            if (urlStatus == true)
                            {
                                status = "Online"; // Text
                            }
                            else
                            {
                                status = "Error"; // Text
                            }


                            add(stringList[0], stringList[1], status);
                            if (urlStatus == true)
                            {
                                listViewMain.Items[s].BackColor = Color.Green;
                                listViewMain.Items[s].ForeColor = Color.White;
                            }
                            else
                            {
                                listViewMain.Items[s].BackColor = Color.Red;
                                listViewMain.Items[s].ForeColor = Color.White;
                            }

                            s += 1;
                        }
                    }

                }
            
            }
        private void timer1_Tick(object sender, EventArgs e)
        {
            status_check();
        }

        // Form1 Load
        private void Form1_Load(object sender, EventArgs e)
        {
        

            // przekierowanie okienka na prawą stronię
            AppBarHelper.AppBarMessage = "TestAppBarApplication";
            AppBarHelper.SetAppBar(this, AppBarEdge.Right);
            
            
            //ustawienie kolumn w listView

            listViewMain.View = View.Details;
            listViewMain.FullRowSelect = true; //kliknięcie zaznacza wszystkie pozycje w danej lini (nie tylko jedną)
            listViewMain.Columns.Add("Website URL", 80);
            listViewMain.Columns.Add("Website Name", 100);
            listViewMain.Columns.Add("Status", 50);

          
                status_check(); //pierwsze sprawdzenie

                InitTimer(); //uruchomienie sprawdzania działania stron
          
        CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
        TextInfo textInfo = cultureInfo.TextInfo;

        
        }

        

        //add rows - nowa metoda do dodawania nowych pozycji URL + name
        public void add(string url, String name, string status)
        {
            String[] row = { url, name, status };
            ListViewItem item = new ListViewItem(row);


            listViewMain.Items.Add(item);
        }

        /*
            foreach (var url in urlList)
            {
                //checking websites
                var i = urlList.IndexOf(url);
                Console.WriteLine(url);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 15000;
                request.Method = "HEAD"; 
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

                // URLS   
                var labelUrl = new Label();

                labelUrl.Name = $"txtUrl{textInfo.ToTitleCase(url.Split('#')[1])}";
                labelUrl.Top = 100 + (urlLocY * i); // umiejscowienie
                labelUrl.Left = urlLocX; // umiejscowienie
                labelUrl.Font = new Font("Century Gothic", 10, FontStyle.Regular);  //font i rozmiar
                labelUrl.Width = 170;
                labelUrl.Text  = (i+1).ToString() + "."  + url; // Text

                labelsURL.Add(labelUrl);

                // Statuses
                var labelStatus = new Label();

                labelStatus.Name = $"txtStatus{textInfo.ToTitleCase(url.Split('#')[1])}";
                labelStatus.Top = 100 + (urlLocY * i); // umiejscowienie
                labelStatus.Left = statusesLocX; // umiejscowienie
                labelStatus.Font = new Font("Century Gothic", 10, FontStyle.Regular);  //font i rozmiar
                labelStatus.Width = 60;

                labelStatus.ForeColor = Color.White;
                if (urlStatus == true)
                {
                    labelStatus.BackColor = Color.ForestGreen;
                    labelStatus.Text = "Online"; // Text
                }
                else
                {
                    labelStatus.BackColor = Color.Red;
                    labelStatus.Text = "Error!"; // Text
                }

                labelsStatus.Add(labelStatus);

                flowLayoutPanel.Controls.AddRange(new Control[] { labelUrl, labelStatus });
            }
        }
    */
        private void labelStatusOverview_Click(object sender, EventArgs e)
        {

        }

        //kliknięcie w obrazek (opcje) powoduje otwarcie nowego okna Form2
        private void pictureBoxConfiguration_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this, _filePath);
            f2.Show(); // Shows Form2
        }
    }
}