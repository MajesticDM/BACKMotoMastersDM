using CORE.MotoMastersMD.Entities;
using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.DTOs
{
    public partial class SoldProductsDTO
    {
        public decimal IdSoldProduct { get; set; }
        public decimal? IdxServiceGiven { get; set; }
        public decimal? IdxProduct { get; set; }
        public decimal? Quantity { get; set; }
        public double? TotalCost { get; set; }

    }
}
