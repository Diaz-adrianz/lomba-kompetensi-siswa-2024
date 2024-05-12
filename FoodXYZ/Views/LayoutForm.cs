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
    public partial class LayoutForm : Form
    {
        public LayoutForm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            string tipeUser = Properties.Settings.Default.TipeUser;
            List<Button> buttons = new List<Button> { };

            LabTipeUser.Text = tipeUser;
            if (tipeUser == "Admin")
            {
                PicTipeUser.Image = Properties.Resources.admin;
                Button ButLogUser = GenButton("Log Aktivitas");
                Button ButKelUser = GenButton("Kelola User");
                Button ButKelLaporan = GenButton("Kelola Laporan");

                ButLogUser.Click += (s, e) => OpenForm(new LogForm());
                ButKelUser.Click += (s, e) => OpenForm(new KelolaUserForm());
                ButKelLaporan.Click += (s, e) => OpenForm(new KelolaLaporanForm());

                buttons.Add(ButLogUser);
                buttons.Add(ButKelUser);
                buttons.Add(ButKelLaporan);
            }
            else if (tipeUser == "Gudang")
            {
                PicTipeUser.Image = Properties.Resources.gudang;
                Button ButKelBarang = GenButton("Kelola Barang");
                ButKelBarang.Click += (s, e) => OpenForm(new KelolaBarangForm());

                buttons.Add(ButKelBarang);
            }
            else if (tipeUser == "Kasir")
            {
                PicTipeUser.Image = Properties.Resources.cashier;
                Button ButKelTrans = GenButton("Kelola Transaksi");
                ButKelTrans.Click += (s, e) => OpenForm(new KelolaTransaksiForm());

                buttons.Add(ButKelTrans);
            }

            Button ButLogout = GenButton("Logout");
            buttons.Add(ButLogout);

            foreach (var item in buttons)
            {
                PanSidebar.Controls.Add(item);

                Panel space = new Panel();
                space.Height = 8;
                space.Dock = DockStyle.Bottom;
                PanSidebar.Controls.Add(space);
            }

            if (tipeUser == "Admin") OpenForm(new LogForm());
            else if (tipeUser == "Gudang") OpenForm(new KelolaBarangForm());
            else if (tipeUser == "Kasir") OpenForm(new KelolaTransaksiForm());
        }

        private void OpenForm(Form form)
        {
            PanForm.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            PanForm.Controls.Add(form);
            form.Show();
        }

        private Button GenButton(string t)
        {
            Button but = new Button();
            but.Text = t;
            but.Dock = DockStyle.Bottom;
            but.BackColor = SystemColors.Highlight;
            but.FlatAppearance.BorderSize = 0;
            but.Size = new Size(171, 38);
            but.FlatStyle = FlatStyle.Flat;
            but.ForeColor = SystemColors.HighlightText;
            but.UseVisualStyleBackColor = false;
            
            return but;
        }
    }
}
