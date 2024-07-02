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
    public partial class KelolaUserForm : Form
    {
        private readonly UserRepo userRepo = new UserRepo();
        private readonly List<string> TipeUser = new List<string>{ "Kasir", "Apoteker", "Admin" };

        private List<Tbl_User> users;
        int selectedUserIdx;

        public KelolaUserForm()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            selectedUserIdx = -1;

            SelectTipeUser.Items.Clear();
            foreach (var tipe in TipeUser)
            {
                SelectTipeUser.Items.Add(tipe);
            }
            SelectTipeUser.SelectedIndex = 0;
            InputAlamat.Text = "";
            InputNama.Text = "";
            InputUsername.Text = "";
            InputTelepon.Text = "";
            InputPassword.Text = "";
        }

        private void FillForm()
        {
            if (selectedUserIdx < 0) return;

            Tbl_User user = users[selectedUserIdx];

            SelectTipeUser.SelectedItem = user.Tipe_User;
            InputAlamat.Text = user.Alamat;
            InputNama.Text = user.Nama_User;
            InputUsername.Text = user.Username;
            InputTelepon.Text = user.Telpon;
            InputPassword.Text = user.Password;
        }

        private void GetUsers()
        {
            users = userRepo.GetUsers(InputCari.Text);

            TableUsers.Rows.Clear();
            foreach (var u in users)
            {
                TableUsers.Rows.Add(
                    u.Id_User,
                    u.Tipe_User,
                    u.Nama_User,
                    u.Alamat,
                    u.Telpon
                );
            }
            TableUsers.ClearSelection();
            Components.AdjustTableHeight(TableUsers);
        }

        private void KelolaUserFormLoad(object sender, EventArgs e)
        {
            TableUsers.ClearSelection();
            GetUsers();
            ClearForm();
        }

        private void InputCariKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetUsers();
            }
        }

        private void TableUserOnSelect(object sender, EventArgs e)
        {
            if (TableUsers.SelectedRows.Count > 0)
            {
                selectedUserIdx = TableUsers.SelectedRows[0].Index;
                FillForm();
            } else
            {
                ClearForm();
            }
        }

        private void ButtonTambahClick(object sender, EventArgs e)
        {
            Tbl_User user = new Tbl_User
            {
                Tipe_User = SelectTipeUser.SelectedItem.ToString(),
                Nama_User = InputNama.Text,
                Telpon = InputTelepon.Text,
                Alamat = InputAlamat.Text,
                Username = InputUsername.Text,
                Password = InputPassword.Text
            };

            DialogResult confirm = Alert.Confirm("Lanjutkan menambah user baru?");
            if (confirm != DialogResult.Yes) return;

            try
            {
                userRepo.CreateUser(user);

                GetUsers();
                ClearForm();
            } catch (Exception err)
            {
                Alert.Error(err.Message);
            }
        }

        private void ButtonEditClick(object sender, EventArgs e)
        {
            if (selectedUserIdx < 0)
            {
                Alert.Error("Tidak ada user yang dipilih");
                return;
            }

            Tbl_User user = users[selectedUserIdx];
            user.Tipe_User = SelectTipeUser.SelectedItem.ToString();
            user.Nama_User = InputNama.Text;
            user.Telpon = InputTelepon.Text;
            user.Alamat = InputAlamat.Text;
            user.Username = InputUsername.Text;
            user.Password = InputPassword.Text;

            DialogResult confirm = Alert.Confirm("Lanjutkan edit data user?");
            if (confirm != DialogResult.Yes) return;

            try
            {
                userRepo.UpdateUser(user);

                GetUsers();
                ClearForm();
            }
            catch (Exception err)
            {
                Alert.Error(err.Message);
            }
        }

        private void ButtonHapusClick(object sender, EventArgs e)
        {
            if (selectedUserIdx < 0)
            {
                Alert.Error("Tidak ada user yang dipilih");
                return;
            }

            Tbl_User user = users[selectedUserIdx];

            DialogResult confirm = Alert.Confirm("Lanjutkan hapus user?");
            if (confirm != DialogResult.Yes) return;

            try
            {
                userRepo.DeleteUser(user);

                GetUsers();
                ClearForm();
            }
            catch (Exception err)
            {
                Alert.Error(err.Message);
            }
        }
    }
}
