using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carosa.Entities
{
    public class VehicleUnitUsage : BaseEntity
    {
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public DateTimeOffset UsageEndedAt { get; set; }
        public int KilometersRun { get; set; }
        public Vehicle Vehicle { get; set; }
        public Customer Customer { get; set; }
}
}
