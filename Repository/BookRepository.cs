using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookRepository : IBookRepository
    {
        public void AddBook(Book book) => BookDAO.AddBook(book);    
        public void DeleteBook(Book Book) => BookDAO.DeleteBook(Book);
        public Book GetBookById(int id) => BookDAO.FindBookById(id);
        public List<Book> GetBooks() => BookDAO.GetAllBooks();
        public void UpdateBook(Book book) => BookDAO.UpdateBook(book);
    }
}