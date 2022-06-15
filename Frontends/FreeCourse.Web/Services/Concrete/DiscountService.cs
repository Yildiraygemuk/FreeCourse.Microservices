using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models.Discounts;
using FreeCourse.Web.Services.Abstract;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Concrete
{
    public class DiscountService : IDiscountService
    {
        private readonly HttpClient _httpClient;

        public DiscountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<DiscountVm> GetDiscount(string discountCode)
        {
            var response = await _httpClient.GetAsync($"discount/GetByCode/{discountCode}");
            if (!response.IsSuccessStatusCode)
                return null;
            var discount = await response.Content.ReadFromJsonAsync<Response<DiscountVm>>();
            return discount.Data;
        }
    }
}
