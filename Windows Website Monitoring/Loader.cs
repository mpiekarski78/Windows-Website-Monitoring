using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Website_Monitoring
{
    public partial class FormLoader : Form
    {
        public Action Worker { get; set; }

        public FormLoader(Action worker)
        {
            InitializeComponent();
            CenterToScreen();


            if (worker == null)
            {
                throw new ArgumentNullException();
            }
            Worker = worker;

        }
            protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        public static void LoaderWorker()
        {
            for (int i = 0; i <= 500; i++)
            {
                Thread.Sleep(10);
            }

            


        }



    }

    }

