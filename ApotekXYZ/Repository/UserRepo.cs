using apotek_xyz_wf.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apotek_xyz_wf.Repository
{
    interface IUserRepo
    {
        Tbl_User Login(string username, string password);
        List<Tbl_User> GetUsers(string q);
        void CreateUser(Tbl_User user);
        void UpdateUser(Tbl_User user);
        void DeleteUser(Tbl_User user);

    }

    public class UserRepo : BaseRepo, IUserRepo
    {
        public void CreateUser(Tbl_User user)
        {
            try
            {
                db.Tbl_User.Add(user);
                db.SaveChanges();
            }
            catch
            {
                throw new Exception("Gagal menambahkan user baru");
            }
        }

        public void DeleteUser(Tbl_User user)
        {
            try
            {
                db.Tbl_User.Remove(user);
                db.SaveChanges();
            }
            catch
            {
                throw new Exception("Gagal menghapus user");
            }
        }

        public List<Tbl_User> GetUsers(string q = "")
        {
            return q != "" ? 
                db.Tbl_User.Where(u => u.Username.Contains(q) || u.Nama_User.Contains(q)).ToList() 
                : db.Tbl_User.ToList();
        }

        public Tbl_User Login(string username, string password)
        {
            Tbl_User user = db.Tbl_User.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                throw new Exception("User tidak ditemukan");
            }

            if (user.Password != password)
            {
                throw new Exception("Password tidak cocok");
            }

            return user;
        }

        public void UpdateUser(Tbl_User user)
        {
            try
            {
                db.SaveChanges();
            }
            catch
            {
                throw new Exception("Gagal mengedit data user");
            }
        }
    }
}
