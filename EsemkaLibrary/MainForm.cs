using EsemkaLibrary.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaLibrary
{
    public partial class MainForm : Form
    {
        private readonly EsemkaLibraryDB db = new EsemkaLibraryDB();

        List<Borrowing> borrowList;
        Member member;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ReturnBook(int idx)
        {
            Borrowing borrow = borrowList[idx];
            Book book = borrow.Book;
            int overdue = 0;

            if (borrow.return_date != null && borrow.return_date?.Date < DateTime.Now.Date)
            {
                overdue = Convert.ToInt32((DateTime.Now.Date - borrow.return_date?.Date)?.TotalDays);
            }

            borrow.fine = overdue * 2000;
            book.stock = book.stock += 1;

            try
            {
                db.SaveChanges();

                MessageBox.Show(
                    $"Success return \"{book.title}\". \nMember needs to pay fine: {borrow.fine ?? 0} IDR.",
                    "Notification",
                    MessageBoxButtons.OK
                );
                GetData();
            } catch (Exception err)
            {
                Console.WriteLine(err);
                MessageBox.Show(
                    "Something went wrong.",
                    "Error",
                    MessageBoxButtons.OK
                );
            }
        }

        private void BtnSearchMemberClick(object sender, EventArgs e)
        { 
            GetData();
        }

        private void GetData()
        {
            string name = InpSearchMember.Text;
            member = db.Members.FirstOrDefault(m => m.name == name);
            borrowList = db.Borrowings.Where(b => b.Member.name == name).ToList();

            TblBorrowing.Rows.Clear();

            int onBorrow = 0;
            List<int> onDeadline = new List<int> { };
            List<int> onOverdue = new List<int> { };

            for (int i = 0; i < borrowList.Count; i++)
            {
                Borrowing brw = borrowList[i];
                int overdue = 0;
                bool returned = brw.fine != null;

                if (brw.return_date != null && brw.return_date?.Date <= DateTime.Now.Date)
                {
                    if (!returned)
                    {
                        if (brw.return_date?.Date == DateTime.Now.Date) onDeadline.Add(i);
                        else onOverdue.Add(i); 
                    }

                    overdue = Convert.ToInt32((DateTime.Now.Date - brw.return_date?.Date)?.TotalDays);
                }

                if (!returned) onBorrow += 1;

                TblBorrowing.Rows.Add(
                   brw.Book.title,
                   brw.borrow_date.ToString("dd MMMM yyyy"),
                   brw.return_date?.ToString("dd MMMM yyyy"),
                   overdue,
                   returned ? "" : "Return"
                );
            }

            BtnNewBorrow.Enabled = onBorrow < 3 && member != null;

            foreach (int idx in onOverdue)
            {
                TblBorrowing.Rows[idx].DefaultCellStyle.BackColor = Color.Red;
            }

            foreach (int idx in onDeadline)
            {
                TblBorrowing.Rows[idx].DefaultCellStyle.BackColor = Color.Yellow;
            }

            TblBorrowing.ClearSelection();
        }

        private void BtnNewBorrowClick(object sender, EventArgs e)
        {
            if (member != null)
            {
                Properties.Settings.Default.MemberID = member.id;
                this.Hide();
                
                Form borrowForm = new BorrowForm();
                borrowForm.FormClosed += (s, ee) => { this.Show(); };
                borrowForm.ShowDialog();
            }
        }

        private void BorrowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            TblBorrowing.ClearSelection();
        }

        private void TblBorrowingCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TblBorrowing.Columns["action"].Index && e.RowIndex >= 0)
            {
                ReturnBook(e.RowIndex);
            }
        }
    }
}
