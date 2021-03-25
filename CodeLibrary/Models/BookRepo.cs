using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CodeLibrary.Models
{
    public class BookRepo
    {
        public BookRepo()
        {
        }

        public void AddBook(Book book)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("InsertBook", book, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
