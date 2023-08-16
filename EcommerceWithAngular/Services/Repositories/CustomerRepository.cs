using EcommerceWithAngular.Data;
using EcommerceWithAngular.Models;
using EcommerceWithAngular.Services.Infrastructures;

namespace EcommerceWithAngular.Services.Repositories
{
    public class CustomerRepository : ICustomer
    {
        private ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)

        {
            _context = context;
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }
        }

        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                return customer;
            }
            return null;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
        }
    }
}
