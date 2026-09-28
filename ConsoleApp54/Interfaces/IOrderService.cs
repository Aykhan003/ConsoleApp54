using ConsoleApp54.Methods;

namespace ConsoleApp54.Interfaces;

public interface IOrderService
{
    public void AddOrderItem(OrderItem orderItem);
    public void RemoveOrderItem(int productId);
    public void UpdateOrderItem(OrderItem orderItem);
    public List<OrderItem> GetOrderItems();
}
