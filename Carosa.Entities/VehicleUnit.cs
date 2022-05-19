using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carosa.Entities
{
    public class VehicleUnit : BaseEntity
    {
        public int VehicleId { get; set; }
        public DateTimeOffset FirstUsageAt { get; set; }
        public DateTimeOffset NextServiceAt { get; set; }
        public double CurrentLatitude { get; set; }
        public double CurrentLongitude { get; set; }
        public bool IsBroken { get; set; }
        public Vehicle Vehicle { get; set; }
        public VehicleUnitReservation VehicleUnitReservation { get; set; }

    }

}
