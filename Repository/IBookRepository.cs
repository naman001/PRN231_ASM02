using BusinessObject;
using System.Collections.Generic;

namespace Repository
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        Book GetBookById(int id);
        void UpdateBook(Book Book);
        void DeleteBook(Book Book);
        List<Book> GetBooks();
    }
}