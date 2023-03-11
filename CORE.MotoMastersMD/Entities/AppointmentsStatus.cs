using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.Entities
{
    public partial class AppointmentsStatus
    {
        public AppointmentsStatus()
        {
            Appointments = new HashSet<Appointments>();
        }

        public decimal StatusId { get; set; }
        public string AppointmentsStatus1 { get; set; }

        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
