using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.DTOs
{
    public partial class ProductsDTO
    {

        public decimal ProductId { get; set; }
        public decimal IdxCategorie { get; set; }
        public string Product { get; set; }
        public double CostByUnit { get; set; }
        public decimal Quantity { get; set; }
        public bool Status { get; set; }

    }
}
