using FreeCourse.Web.Models.FakePayments;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services
{
    public interface IPaymentService
    {
        Task<bool> ReceivePayment(PaymentInfoInput paymentInfoInput);
    }
}
