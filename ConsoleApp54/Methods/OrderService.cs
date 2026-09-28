using ConsoleApp54.Interfaces;

namespace ConsoleApp54.Methods;

internal class OrderService : IOrderService
{
    public OrderItem AddOrderItem(int productId, string productName, decimal price, int quantity)
    {
        return new OrderItem(productId, productName, price, quantity);
    }

    public List<OrderItem> GetOrderItems()
    {
        return new List<OrderItem>();
    }

    public void RemoveOrderItem(int productId)
    {
        throw new NotImplementedException();
    }

    public void UpdateOrderItem(OrderItem orderItem)
    {
        throw new NotImplementedException();
    }
}
