using BusinessObject;
using BusinessObject.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookDAO
    {
        public static List<Book> GetAllBooks()
        {
            var list = new List<Book>();
            try
            {
                using var context = new AppDbContext();
                list = context.Books.ToList();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return list;
        }
        public static Book FindBookById(int id)
        {
            Book b = new();
            try
            {
                using var context = new AppDbContext();
                b = context.Books.SingleOrDefault(x => x.book_id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return b;
        }
        public static void AddBook(Book book)
        {
            try
            {
                using var context = new AppDbContext();
                context.Books.Add(book);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void UpdateBook(Book book)
        {
            try
            {
                using var context = new AppDbContext();
                context.Entry<Book>(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void DeleteBook(Book book)
        {
            try
            {
                using var context = new AppDbContext();
                var boo = context.Books.SingleOrDefault(c => c.book_id == book.book_id);
                context.Books.Remove(boo);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
