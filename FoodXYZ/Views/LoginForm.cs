using FoodXYZ.Database;
using FoodXYZ.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.Views
{
    public partial class LoginForm : Form
    {
        private readonly FoodXYZDB db = new FoodXYZDB();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButLoginClick(object sender, EventArgs e)
        {
            string uName = InpUsername.Text;
            string uPass = InpPassword.Text;

            if (uName == "")
            {
                Alert.Error("Username tidak boleh kosong");
                return;
            }

            if (uPass == "")
            {
                Alert.Error("Password tidak boleh kosong");
                return;
            }

            User user = db.Users.FirstOrDefault(u => u.Username == uName);

            if (user == null)
            {
                Alert.Error("Pengguna tidak ditemukan");
                return;
            }

            if (user.Password != uPass)
            {
                Alert.Error("Password salah!");
                return;
            }

            Properties.Settings.Default.IdUser = user.IdUser;
            Properties.Settings.Default.TipeUser = user.TipeUser;
            Properties.Settings.Default.Save();

            if (user.TipeUser == "Admin" || user.TipeUser == "Gudang" || user.TipeUser == "Kasir")
            {
                Hide();
                Form layoutForm = new LayoutForm();
                layoutForm.ShowDialog();
                Close();
            }
            else
            {
                Alert.Error("Tipe pengguna tidak dikenali");
            }

        }

        private void ButResetClick(object sender, EventArgs e)
        {
            InpPassword.Text = "";
            InpUsername.Text = "";
        }
    }
}
