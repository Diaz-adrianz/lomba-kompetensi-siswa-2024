using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apotek_xyz_wf.Utils
{
    public static class Components
    {
        public static void ToggleButtonEnabled(Button btn, string text = null, string typ = "primary")
        {
            if (text != null) btn.Text = text;
            btn.Enabled = !btn.Enabled;

            btn.BackColor = btn.Enabled ? typ == "secondary" ? SystemColors.ControlDark : Color.Green : SystemColors.ControlDark;
            btn.ForeColor = btn.Enabled ? typ == "secondary" ? SystemColors.ControlText : SystemColors.HighlightText : SystemColors.ControlDarkDark;
        }

        public static void AdjustTableHeight(DataGridView tbl)
        {
            int height = 0;
            foreach (DataGridViewRow row in tbl.Rows)
            {
                height += row.Height;
            }
            tbl.Height = height + tbl.ColumnHeadersHeight;
        }
    }
}
