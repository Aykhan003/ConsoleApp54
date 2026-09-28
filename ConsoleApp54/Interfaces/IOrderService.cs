using ConsoleApp54.Methods;

namespace ConsoleApp54.Interfaces;

public interface IOrderService
{
    public OrderItem AddOrderItem(int productId, string productName, decimal price, int quantity);
    public void RemoveOrderItem(int productId);
    public void UpdateOrderItem(OrderItem orderItem);
    public List<OrderItem> GetOrderItems();
}
