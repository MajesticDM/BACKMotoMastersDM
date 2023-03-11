using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.Entities
{
    public partial class ServicesGiven
    {
        public ServicesGiven()
        {
            SoldProducts = new HashSet<SoldProducts>();
        }

        public decimal ServiceGivenId { get; set; }
        public decimal IdxService { get; set; }
        public decimal IdxClient { get; set; }
        public bool ClientLeftKeys { get; set; }
        public string KeysAppearance { get; set; }
        public bool? DifferentVehicle { get; set; }
        public string VehiclePlate { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleBrand { get; set; }
        public double? AditionalCost { get; set; }
        public double? TotalCost { get; set; }
        public DateTime DateProvisionService { get; set; }

        public virtual Clients IdxClientNavigation { get; set; }
        public virtual Services IdxServiceNavigation { get; set; }
        public virtual ICollection<SoldProducts> SoldProducts { get; set; }
    }
}
