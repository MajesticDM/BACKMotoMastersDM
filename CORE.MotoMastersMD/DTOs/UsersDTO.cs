using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.DTOs
{
    public partial class UsersDTO
    {

        public decimal UserId { get; set; }
        public decimal IdxUserType { get; set; }
        public decimal IdxPersonalData { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; }
        public byte[] Photo { get; set; }

    }
}
