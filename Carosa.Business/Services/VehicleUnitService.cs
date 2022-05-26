using Carosa.Core.Database;
using Carosa.Core.Repository;
using Carosa.Entities;

namespace Carosa.Business.Services
{
    public class VehicleUnitService : IRepository<VehicleUnit>
    {
        DatabaseContext _context = new DatabaseContext();

        public VehicleUnit Get(int vehicleUnitEntity)
        {
            return _context.VehicleUnits.Find(vehicleUnitEntity);
        }

        public bool Create(VehicleUnit vehicleUnitEntity)
        {
            _context.VehicleUnits.Add(vehicleUnitEntity);
            return true;
        }

        public bool Remove(VehicleUnit vehicleUnitEntity)
        {
            _context.VehicleUnits.Remove(vehicleUnitEntity);
            return true;
        }

        public bool Update(VehicleUnit vehicleUnitEntity)
        {
            _context.VehicleUnits.Update(vehicleUnitEntity);
            return true;
        }
    }
}
