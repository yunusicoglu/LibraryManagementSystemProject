using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{    public class Member : IEntity
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
    }
}
