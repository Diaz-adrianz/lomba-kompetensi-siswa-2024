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
    public partial class ApotekerForm : Form
    {
        public ApotekerForm()
        {
            InitializeComponent();

            OpenForm(new KelolaResepForm());

            ButtonLogout.Click += ButtonLogoutClick;
        }

        private void OpenForm(Form form)
        {
            if (PanelForm.Controls.Count > 0) PanelForm.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            PanelForm.Controls.Add(form);
            form.Show();
        }

        private void ButtonLogoutClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Tipe_User = "";
            Properties.Settings.Default.Save();

            Hide();
            Form loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
        }
    }
}
