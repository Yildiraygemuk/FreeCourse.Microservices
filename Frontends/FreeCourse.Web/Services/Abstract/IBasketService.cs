using FreeCourse.Web.Models.Baskets;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Abstract
{
    public interface IBasketService
    {
        Task<bool> SaveOrUpdate(BasketVm basketVm);
        Task<BasketVm> Get();
        Task<bool> Delete();
        Task AddBasketItem(BasketItemVm basketItemVm);
        Task<bool> RemoveBasketItem(string courseId);
        Task<bool> ApplyDiscount(string discountCode);
        Task<bool> CancelApplyDiscount();
    }
}
