using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetAll();
        Author GetById(int authorId);
        void Add(Author author);
        void Delete(Author author);
        void Update(Author author);
    }
}
