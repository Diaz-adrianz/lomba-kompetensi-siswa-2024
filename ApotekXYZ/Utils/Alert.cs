using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apotek_xyz_wf.Utils
{
    public static class Alert
    {
        public static DialogResult Info(string msg)
        {
            return MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult Error(string msg)
        {
            return MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult Confirm(string msg)
        {
            return MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
