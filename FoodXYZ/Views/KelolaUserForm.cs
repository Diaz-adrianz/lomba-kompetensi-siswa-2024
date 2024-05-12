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
    public partial class KelolaUserForm : Form
    {
        private readonly FoodXYZDB db = new FoodXYZDB();

        private User userInForm;
        private List<User> users = new List<User> { };

        public KelolaUserForm()
        {
            InitializeComponent();
        }

        private void GetUsers()
        {
            string q = InpSearch.Text;
            users = db.Users.Where(u =>
                    q == "" ? true : u.Username.Contains(q) ||
                    u.Nama.Contains(q)
                )
                .ToList();

            TabUsers.Rows.Clear();
            foreach (var item in users)
            {
                TabUsers.Rows.Add(
                    item.IdUser,
                    item.TipeUser,
                    item.Nama,
                    item.Alamat,
                    item.Telpon
                );
            }
            TabUsers.ClearSelection();
        }

        private bool ValidateForm()
        {
            if (InpAlamat.Text == "")
            {
                Alert.Error("Alamat tidak boleh kosong!");
                return false;
            }

            if (InpNama.Text == "")
            {
                Alert.Error("Nama tidak boleh kosong!");
                return false;
            }

            if (InpUsername.Text == "")
            {
                Alert.Error("Username tidak boleh kosong!");
                return false;
            }

            if (InpTelpon.Text == "")
            {
                Alert.Error("Telepon tidak boleh kosong!");
                return false;
            }

            if (InpPassword.Text == "")
            {
                Alert.Error("Password tidak boleh kosong!");
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            userInForm = null;
            InpAlamat.Text = "";
            InpNama.Text = "";
            InpUsername.Text = "";
            InpTelpon.Text = "";
            InpPassword.Text = "";
        }

        private void ButTambahClick(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            User user = new User
            {
                TipeUser = SelTipeUser.SelectedItem.ToString(),
                Alamat = InpAlamat.Text,
                Nama = InpNama.Text,
                Username = InpUsername.Text,
                Telpon = InpTelpon.Text,
                Password = InpPassword.Text
            };

            if (Alert.Confirm("Lanjutkan tambah pengguna?") == DialogResult.No) return;

            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                Alert.Info("Berhasil menambahkan pengguna baru");

                ClearForm();
                GetUsers();
            } catch (Exception err)
            {
                Console.WriteLine(err.Message);
                Alert.Error("Terjadi kesalahan");
            }
        }

        private void ButEditClick(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            if (userInForm == null)
            {
                Alert.Error("Tidak ada pengguna yang dipilih");
                return;
            }

            userInForm.TipeUser = SelTipeUser.SelectedItem.ToString();
            userInForm.Alamat = InpAlamat.Text;
            userInForm.Nama = InpNama.Text;
            userInForm.Username = InpUsername.Text;
            userInForm.Telpon = InpTelpon.Text;
            userInForm.Password = InpPassword.Text;

            if (Alert.Confirm("Lanjutkan edit pengguna?") == DialogResult.No) return;

            try
            {
                db.SaveChanges();
                Alert.Info("Berhasil mengedi pengguna");

                ClearForm();
                GetUsers();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                Alert.Error("Terjadi kesalahan");
            }
        }

        private void ButHapusClick(object sender, EventArgs e)
        {
            if (userInForm == null)
            {
                Alert.Error("Tidak ada pengguna yang dipilih");
                return;
            }

            if (Alert.Confirm("Lanjutkan hapus pengguna?") == DialogResult.No) return;

            try
            {
                db.Users.Remove(userInForm);
                db.SaveChanges();
                Alert.Info("Berhasil hapus pengguna");

                ClearForm();
                GetUsers();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                Alert.Error("Terjadi kesalahan");
            }
        }

        private void InpSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetUsers();
            }
        }

        private void TabUsersSelect(object sender, EventArgs e)
        {
            if (TabUsers.SelectedRows.Count > 0)
            {
                userInForm = users[TabUsers.SelectedRows[0].Index];

                SelTipeUser.SelectedItem = userInForm.TipeUser;
                InpAlamat.Text = userInForm.Alamat;
                InpNama.Text = userInForm.Nama;
                InpUsername.Text = userInForm.Username;
                InpTelpon.Text = userInForm.Telpon;
                InpPassword.Text = userInForm.Password;
            }
        }

        private void KelolaUserFormLoad(object sender, EventArgs e)
        {
            List<String> tipeUsers = db.Users
                .GroupBy(u => u.TipeUser)
                .Select(g => g.Key)
                .ToList();

            SelTipeUser.Items.Clear();
            foreach (var item in tipeUsers)
            {
                SelTipeUser.Items.Add(item);
            }

            GetUsers();
            ClearForm();
        }
    }
}
