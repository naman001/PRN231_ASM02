using BusinessObject;
using BusinessObject.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PublisherDAO
    {
        public static List<Publisher> GetPublishers()
        {
            var list = new List<Publisher>();
            try
            {
                using var context = new AppDbContext();
                list = context.Publishers.ToList();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return list;
        }
        public static Publisher FindPublisherById(int id)
        {
            Publisher p = new();
            try
            {
                using var context = new AppDbContext();
                p = context.Publishers.SingleOrDefault(x => x.pub_id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return p;
        }
        public static void AddPublisher(Publisher publisher)
        {
            try
            {
                using var context = new AppDbContext();
                context.Publishers.Add(publisher);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdatePublisher(Publisher publisher)
        {
            try
            {
                using var context = new AppDbContext();
                context.Entry<Publisher>(publisher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeletePublisher(Publisher publisher)
        {
            try
            {
                using var context = new AppDbContext();
                var publi = context.Publishers.SingleOrDefault(c => c.pub_id == publisher.pub_id);
                context.Publishers.Remove(publi);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
