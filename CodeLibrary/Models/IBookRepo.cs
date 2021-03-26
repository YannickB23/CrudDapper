using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary.Models
{
    public interface IBookRepo
    {
        Book AddBook(Book book);
    }
}
