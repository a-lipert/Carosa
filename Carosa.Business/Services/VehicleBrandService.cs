using Carosa.Core.Database;
using Carosa.Core.Repository;
using Carosa.Entities;

namespace Carosa.Business.Services
{
    public class VehicleBrandService : IRepository<VehicleBrand>
    {
        DatabaseContext _context = new DatabaseContext();

        public VehicleBrand Get(int vehicleBrandId)
        {
            return _context.VehicleBrands.Find(vehicleBrandId);
        }

        public bool Create(VehicleBrand vehicleBrandEntity)
        {
            _context.VehicleBrands.Add(vehicleBrandEntity);
            return true;
        }

        public bool Remove(VehicleBrand vehicleBrandEntity)
        {
            _context.VehicleBrands.Remove(vehicleBrandEntity);
            return true;
        }

        public bool Update(VehicleBrand vehicleBrandEntity)
        {
            _context.VehicleBrands.Update(vehicleBrandEntity);
            return true;
        }

    }
}
