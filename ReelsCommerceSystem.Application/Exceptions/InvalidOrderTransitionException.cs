namespace ReelsCommerceSystem.Application.Exceptions;

public sealed class InvalidOrderTransitionException : Exception
{
    public InvalidOrderTransitionException(string message) : base(message)
    {
    }
}
