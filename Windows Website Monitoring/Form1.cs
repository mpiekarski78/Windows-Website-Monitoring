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
using System.Diagnostics;



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

        private List<string> websiteStatusCheck (string url)
        {
            //checking websites

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            System.Diagnostics.Stopwatch timer = new Stopwatch();
            timer.Start();
            request.Timeout = 15000;
            request.Method = "HEAD";
            bool urlStatus;
            var status = new List<string>();

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

            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            var elapsedTime = ts.ToString(@"ms\.ff");


            status.Add(elapsedTime);
             status.Add(urlStatus.ToString());
            
            return status;

        }


        private void status_check()
        {
            
               listViewMain.Items.Clear(); //czyszczenie listeView

              //wczytanie z pliku 
                string[] lines = System.IO.File.ReadAllLines(_filePath);
                if (lines.Length > 0)

                {
                    int s = 0; // liczenie pól w listView
                
                    foreach (string line in lines)
                    {
                        if (line != "")
                        {

                        //checking websites


                        List<string> stringList = line.Split('#').ToList();


                        new Thread(() => {

               
                            
                            List<string> statusCheck = websiteStatusCheck(stringList[0]);
                            Console.WriteLine(stringList[0] + statusCheck[1]);
                            
                            if (statusCheck[1] == "True")
                            {

                                

                                add(stringList[0], stringList[1], "OK", statusCheck[0]);
                    
                                listViewMain.Items[s].BackColor = Color.Green;
                                listViewMain.Items[s].ForeColor = Color.White;
                            }
                            else
                            {
                                

                                add(stringList[0], stringList[1], "Error", "-");
                                
                                
                                listViewMain.Items[s].BackColor = Color.Red;
                                listViewMain.Items[s].ForeColor = Color.White;
                            }

                            s += 1;

                        }).Start();
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
            Control.CheckForIllegalCrossThreadCalls = false;

            // przekierowanie okienka na prawą stronię
            AppBarHelper.AppBarMessage = "TestAppBarApplication";
            AppBarHelper.SetAppBar(this, AppBarEdge.Right);
            
            
            //ustawienie kolumn w listView

            listViewMain.View = View.Details;
            listViewMain.FullRowSelect = true; //kliknięcie zaznacza wszystkie pozycje w danej lini (nie tylko jedną)
            listViewMain.Columns.Add("Website URL", 80);
            listViewMain.Columns.Add("Website Name", 50);
            listViewMain.Columns.Add("status", 30);
            listViewMain.Columns.Add("response_time", 50);


            status_check(); //pierwsze sprawdzenie

                InitTimer(); //uruchomienie sprawdzania działania stron
          
        CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
        TextInfo textInfo = cultureInfo.TextInfo;

        
        }
       

        //add rows - nowa metoda do dodawania nowych pozycji URL + name
        public void add(string url, String name, string status, string response_time)
        {
            String[] row = { url, name, status,response_time };
            ListViewItem item = new ListViewItem(row);

     
            listViewMain.Items.Add(item);
        }

     


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