using BusinessObject;
using System.Collections.Generic;

namespace Repository
{
    public interface IAuthorRepository
    {
        void AddAuthor(Author author);
        Author GetAuthorById(int id);
        void UpdateAuthor(Author author);
        void DeleteAuthor(Author author);
        List<Author> GetAuthors();
    }
}
