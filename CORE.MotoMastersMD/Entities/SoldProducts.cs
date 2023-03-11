using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.Entities
{
    
    public partial class SoldProducts
    {
        public decimal IdSoldProduct { get; set; }
        public decimal? IdxServiceGiven { get; set; }
        public decimal? IdxProduct { get; set; }
        public decimal? Quantity { get; set; }
        public double? TotalCost { get; set; }

        public virtual Products IdxProductNavigation { get; set; }
        public virtual ServicesGiven IdxServiceGivenNavigation { get; set; }
    }
}
