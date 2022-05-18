namespace Carosa.Entities
{
    public class VehicleUnit : BaseEntity
    {
        public int VehicleId { get; set; }
        public int FirstUsageAt { get; set; } 
        public double CurrentLatitude { get; set; }
        public double CurrentLongitude { get; set; }
        public int NextService { get; set; }
        public int? ReportedBroken { get; set; }
    }
}
