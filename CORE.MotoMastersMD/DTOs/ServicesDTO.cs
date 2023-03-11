using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.DTOs
{
    public partial class ServicesDTO
    {

        public decimal ServiceId { get; set; }
        public string Service { get; set; }
        public string Description { get; set; }
        public double? RegularCost { get; set; }
        public bool Status { get; set; }
    }
}
