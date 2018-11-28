using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Flurl.Http;
using Microsoft.Win32;

namespace Windows_Website_Monitoring
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void ThankYou_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                ///<remarks> handle excetion </remarks>
                Console.WriteLine(ex);
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            linkLabelRegister.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start("http://pragmio.com/website-monitoring/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelProductKey_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                ///<remarks> handle excetion </remarks>
                Console.WriteLine(ex);
            }
        }




        private void metroButtonRegister_ClickAsync(object sender, EventArgs e)
        {
            string regKey = textBoxKey.Text;
            labelNotification.Text = "";
            checkKey(regKey);


        }

        public async void checkKey(string regKey)
        {
            var responseString = await "http://wms.pragmio.com/login_form.php"
              .WithHeaders(new { Accept = "text/plain", User_Agent = "Flurl" })
              .PostUrlEncodedAsync(new { key = regKey })
              .ReceiveString();

            //Console.WriteLine(responseString); //DEBUG
            if (responseString == "registered")
            {
                
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\WinRegistry");
                key.SetValue("appRegKey", regKey);                
                key.Close();
                
        
                System.Timers.Timer timer = new System.Timers.Timer(1000);
                timer.Elapsed += new ElapsedEventHandler(OnTimerElapsed);
                timer.Interval = 1000;
                timer.Enabled = true;


            }
            else
            {
                labelNotification.Text = "Invalid product key. Please try again.";
            }


        }

        int perfEvents = 0;
        private void OnTimerElapsed(object source, ElapsedEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            perfEvents += 1;
            //Console.WriteLine(perfEvents); //DEBUG
            if (perfEvents == 1)
            {
                labelNotification.Text = "Thank you for registering.";
            }
            if (perfEvents == 3)
            {
                labelNotification.Text = "";
                labelNotification.Text = "Performing initial setup.";
            }
            

            if (perfEvents == 5)
            {
                labelNotification.Text = "";
                labelNotification.Text = "That's it, you can now restart the application.";
                
            }

            if (perfEvents == 6)
            {   
                Application.Exit();
               }

        }
    }


}
