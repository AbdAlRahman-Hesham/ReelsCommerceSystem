using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Application.DTOs.Request.Product
{
    public class ProductInformationReq
    {
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;

        public InformationType Type { get; set; }

        public string? Group { get; set; }

        public int DisplayOrder { get; set; }
    }
}
