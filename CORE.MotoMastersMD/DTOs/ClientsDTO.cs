namespace CORE.MotoMastersMD.DTOs
{
    public partial class ClientsDTO
    {
        public decimal ClientId { get; set; }
        public string CompleteName { get; set; }
        public decimal PhoneNumber { get; set; }
        public bool HasVehicle { get; set; }
        public string VehiclePlate { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleBrand { get; set; }
        public byte[] ClientPhoto { get; set; }
        public bool? RegularClient { get; set; }

    }
}
