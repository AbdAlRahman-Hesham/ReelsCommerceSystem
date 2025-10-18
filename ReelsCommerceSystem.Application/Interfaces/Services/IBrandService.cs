using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IBrandService
    {
         Task<string?> GetBrandPolicyAsync(int brandId);
    }
}
