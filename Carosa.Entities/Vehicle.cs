namespace Carosa.Entities
{
    public class Vehicle : BaseEntity
    {
        public enum Type
        {
            Car,
            Bicycle,
            Motorbike,
            EScooter
        }
        public int VehicleBrandId { get; set; }
        public VehicleBrand VehicleBrand { get; set; }
        public int MaxSpeed { get; set; }
        public int ServiceAfterKm { get; set; }
        public decimal PriceWhenNew { get; set; }
        public decimal UsagePrice { get; set; }
        public enum UsagePriceType
        {
            Kilometers,
            Minutes
        }
    }
}
