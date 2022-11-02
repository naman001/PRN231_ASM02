using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        public void AddAuthor(Author author) => AuthorDAO.AddAuthor(author);
        public void DeleteAuthor(Author author) => AuthorDAO.DeleteAuthor(author);
        public Author GetAuthorById(int id) => AuthorDAO.FindAuthorById(id);
        public List<Author> GetAuthors() => AuthorDAO.GetAuthors();
        public void UpdateAuthor(Author author) => AuthorDAO.UpdateAuthor(author);
    }
}
