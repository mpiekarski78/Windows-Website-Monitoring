using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Formularz (Form2) - otwiera konfigurację stron URLs+names. Dodawanie i usuwanie

namespace Windows_Website_Monitoring
{
    public partial class Form2 : Form
    {
        private readonly string _filePath = string.Empty;
        private List<string> removedUrls = new List<string>();

        Form originalForm;
        public Form2(Form incomingForm, string filePath)
        {
            originalForm = incomingForm;
            _filePath = filePath;

            InitializeComponent();
        }

        //zamykanie okineka przez kliknięcie na image (na dole strony po prawej stronie)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(originalForm);
            //update Form1 
            foreach (var removedUrl in removedUrls) {
                originalForm.Controls.Find("flowLayoutPanel", true).First().Controls.RemoveByKey($"txtUrl{removedUrl}");
                originalForm.Controls.Find("flowLayoutPanel", true).First().Controls.RemoveByKey($"txtStatus{removedUrl}");
            }
            this.Close();
        }

        //Load Form2
        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true; //kliknięcie zaznacza wszystkie pozycje w danej lini (nie tylko jedną)

            //add columns
            listView1.Columns.Add("Website URL",200);
            listView1.Columns.Add("Website Name", 150);

            //wczytanie danych z pliku
            string[] lines = System.IO.File.ReadAllLines(_filePath);
            if (lines.Length > 0)
            {
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        List<string> stringList = line.Split('#').ToList();
                        add(stringList[0], stringList[1]);
                    }
                }
            }
        }

        //add rows - nowa metoda do dodawania nowych pozycji URL + name
        public void add(string url, String name)
        {
            String[] row = { url, name };
            ListViewItem item = new ListViewItem(row);


            listView1.Items.Add(item);
        }

        //Kliknięcie w przycisk "Add" powoduje dodanie pozycji z pól (textBox) textBoxNewUrl i textBoxWebsiteName
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            add(textBoxNewUrl.Text, textBoxWebsiteName.Text);

            //zapisywanie do pliku
            using (StreamWriter w = File.AppendText(_filePath))
            {
                w.WriteLine(textBoxNewUrl.Text + "#" + textBoxWebsiteName.Text);
            }

            //wyczyszczenie pól
            textBoxNewUrl.Text = "";
            textBoxWebsiteName.Text = "";
        }

        //usuwanie pozycji po kliknięciu "Remove selected"
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1) {
                removedUrls.Add(listView1.SelectedItems[0].SubItems[1].Text.ToString());

                //usuwanie z pliku
                RemoveLineFromTxtFile(listView1.SelectedItems[0].Text.ToString() + "#" + listView1.SelectedItems[0].SubItems[1].Text.ToString(), _filePath);

                Console.WriteLine(listView1.SelectedItems[0].Text.ToString());
                Console.WriteLine(listView1.SelectedItems[0].SubItems[1].Text.ToString());

                //usuwanie z boxa
                listView1.SelectedItems[0].Remove();
            }
        }

        public static void RemoveLineFromTxtFile(string lineContent, string fileName)
        {
            StringBuilder sb = new StringBuilder("");
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                if (line != lineContent)
                {
                    sb.Append(line + Environment.NewLine);
                }
            }
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.BaseStream.Seek(0, SeekOrigin.Begin);
                sw.Write(sb.ToString());
                sw.Flush();
                sw.Close();
            }
        }
    }
}