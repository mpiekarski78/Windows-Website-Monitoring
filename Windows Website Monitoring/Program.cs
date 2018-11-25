using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Website_Monitoring
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            using (NotifyIcon icon = new NotifyIcon())
            {
                icon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                icon.ContextMenu = new ContextMenu(new MenuItem[] {
                //DEBUG: new MenuItem("Show form", (s, e) => {new Form1().Show();}),
                new MenuItem("Exit", (s, e) => { Application.Exit(); }),
            });
                icon.Visible = true;

                Application.Run(new FormLoader(FormLoader.LoaderWorker));

                Application.Exit();


                //NOTE: simple key verification (if X)
                string appRegKey="";
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\WinRegistry");
                if (key.GetValue("appRegKey") != null)
                {
                    appRegKey = key.GetValue("appRegKey").ToString().ToUpper();
                    
                    
                }
                try
                {
                    // Console.WriteLine(appRegKey[4]); //DEBUG

                    //
                    if (appRegKey[4] == 'X')
                    {
                        Application.Run(new MainForm());

                        icon.Visible = false;
                        
                        //NOTE: uncomment to check product key FORM
                        /*using (RegistryKey keyDel = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\WinRegistry", true))
                        {

                            keyDel.DeleteValue("appRegKey"); 
                        }*/
                        //NOTE: end uncomment

                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    Application.Run(new Register());
                }

                
            }
        }



    }


}

        




