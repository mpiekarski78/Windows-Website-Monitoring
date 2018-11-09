using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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



            foreach (var element in MainForm.eventTime)
            {
                //   Console.WriteLine(element); //debug
                if (element.Key.ToString() == selectedWebsite) {
                    //richTextBoxEvents.AppendText("\r\n" + ExtractString(MainForm.checkSelected,"{","}")); //debug
                    //richTextBoxEvents.AppendText("\r\n" + element.Key.ToString()); //debug
                    richTextBoxEvents.AppendText("\r\n" + element);
                }
                
            }
        }

        string ExtractString(string s, string start, string end)
        {
            

            int startIndex = s.IndexOf(start) + start.Length;
            int endIndex = s.IndexOf(end, startIndex);
            return s.Substring(startIndex, endIndex - startIndex);
        }

    }
}
