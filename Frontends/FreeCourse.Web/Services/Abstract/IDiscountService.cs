using FreeCourse.Web.Models.Discounts;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Abstract
{
    public interface IDiscountService
    {
        Task<DiscountVm> GetDiscount(string discountCode);
    }
}
