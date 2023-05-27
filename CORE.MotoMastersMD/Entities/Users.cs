using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.Entities
{
    public partial class Users
    {
        public Users()
        {
            Appointments = new HashSet<Appointments>();
        }

        public decimal UserId { get; set; }
        public decimal IdxUserType { get; set; }
        public decimal IdxPersonalData { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; }
        public byte[] Photo { get; set; }
        public virtual PersonalData IdxPersonalDataNavigation { get; set; }
        public virtual UsersType IdxUserTypeNavigation { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
