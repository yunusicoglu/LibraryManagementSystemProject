﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IMemberService
    {
        List<Member> GetAll();
        Member GetById(int memberId);
        void Add(Member member);
        void Delete(Member member);
        void Update(Member member);
    }
}
