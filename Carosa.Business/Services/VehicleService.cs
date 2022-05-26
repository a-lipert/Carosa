using Carosa.Core.Database;
using Carosa.Core.Repository;
using Carosa.Entities;

namespace Carosa.Business.Services
{
    public class VehicleService : IRepository<Vehicle>
    {
        DatabaseContext _context = new DatabaseContext();

        public Vehicle Get(int vehicleId)
        {
            return _context.Vehicles.Find(vehicleId);
        }

        public bool Create(Vehicle vehicleEntity)
        {
            _context.Vehicles.Add(vehicleEntity);
            return true;
        }

        public bool Remove(Vehicle vehicleEntity)
        {
            _context.Vehicles.Remove(vehicleEntity);
            return true;
        }

        public bool Update(Vehicle vehicleEntity)
        {
            _context.Vehicles.Update(vehicleEntity);
            return true;
        }

    }
}
