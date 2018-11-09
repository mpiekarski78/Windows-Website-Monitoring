using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Website_Monitoring.Library {
    public static class ListViewExtensions {
        public static void SetLastColumnTofill(ListView listView) {
            int sum = 0;
            int count = listView.Columns.Count;
            for (int i = 0; i < count - 1; i++) sum += listView.Columns[i].Width;
            listView.Columns[count - 1].Width = listView.ClientSize.Width - sum;
        }

        public static void ListView_DrawColumnHeader(ListView listView, object sender, DrawListViewColumnHeaderEventArgs e) {
            e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
            e.Graphics.DrawRectangle(SystemPens.Control, new Rectangle(e.Bounds.X, 0, e.Bounds.Width, e.Bounds.Height - 1));

            string text = listView.Columns[e.ColumnIndex].Text;
            TextFormatFlags cFlag = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(e.Graphics, text, listView.Font, e.Bounds, Color.Black, cFlag);
        }

        public static void ListView_DrawItem(object sender, DrawListViewItemEventArgs e) {
            e.DrawDefault = true;
        }

        public static void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e) {
            e.DrawDefault = true;
        }
    }
}
