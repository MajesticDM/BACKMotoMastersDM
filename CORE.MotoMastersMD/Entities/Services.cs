using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.Entities
{
    public partial class Services
    {
        public Services()
        {
            Appointments = new HashSet<Appointments>();
            ServicesGiven = new HashSet<ServicesGiven>();
        }

        public decimal ServiceId { get; set; }
        public string Service { get; set; }
        public string Description { get; set; }
        public double? RegularCost { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<ServicesGiven> ServicesGiven { get; set; }
    }
}
