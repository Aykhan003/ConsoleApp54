namespace ConsoleApp54.Exceptions;

public class StockUnavailableException : Exception
{
    public StockUnavailableException(string message) : base(message)
    {
    }
}
