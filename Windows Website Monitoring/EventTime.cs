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

namespace Windows_Website_Monitoring
{
    public partial class EventTime : Form
    {
        public EventTime()
        {
            InitializeComponent();
        }

        private void EventTime_Load(object sender, EventArgs e)
        {

            MainForm MainForm = (MainForm)this.Owner;

            string selectedWebsite = ExtractString(MainForm.checkSelected, "{", "}");



            foreach (var element in MainForm._eventDetailsList)
            {
                if (element.WebsiteName == selectedWebsite) {
                    richTextBoxEvents.AppendText("\r\n" + element.WebsiteName + " - " + element.Description + " at  " + element.EventTime.ToString("HH:mm:ss:tt") + " on " + element.EventTime.ToString("dddd, dd MMMM yyyy"));
                }
                
            }
        }

        string ExtractString(string s, string start, string end)
        {
            

            int startIndex = s.IndexOf(start) + start.Length;
            int endIndex = s.IndexOf(end, startIndex);
            return s.Substring(startIndex, endIndex - startIndex);
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.Filter = "All files (*.txt) | *.txt";
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxEvents.SaveFile(Path.GetFullPath(oSaveFileDialog.FileName), RichTextBoxStreamType.PlainText);
            }

        }
    }
}
