﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string BookName { get; set; }
        
    }
}
