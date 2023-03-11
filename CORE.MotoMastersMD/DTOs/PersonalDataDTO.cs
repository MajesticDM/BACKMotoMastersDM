using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.DTOs
{
    public partial class PersonalDataDTO
    {

        public decimal PersonalDataId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public bool Status { get; set; }
    }
}
