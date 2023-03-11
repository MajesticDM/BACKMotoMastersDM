using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.Entities
{
    public partial class Products
    {
        public Products()
        {
            SoldProducts = new HashSet<SoldProducts>();
        }

        public decimal ProductId { get; set; }
        public decimal IdxCategorie { get; set; }
        public string Product { get; set; }
        public double CostByUnit { get; set; }
        public decimal Quantity { get; set; }
        public bool Status { get; set; }

        public virtual Categories IdxCategorieNavigation { get; set; }
        public virtual ICollection<SoldProducts> SoldProducts { get; set; }
    }
}
