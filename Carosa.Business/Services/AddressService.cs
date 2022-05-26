using Carosa.Core.Database;
using Carosa.Core.Repository;
using Carosa.Entities;

namespace Carosa.Business.Services
{
    public class AddressService : IRepository<Address>
    {
        DatabaseContext _context = new DatabaseContext();

        public Address Get(int addressId)
        {
            return _context.Address.Find(addressId);
        }

        public bool Create(Address addressEntity)
        {
            _context.Address.Add(addressEntity);
            return true;
        }

        public bool Remove(Address addressEntity)
        {
            _context.Address.Remove(addressEntity);
            return true;
        }

        public bool Update(Address addressEntity)
        {
            _context.Address.Update(addressEntity);
            return true;
        }

    }
}
