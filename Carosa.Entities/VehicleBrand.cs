using System.ComponentModel.DataAnnotations;

namespace Carosa.Entities
{
    public class VehicleBrand : BaseEntity
    {
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        [StringLength(3)]
        public string CountryOfOriginIso { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }

    }
}
