using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.Utils
{
    public static class Alert
    {
        public static DialogResult Info(string t)
        {
            return MessageBox.Show(t, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Error(string t)
        {
            return MessageBox.Show(t, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Confirm(string t)
        {
            return MessageBox.Show(t, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
