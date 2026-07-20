using ReelsCommerceSystem.Domain.Entities.CartEntities;

namespace ReelsCommerceSystem.Application.Interfaces.Services;
public interface ICartCacheService
{
    public Cart? GetCart(string userId);

    public void SaveCart(string userId, Cart cart);

    public void ClearCart(string userId);
    public void ClearCartBrand(string userId, int brandId);

}