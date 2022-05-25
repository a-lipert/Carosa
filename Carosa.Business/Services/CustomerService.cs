using Carosa.Entities;
using Carosa.Core.Repository;
using Carosa.Core.Database;

namespace Carosa.Business.Services
{

    public class CustomerService : IRepository<Customer>
    {
        DatabaseContext _context = new DatabaseContext();

        public Customer Get(int customerId)
        {
            return _context.Customers.Find(customerId);
        }

        public bool Create(Customer customerEntity)
        {
            _context.Customers.Add(customerEntity);
            return true;
        }

        public bool Remove(Customer customerEntity)
        {
            _context.Customers.Remove(customerEntity);
            return true;
        }

        public bool Update(Customer customerEntity)
        {
            _context.Customers.Update(customerEntity);
            return true;
        }

    }
}
