using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.ReelManagement
{
    public class GetReelForManagementRes
    {
        public string Title { get; set; } = null!;
        public string Status { get; set; } = null!;

        public string VideoUrl { get; set; } = null!;
        public string ThumbnailUrl { get; set; } = null!;

        public int LikesCount { get; set; }
        public bool IsLikedByCurrentUser { get; set; }
        public int CommentsCount { get; set; }

        public int ProductsCount { get; set; }

        public BrandForGetReelForManagementRes Brand { get; set; } = null!;

        public List<ProductForGetReelForManagementRes> Products { get; set; } = [];

        public List<CommentForGetReelForManagementRes> Comments { get; set; } = [];

    }

    public class BrandForGetReelForManagementRes
    {
        public int BrandId { get; set; }

        public string BrandName { get; set; } = null!;

        public string? LogoUrl { get; set; }

    }

    public class ProductForGetReelForManagementRes
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public int Rating { get; set; }
        public List<string> ImagesUrl { get; set; } = new();


    }

    public class CommentForGetReelForManagementRes
    {
        public int Id { get; set; }

        public string UserName { get; set; } = null!;

        public string? UserImage { get; set; }

        public string Comment { get; set; } = null!;

        public DateTime CreatedAt { get; set; }
        public int LikesCount { get; set; }
    }



}
