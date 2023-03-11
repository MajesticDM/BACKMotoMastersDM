using System;
using System.Collections.Generic;

namespace CORE.MotoMastersMD.DTOs
{
    public partial class ServicesGivenDTO
    {

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
    }
}
