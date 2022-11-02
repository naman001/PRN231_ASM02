using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        public void AddPublisher(Publisher publisher) => PublisherDAO.AddPublisher(publisher);
        public void DeletePublisher(Publisher publisher) => PublisherDAO.DeletePublisher(publisher);
        public Publisher GetPublisherById(int id) => PublisherDAO.FindPublisherById(id);
        public List<Publisher> GetPublishers() => PublisherDAO.GetPublishers();
        public void UpdatePublisher(Publisher publisher) => PublisherDAO.UpdatePublisher(publisher);
    }
}
