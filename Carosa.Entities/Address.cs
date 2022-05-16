using System.ComponentModel.DataAnnotations;

namespace Carosa.Entities
{
    public class Address : BaseEntity
    {
        public string StreetName { get; set; }
        public int HouseNo { get; set; }
        public int ApartmentNo { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        [StringLength(3)]
        public string CountryIsoCode { get; set; }
    }
}
