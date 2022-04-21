using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class MemberManager : IMemberService
    {
        IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public void Add(Member member)
        {
            _memberDal.Add(member);
        }

        public void Delete(Member member)
        {
            _memberDal.Delete(member);
        }

        public List<Member> GetAll()
        {
            return _memberDal.GetAll();
        }

        public Member GetById(int memberId)
        {
            return _memberDal.Get(m=>m.MemberId==memberId);
        }

        public void Update(Member member)
        {
            _memberDal.Update(member);
        }
    }
}
