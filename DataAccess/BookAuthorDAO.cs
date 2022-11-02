using BusinessObject;
using BusinessObject.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookAuthorDAO
    {
        public static List<BookAuthor> GetBookAuthors()
        {
            var list = new List<BookAuthor>();
            try
            {
                using var context = new AppDbContext();
                list = context.BookAuthors.ToList();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return list;
        }
        public static BookAuthor FindBookAuthorByBookAuthorId(int id)
        {
            
            BookAuthor ba = new();
            try
            {
                using var context = new AppDbContext();
                ba = context.BookAuthors.SingleOrDefault(x => x.author_id == id);
            } 
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ba;
        }
        
        public static BookAuthor FindAuthorByBookId(int id)
        {
            
            BookAuthor ba = new();
            try
            {
                using var context = new AppDbContext();
                ba = context.BookAuthors.SingleOrDefault(x => x.book_id == id);
            } 
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ba;
        }
    }
}
