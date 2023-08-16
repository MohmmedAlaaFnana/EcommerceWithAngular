using EcommerceWithAngular.Data;
using EcommerceWithAngular.Models;
using EcommerceWithAngular.Services.Infrastructures;

namespace EcommerceWithAngular.Services.Repositories
{
    public class OrderRepository : IOrder
    {
        private ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Orders.Count();
        }

        public void Delete(int id)
        {
            var order = _context.Orders.FirstOrDefault(c => c.Id == id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

        public Order GetOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(c => c.Id == id);
            if (order != null)
            {
                return order;
            }
            return null;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
