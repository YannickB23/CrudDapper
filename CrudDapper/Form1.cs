using CodeLibrary.Models;
using System;
using System.Windows.Forms;

namespace CrudDapper
{
    public partial class frmBooksApp : Form
    {
        private BookRepo repo = new BookRepo();

        public frmBooksApp()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Price = decimal.Parse(txtPrice.Text),
                Description = txtDescription.Text,
                CountryId = 1
            };

            repo.AddBook(book);
            LoadBooks();
        }

        private void LoadBooks()
        {
            this.grvBooks.DataSource = null;
            grvBooks.DataSource = repo.GetBooks();
        }

        private void frmBooksApp_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void grvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                lblId.Text = grvBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTitle.Text = grvBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAuthor.Text = grvBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = grvBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDescription.Text = grvBooks.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Id = int.Parse(lblId.Text),
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Price = decimal.Parse(txtPrice.Text),
                Description = txtDescription.Text,
                CountryId = 1
            };

            repo.UpdateBook(book);
            LoadBooks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            repo.DeleteBook(int.Parse(lblID.Text.Substring(lblID.Text.LastIndexOf(' ') + 1)));
            LoadBooks();
        }
    }
}
