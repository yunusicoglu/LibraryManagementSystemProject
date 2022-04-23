using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, LibraryDbContext>, IBookDal
    {
        public List<BookDetailDto> GetBookDetails()
        {
            using (LibraryDbContext context = new LibraryDbContext())
            {
                var result = from b in context.Books
                             join c in context.Categories
                             on b.CategoryId equals c.CategoryId
                             join a in context.Authors
                             on b.AuthorId equals a.AuthorId
                             select new BookDetailDto 
                             {   BookId = b.BookId, 
                                 BookName = b.BookName, 
                                 CategoryName = c.CategoryName,
                                 AuthorName = a.AuthorName
                             };
                return result.ToList();
            }
        }
    }
}
