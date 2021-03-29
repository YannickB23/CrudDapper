using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper.Contrib.Extensions;

namespace CodeLibrary.Models
{
    public class BookRepo //: IBookRepo
    {
        //private IDbConnection dbConnection;

        //public BookRepo(string connString)
        //{
        //    this.dbConnection = new SqlConnection(connString);
        //}

        //public Book AddBook(Book book)
        //{
        //    var id = this.dbConnection.Insert(book);
        //    book.Id = (int)id;
        //    return book;
        //}

        public void AddBook(Book book) //this method adds new record in database using stored proc
        {
            DynamicParameters param = new DynamicParameters();  //create dynamic parameters
            param.Add("@Title", book.Title);                 //add parameters in param object
            param.Add("@Author", book.Author);              //add parameters in param object
            param.Add("@Price", book.Price);                //add parameters in param object
            param.Add("@Description", book.Description);    //add parameters in param object
            param.Add("@CountryId", book.CountryId);        //add parameters in param object

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("InsertBook", param, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Book> GetBooks()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                var books = connection.Query<Book>("GetAllBooks",
                    commandType: CommandType.StoredProcedure).ToList();

                return books;
            }
        }

        public void UpdateBook(Book book)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", book.Id);
            param.Add("@Title", book.Title);
            param.Add("@Author", book.Author);
            param.Add("@Price", book.Price);
            param.Add("@Description", book.Description);
            param.Add("@CountryId", book.CountryId);

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("UpdateBook", param, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteBook(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("DeleteBook", new { id }, commandType: CommandType.StoredProcedure);
            }
        }

        #region MyRegion Optie 2 voor delete book
        //public void DeleteBook(int id)
        //{
        //    DynamicParameters param = new DynamicParameters();
        //    param.Add("@id", id);
        //    using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
        //    {
        //        connection.Execute("DeleteBook", param, commandType: CommandType.StoredProcedure);
        //    }
        //}
        #endregion

        public int AddBookReturnId(Book book)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", DbType.Int64, direction: ParameterDirection.Output);
            param.Add("@Title", book.Title);
            param.Add("@Author", book.Author);
            param.Add("@Price", book.Price);
            param.Add("@Description", book.Description);
            param.Add("@CountryId", book.CountryId);

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                var id = connection.Query<int>("AddBookReturnId", param, commandType: CommandType.StoredProcedure).Single();
                return id;
            }
        }
    }
}
