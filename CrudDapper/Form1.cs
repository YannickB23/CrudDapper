using CodeLibrary.Models;
using System;
using System.Windows.Forms;

namespace CrudDapper
{
    public partial class frmBooksApp : Form
    {
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

            BookRepo repo = new BookRepo();
            repo.AddBook(book);
        }
    }
}
