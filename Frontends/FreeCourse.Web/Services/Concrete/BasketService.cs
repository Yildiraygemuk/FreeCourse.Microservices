using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models.Baskets;
using FreeCourse.Web.Services.Abstract;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Concrete
{
    public class BasketService : IBasketService
    {
        private readonly HttpClient _httpClient;

        public BasketService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddBasketItem(BasketItemVm basketItemVm)
        {
            var basket = await Get();
            if(basket != null)
            {
                if(!basket.BasketItems.Any(x=> x.CourseId == basketItemVm.CourseId))
                {
                    basket.BasketItems.Add(basketItemVm);
                }
            }
            else
            {
                basket = new BasketVm();
                basket.BasketItems.Add(basketItemVm);
            }
            await SaveOrUpdate(basket);
        }

        public Task<bool> ApplyDiscount(string discountCode)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> CancelApplyDiscount()
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Delete()
        {
            var result = await _httpClient.DeleteAsync("basket");
            return result.IsSuccessStatusCode;
        }

        public async Task<BasketVm> Get()
        {
            var response = await _httpClient.GetAsync("basket");
            if (!response.IsSuccessStatusCode)
                return null;
            var basketVm = await response.Content.ReadFromJsonAsync<Response<BasketVm>>();
            return basketVm.Data;
        }

        public async Task<bool> RemoveBasketItem(string courseId)
        {
            var basket = await Get();
            if (basket == null)
                return false;
            var deleteBasketItem = basket.BasketItems.FirstOrDefault(x => x.CourseId == courseId);
            if (deleteBasketItem == null)
                return false;
            var deleteResult = basket.BasketItems.Remove(deleteBasketItem);
            if (!deleteResult)
                return false;
            if (!basket.BasketItems.Any())
                basket.DiscountCode = null;
            return await SaveOrUpdate(basket);
        }

        public async Task<bool> SaveOrUpdate(BasketVm basketVm)
        {
            var response = await _httpClient.PostAsJsonAsync<BasketVm>("basket", basketVm);
            throw new System.NotImplementedException();
        }
    }
}
