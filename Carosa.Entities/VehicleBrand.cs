using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carosa.Entities
{
    public class VehicleBrand : BaseEntity
    {
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        [StringLength(3)]
        public string CountryOfOriginIso { get; set; }
    }
}
