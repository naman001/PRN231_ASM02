using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPublisherRepository
    {
        void AddPublisher(Publisher publisher);
        Publisher GetPublisherById(int id);
        void UpdatePublisher(Publisher publisher);
        void DeletePublisher(Publisher publisher);
        List<Publisher> GetPublishers();
    }
}