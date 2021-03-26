using Dapper;
using System.Data;
using System.Data.SqlClient;

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
            param.Add("@Id", book.Id);                      //add parameters in param object
            param.Add("Title", book.Title);                 //add parameters in param object
            param.Add("@Author", book.Author);              //add parameters in param object
            param.Add("@Price", book.Price);                //add parameters in param object
            param.Add("@Description", book.Description);    //add parameters in param object
            param.Add("@CountryId", book.CountryId);        //add parameters in param object

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("InsertBook", param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
