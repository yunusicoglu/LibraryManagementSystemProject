﻿using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<BookDetailDto> GetBookDetails()
        {
            return _bookDal.GetBookDetails();
        }

        public Book GetById(int bookId)
        {
            return _bookDal.Get(b=>b.BookId == bookId);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
