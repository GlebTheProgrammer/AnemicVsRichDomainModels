using Domain.Anemic.Orders;

namespace Application.Anemic.Orders
{
    public interface IOrderRepository
    {
        public Task<Order> GetByIdAsync(Guid id, CancellationToken token);
        public void Add(Order order);
    }
}
