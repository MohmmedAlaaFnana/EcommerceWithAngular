using EcommerceWithAngular.Models;

namespace EcommerceWithAngular.Services.Infrastructures
{
    public interface IOrder
    {
        IEnumerable<Order> GetOrders();

        Order GetOrder(int id);

        void Delete(int id);

        int Count();

        void Save();
    }
}
