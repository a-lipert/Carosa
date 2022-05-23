using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carosa.Entities
{
    public class VehicleUnitReservation : BaseEntity
    {
        public int VehicleUnitId { get; set; }
        public int CustomerId { get; set; }
        public DateTimeOffset ReservedUntill { get; set; }
        public bool ReservationFulfilled { get; set; }
        public VehicleUnit VehicleUnit { get; set; }
        public Customer Customer { get; set; }
    }
}
