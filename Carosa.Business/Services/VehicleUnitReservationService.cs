using Carosa.Core.Database;
using Carosa.Core.Repository;
using Carosa.Entities;

namespace Carosa.Business.Services
{
    public class VehicleUnitReservationService : IRepository<VehicleUnitReservation>
    {
        DatabaseContext _context = new DatabaseContext();

        public VehicleUnitReservation Get(int vehicleUnitReservationEntity)
        {
            return _context.VehicleUnitReservations.Find(vehicleUnitReservationEntity);
        }

        public bool Create(VehicleUnitReservation vehicleUnitReservationEntity)
        {
            _context.VehicleUnitReservations.Add(vehicleUnitReservationEntity);
            return true;
        }

        public bool Remove(VehicleUnitReservation vehicleUnitReservationEntity)
        {
            _context.VehicleUnitReservations.Remove(vehicleUnitReservationEntity);
            return true;
        }

        public bool Update(VehicleUnitReservation vehicleUnitReservationEntity)
        {
            _context.VehicleUnitReservations.Update(vehicleUnitReservationEntity);
            return true;
        }
    }
}