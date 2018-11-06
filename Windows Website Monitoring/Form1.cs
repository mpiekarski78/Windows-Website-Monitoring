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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        // Form1 Load
        private void Form1_Load(object sender, EventArgs e)
        {


            bool urlStatus;

            int urlLocX = 10; //pozycja URLS 
            int statusesLocX = 180; //pozycja Statuses
            int urlLocY = 30; //przerwy pomiędzy liniami

            //wczytywanie z pliku
            string[] lines = System.IO.File.ReadAllLines(_filePath);


            // string[] urlList = { "http://www.google.com", "http://safdasd.dds", "http://edisonproperties.com" };

            List<string> urlList = new List<string>();

                       
            if (lines.Length > 0)
             {
                int i = 0;
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        List<string> stringList = line.Split('#').ToList();
                        urlList.Add(stringList[0] + "#" + stringList[1]);
                        i += 1;
                    }
                }
            }


            int n = 0;
            foreach (string url in urlList)
            {
                n += 1;
            }
            

            Label[] labelsURL = new Label[n];
            Label[] labelsStatus = new Label[n];



            for (int i = 0; i < n; i++)
            {
                //checking websites

                Console.WriteLine(urlList[i]);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlList[i]);
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
                labelsURL[i] = new Label();
                labelsURL[i].Top = 100 + (urlLocY * i); // umiejscowienie
                labelsURL[i].Left = urlLocX; // umiejscowienie
                labelsURL[i].Font = new Font("Century Gothic", 10, FontStyle.Regular);  //font i rozmiar
                labelsURL[i].Width = 170;
                labelsURL[i].Text  = (i+1).ToString() + "."  + urlList[i]; // Text

                // Statuses
                labelsStatus[i] = new Label();
                labelsStatus[i].Top = 100 + (urlLocY * i); // umiejscowienie
                labelsStatus[i].Left = statusesLocX; // umiejscowienie
                labelsStatus[i].Font = new Font("Century Gothic", 10, FontStyle.Regular);  //font i rozmiar
                labelsStatus[i].Width = 60;
                
                labelsStatus[i].ForeColor = Color.White;
                if (urlStatus == true)
                {
                    labelsStatus[i].BackColor = Color.ForestGreen;
                    labelsStatus[i].Text = "Online"; // Text
                }
                else
                {
                    labelsStatus[i].BackColor = Color.Red;
                    labelsStatus[i].Text = "Error!"; // Text
                }
            }

            
            for (int i = 0; i < n; i++)
            {
                this.Controls.Add(labelsURL[i]);
                this.Controls.Add(labelsStatus[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //kliknięcie w obrazek (opcje) powoduje otwarcie nowego okna Form2
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this, _filePath);
            f2.Show(); // Shows Form2
        }

  


    }
}
