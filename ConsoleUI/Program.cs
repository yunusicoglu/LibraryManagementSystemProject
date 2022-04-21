using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager(new EfBookDal());
            AuthorManager authorManager = new AuthorManager(new EfAuthorDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            authorManager.Add(new Author { AuthorName = "Michael Ende" });
            categoryManager.Add(new Category { CategoryName = "Roman" });
            bookManager.Add(new Book { AuthorId = 1, CategoryId = 1, BookName = "Bitmeyecek Öykü" });
            Console.WriteLine(bookManager.GetById(1).BookName);
        }
    }
}
