using Dapper.Contrib.Extensions;
using System.Data;
using System.Data.SqlClient;

namespace CodeLibrary.Models
{
    public class BookRepo
    {
        private IDbConnection dbConnection;

        public BookRepo(string connString)
        {
            this.dbConnection = new SqlConnection(connString);
        }

        public Book AddBook(Book book)
        {
            var id = this.dbConnection.Insert(book);
            book.Id = (int) id;
            return book;
        }

        //public BookRepo()
        //{
        //}

        //public void AddBook(Book book)
        //{
        //    using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
        //    {
        //        connection.Execute("InsertBook", book, commandType: CommandType.StoredProcedure);
        //    }
        //}
    }
}
