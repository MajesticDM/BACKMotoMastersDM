using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.Entities
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public decimal CategorieId { get; set; }
        public string Categorie { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
