using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class BrandService(IUnitOfWork _unitOfWork) : IBrandService
    {
        public async Task<string?> GetBrandPolicyAsync(int brandId)

        {

            var brandRepo = _unitOfWork.Repository<Brand>();

            var spec = new BrandByIdSpec(brandId);
            var brand = await brandRepo.GetWithSpecAsync(spec);
            if (brand == null)
                return null;
            return brand.ReturnPolicyAsHtml;

        }
    }
}
