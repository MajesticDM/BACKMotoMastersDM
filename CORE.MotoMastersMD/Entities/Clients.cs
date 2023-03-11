using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.Entities
{
    public partial class Clients
    {
        public Clients()
        {
            Appointments = new HashSet<Appointments>();
            ServicesGiven = new HashSet<ServicesGiven>();
        }

        public decimal ClientId { get; set; }
        public string CompleteName { get; set; }
        public decimal PhoneNumber { get; set; }
        public bool HasVehicle { get; set; }
        public string VehiclePlate { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleBrand { get; set; }
        public byte[] ClientPhoto { get; set; }
        public bool? RegularClient { get; set; }

        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<ServicesGiven> ServicesGiven { get; set; }
    }
}
