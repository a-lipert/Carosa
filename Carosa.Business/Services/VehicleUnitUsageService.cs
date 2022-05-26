using Carosa.Core.Database;
using Carosa.Core.Repository;
using Carosa.Entities;

namespace Carosa.Business.Services
{
    public class VehicleUnitUsageService : IRepository<VehicleUnitUsage>
    {
        DatabaseContext _context = new DatabaseContext();

        public VehicleUnitUsage Get(int vehicleUnitUsageEntity)
        {
            return _context.VehicleUnitUsages.Find(vehicleUnitUsageEntity);
        }

        public bool Create(VehicleUnitUsage vehicleUnitUsageEntity)
        {
            _context.VehicleUnitUsages.Add(vehicleUnitUsageEntity);
            return true;
        }

        public bool Remove(VehicleUnitUsage vehicleUnitUsageEntity)
        {
            _context.VehicleUnitUsages.Remove(vehicleUnitUsageEntity);
            return true;
        }

        public bool Update(VehicleUnitUsage vehicleUnitUsageEntity)
        {
            _context.VehicleUnitUsages.Update(vehicleUnitUsageEntity);
            return true;
        }
    }
}
