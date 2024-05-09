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
    public partial class BorrowForm : Form
    {
        private readonly EsemkaLibraryDB db = new EsemkaLibraryDB();

        List<Book> books;

        public BorrowForm()
        {
            InitializeComponent();
        }

        private void borrowBook(int idx)
        {
            if (Properties.Settings.Default.MemberID == 0) return;

            Book book = books[idx];
            if (book.stock == 0) return;

            Borrowing borrow = new Borrowing
            {
                member_id = Properties.Settings.Default.MemberID,
                book_id = book.id,
                fine = null,
                borrow_date = DateTime.Now,
                return_date = DateTime.Now.AddDays(7),
                created_at = DateTime.Now
            };
            book.stock = book.stock - 1;

            try
            {
                db.Borrowings.Add(borrow);
                db.SaveChanges();

                MessageBox.Show(
                    "Success borrow \"" + book.title + "\". \nDue date is 7 days from today.",
                    "Notification",
                    MessageBoxButtons.OK
                );

                GetBooks();
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

        private void GetBooks()
        {
            string q = InpSearchBook.Text;
            books = db.Books.Where(b => b.title.Contains(q)).ToList();

            TblBooks.Rows.Clear();

            List<int> outOfStock = new List<int> { };

            for (int i = 0; i < books.Count; i++)
            {
                Book book = books[i];

                if (book.stock == 0) outOfStock.Add(i);

                TblBooks.Rows.Add(
                    book.title,
                    string.Join(", ", book.BookGenres.Select(g => g.Genre.name).ToList().ToArray()),
                    book.author,
                    book.publish_date?.ToString("dd MMMM yyyy"),
                    book.stock,
                    book.stock > 0 ? "Borrow" : null
                );
            }

            foreach (int idx in outOfStock)
            {
                TblBooks.Rows[idx].DefaultCellStyle.BackColor = Color.Red;
            }

            TblBooks.ClearSelection();
        }

        private void BtnSearchBookClick(object sender, EventArgs e)
        {
            GetBooks();
        }

        private void TblBooksCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TblBooks.Columns["action"].Index && e.RowIndex >= 0)
            {
                borrowBook(e.RowIndex);
            }
        }

        private void BorrowFormLoad(object sender, EventArgs e)
        {
            TblBooks.ClearSelection();
        }
    }
}
