using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.Entities
{
    public partial class Appointments
    {
        public decimal ApptId { get; set; }
        public decimal? IdxClient { get; set; }
        public decimal IdxUserCreator { get; set; }
        public decimal IdxService { get; set; }
        public decimal IdxStatus { get; set; }
        public DateTime ApptDate { get; set; }

        public virtual Clients IdxClientNavigation { get; set; }
        public virtual Services IdxServiceNavigation { get; set; }
        public virtual AppointmentsStatus IdxStatusNavigation { get; set; }
        public virtual Users IdxUserCreatorNavigation { get; set; }
    }
}
