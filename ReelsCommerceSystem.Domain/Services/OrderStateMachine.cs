using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Services;

public static class OrderStateMachine
{
    private static readonly Dictionary<OrderStatus, HashSet<OrderStatus>> NormalTransitions = new()
    {
        [OrderStatus.Pending] = new() { OrderStatus.Processing },
        [OrderStatus.Processing] = new() { OrderStatus.Preparing },
        [OrderStatus.Preparing] = new() { OrderStatus.Packed },
        [OrderStatus.Packed] = new() { OrderStatus.Shipped },
        [OrderStatus.Shipped] = new() { OrderStatus.Delivered },
        [OrderStatus.Delivered] = new(),
        [OrderStatus.Cancelled] = new(),
        [OrderStatus.PendingCancellation] = new()
    };

    public static bool CanTransition(OrderStatus from, OrderStatus to)
    {
        return NormalTransitions.TryGetValue(from, out var allowed) && allowed.Contains(to);
    }

    public static bool CanUserCancel(OrderStatus status)
    {
        return status == OrderStatus.Pending;
    }

    public static bool CanBrandCancel(OrderStatus status)
    {
        return status switch
        {
            OrderStatus.Pending => true,
            OrderStatus.Processing => true,
            OrderStatus.Preparing => true,
            OrderStatus.Packed => true,
            _ => false
        };
    }

    public static bool RequiresAdminRefund(PaymentStatus paymentStatus, PaymentMethod paymentMethod)
    {
        return paymentStatus == PaymentStatus.Paid && paymentMethod != PaymentMethod.CashOnDelivery;
    }

    public static bool IsTerminal(OrderStatus status)
    {
        return status is OrderStatus.Delivered or OrderStatus.Cancelled or OrderStatus.PendingCancellation;
    }

    public static bool IsVisibleToRole(PaymentStatus paymentStatus, string role)
    {
        if (paymentStatus == PaymentStatus.Failed)
        {
            return role == "User";
        }
        return true;
    }

    public static bool IsBrandTransitionAllowed(OrderStatus from, OrderStatus to)
    {
        if (to == OrderStatus.Cancelled)
            return CanBrandCancel(from);

        return CanTransition(from, to);
    }

    public static bool IsShippingTransitionAllowed(OrderStatus from, OrderStatus to)
    {
        return (from == OrderStatus.Packed && to == OrderStatus.Shipped) ||
               (from == OrderStatus.Shipped && to == OrderStatus.Delivered);
    }
}
