namespace Carosa.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public Address InvoiceAddress { get; set; }
        public int? InvoiceAddressId { get; set; }
        public Address HomeAddress { get; set; }
        public int? HomeAddressId { get; set; }
        public bool InvoiceAddressSameAsHome { get; set; }
        public ICollection <VehicleUnitUsage> VehicleUnitUsage { get; set; }
        public ICollection<VehicleUnitReservation> VehicleUnitReservations { get; set; }
    }
}
