using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Website_Monitoring.Controls {
    public partial class BaseForm : Form, IMessageFilter {
        #region Imports
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Private Members
        private HashSet<Control> _controlsToMove = new HashSet<Control>(); 
        #endregion

        #region Constructor
        public BaseForm() {
            InitializeComponent();
            Application.AddMessageFilter(this);

            _controlsToMove.Add(this);
        }
        #endregion

        #region Public Methods
        public void AddMoveEnabledControl(Control control) {
            _controlsToMove.Add(control);
        }

        public bool PreFilterMessage(ref Message m) {
            if (m.Msg == WM_LBUTTONDOWN && _controlsToMove.Contains(Control.FromHandle(m.HWnd))) {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }
        #endregion
    }
}
