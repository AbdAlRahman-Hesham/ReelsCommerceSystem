namespace ReelsCommerceSystem.Application.Exceptions;

public sealed class OrderNotVisibleException : Exception
{
    public OrderNotVisibleException(string message) : base(message)
    {
    }
}
