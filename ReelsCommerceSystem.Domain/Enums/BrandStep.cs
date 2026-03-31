using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Enums
{
    public  enum BrandStep
    {
        NONE=0,
        INFO = 1 ,
        VERIFICATION = 2 ,
        PENDING_REVIEW = 3,
        COMPLETED = 4
    }
}
