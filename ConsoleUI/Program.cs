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


            foreach (var bookDetails in bookManager.GetBookDetails())
            {
                Console.WriteLine("{0} - {1} - {2}", bookDetails.BookName,bookDetails.AuthorName, bookDetails.CategoryName);
            }

        }
    }
}
