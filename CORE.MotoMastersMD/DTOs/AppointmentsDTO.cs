using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.DTOs
{
    public partial class AppointmentsDTO
    {
        public decimal ApptId { get; set; }
        public decimal? IdxClient { get; set; }
        public decimal IdxUserCreator { get; set; }
        public decimal IdxService { get; set; }
        public decimal IdxStatus { get; set; }
        public DateTime ApptDate { get; set; }
    }
}
