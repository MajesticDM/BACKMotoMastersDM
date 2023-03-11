using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.Entities
{
    public partial class UsersType
    {
        public UsersType()
        {
            Users = new HashSet<Users>();
        }

        public decimal UserTypeId { get; set; }
        public string UserType { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
