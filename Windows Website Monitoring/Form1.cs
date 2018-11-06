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


            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

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

            List<Label> labelsURL = new List<Label>();
            List<Label> labelsStatus = new List<Label>();

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
            }

            this.Controls.AddRange(labelsURL.ToArray());
            this.Controls.AddRange(labelsStatus.ToArray());
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