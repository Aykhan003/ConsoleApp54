namespace ConsoleApp54.Methods;

public class OrderItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public void DeepCopy(OrderItem source)
    {
        ProductId = source.ProductId;
        ProductName = source.ProductName;
        Price = source.Price;
        Quantity = source.Quantity;
    }
    public OrderItem(int productId, string productName, decimal price, int quantity)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }
}
