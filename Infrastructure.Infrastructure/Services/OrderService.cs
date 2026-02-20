using ReelsCommerceSystem.Application.DTOs.Response.Order;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class OrderService : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;

    public OrderService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<UserOrdersResDto> GetUserOrdersAsync(string userId)
    {
        var orders = await _unitOfWork.Repository<Order>().GetAllAsync();
        var userOrders = orders.Where(o => o.UserId == userId).ToList();

        var response = new UserOrdersResDto();

        foreach (var order in userOrders)
        {
            var dto = new OrderResDto
            {
                Id = order.Id,
                CreatedAt = order.CreatedAt,
                TotalAmount = order.TotalAmount,
                OrderStatus = order.OrderStatus,
                PaymentStatus = order.PaymentStatus
            };

            if (order.OrderStatus == OrderStatus.Deliverd)
            {
                response.Completed.Add(dto);
            }
            else if (order.OrderStatus == OrderStatus.Cancelled)
            {
                response.Issues.Add(dto);
            }
            else
            {
                response.Active.Add(dto); // Pending, Processing, Shipped, Preparing, Packed
            }
        }

        return response;
    }

    public async Task<OrderDetailResDto?> GetOrderByIdAsync(string userId, int orderId)
    {
        var order = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => o.Id == orderId && o.UserId == userId)
            .Select(o => new OrderDetailResDto
            {
                Id = o.Id,
                CreatedAt = o.CreatedAt,
                OrderStatus = o.OrderStatus,
                TrackingNumber = o.Tracking != null ? o.Tracking.TrackingNumber : null,
                OrderInfo = new OrderInfoResDto
                {

                    ShippingAddress = o.Address != null 
                        ? $"{o.Address.Street}, {o.Address.City}" 
                        : null,
                    PaymentMethod = o.PaymentMethod,
                    DeliveryMethod = o.DeliveryMethod,
                    Discount = o.DiscountAmount,
                    TotalAmount = o.TotalAmount
                },

                Items = o.OrderProducts.Select(op => new OrderItemResDto
                {
                    Name = op.Product.Name,
                    Color = op.Color,
                    Description = op.Product.Description,
                    ImageUrl = op.Product.MediaUrl,
                    Size = op.Size,
                    Quantity = op.Quantity,
                    Price = op.FinalPrice
                }).ToList()
            }).FirstOrDefaultAsync();

        return order;
    }
}
