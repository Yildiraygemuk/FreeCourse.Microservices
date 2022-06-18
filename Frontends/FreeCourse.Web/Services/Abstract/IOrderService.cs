using FreeCourse.Web.Models.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Abstract
{
    public interface IOrderService
    {
        /// <summary>
        /// Senkron iletişim - direk order mikroservisine istek yapacak
        /// </summary>
        /// <param name="checkoutInfoInput"></param>
        /// <returns></returns>
        Task<OrderCreatedVm> CreateOrder(CheckoutInfoInput checkoutInfoInput);
        /// <summary>
        /// Asenkron iletişim - sipariş bilgilerini rabbitMQ'ya gönderecek
        /// </summary>
        /// <param name="checkoutInfoInput"></param>
        /// <returns></returns>
        Task SuspendOrder(CheckoutInfoInput checkoutInfoInput);
        Task<List<OrderVm>> GetOrder();
    }
}
