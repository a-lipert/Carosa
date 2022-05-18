using Carosa.Entities.Enums;

namespace Carosa.Entities
{
    public class Vehicle : BaseEntity
    {
        public VehicleType VehicleType { get; set; }
        public int VehicleBrandId { get; set; }
        public VehicleBrand VehicleBrand { get; set; }
        public int MaxSpeed { get; set; }
        public int ServiceAfterKm { get; set; }
        public decimal PriceWhenNew { get; set; }
        public decimal UsagePrice { get; set; }
        public UsagePriceType UsagePriceType { get; set; }
        public VehicleUnit VehicleUnit { get; set; }
       
    }
}
