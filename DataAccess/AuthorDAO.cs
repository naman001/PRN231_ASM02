using BusinessObject;
using BusinessObject.AppContext;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AuthorDAO
    {
        public static List<Author> GetAuthors()
        {
            var list = new List<Author>();
            try
            {
                using var context = new AppDbContext();
                list = context.Authors.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return list;
        }

        public static Author FindAuthorById(int id)
        {
            Author a = new();
            try
            {
                using var context = new AppDbContext();
                a = context.Authors.SingleOrDefault(x => x.author_id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return a;
        }

        public static void AddAuthor(Author author)
        {
            try
            {
                using var context = new AppDbContext();
                context.Authors.Add(author);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateAuthor(Author author)
        {
            try
            {
                using var context = new AppDbContext();
                context.Entry<Author>(author).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteAuthor(Author author)
        {
            try
            {
                using var context = new AppDbContext();
                var auth = context.Authors.SingleOrDefault(c => c.author_id == author.author_id);
                context.Authors.Remove(auth);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
