using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Website_Monitoring.Controls {
    public partial class CustomListView : ListView {
        #region Constructors
        public CustomListView() {
            //Activate double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            //Enable the OnNotifyMessage event so we get a chance to filter out 
            // Windows messages before they get to the form's WndProc
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);

            this.OwnerDraw = true;
            this.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(this.ListView_DrawColumnHeader);
            this.DrawItem += new DrawListViewItemEventHandler(this.ListView_DrawItem);
            this.DrawSubItem += new DrawListViewSubItemEventHandler(this.ListView_DrawSubItem);
        }
        #endregion

        #region Protected Methods
        protected override void OnNotifyMessage(Message m) {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14) {
                base.OnNotifyMessage(m);
            }
        }
        #endregion

        #region Public Methods
        public void SetLastColumnTofill() {
            int sum = 0;
            int count = this.Columns.Count;
            for (int i = 0; i < count - 1; i++) sum += this.Columns[i].Width;
            this.Columns[count - 1].Width = this.ClientSize.Width - sum;
        } 
        #endregion

        #region Private Event Handlers
        private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) {
            e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
            e.Graphics.DrawRectangle(SystemPens.Control, new Rectangle(e.Bounds.X, 0, e.Bounds.Width, e.Bounds.Height - 1));

            string text = this.Columns[e.ColumnIndex].Text;
            TextFormatFlags cFlag = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(e.Graphics, text, this.Font, e.Bounds, Color.Black, cFlag);
        }

        private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e) {
            e.DrawDefault = true;
        }

        private void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e) {
            e.DrawDefault = true;
        } 
        #endregion
    }
}