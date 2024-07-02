using apotek_xyz_wf.Database;
using apotek_xyz_wf.Repository;
using apotek_xyz_wf.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apotek_xyz_wf.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserRepo userRepo = new UserRepo();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonResetClick(object sender, EventArgs e)
        {
            InputUsername.Text = "";
            InputPassword.Text = "";
        }

        private void CheckShowPasswordClick(object sender, EventArgs e)
        {
            InputPassword.PasswordChar = CheckShowPassword.Checked ? '\0' : '*';
        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {
            Components.ToggleButtonEnabled(ButtonLogin, "Loading...");
            Components.ToggleButtonEnabled(ButtonReset, null, "secondary");

            try
            {
                Tbl_User user = userRepo.Login(InputUsername.Text, InputPassword.Text);

                Properties.Settings.Default.Username = user.Username;
                Properties.Settings.Default.Tipe_User = user.Tipe_User;
                Properties.Settings.Default.Save();

                bool res = RedirectForm();

                if (!res) Alert.Error("Tipe user tidak dikenali");
            }
            catch (Exception err)
            {
                Alert.Error(err.Message);
            }
            finally
            {
                Components.ToggleButtonEnabled(ButtonLogin, "LOGIN");
                Components.ToggleButtonEnabled(ButtonReset, null, "secondary");
            }
        }

        private bool RedirectForm()
        {
            string role = Properties.Settings.Default.Tipe_User;

            Form form;

            if (role == "Admin")
            {
                form = new AdminForm();
            }
            else if (role == "Apoteker")
            {
                form = new ApotekerForm();
            }
            else if (role == "Kasir")
            {
                form = new KasirForm();
            }
            else
            {
                return false;
            }

            if (form != null)
            {
                Hide();
                form.ShowDialog();
                Close();
            }

            return true;
        }

        private void LoginFormLoad(object sender, EventArgs e)
        {
            RedirectForm();
        }
    }
}
