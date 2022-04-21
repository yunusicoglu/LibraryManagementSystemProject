﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int bookId);
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);

        List<BookDetailDto> GetBookDetails();
    }
}
