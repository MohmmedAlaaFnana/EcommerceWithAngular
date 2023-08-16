using EcommerceWithAngular.Models;

namespace EcommerceWithAngular.Services.Infrastructures
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomer(int id);

        void Insert(Customer customer);

        void Update(Customer customer);

        void Delete(int id);

        void Save();
    }
}
