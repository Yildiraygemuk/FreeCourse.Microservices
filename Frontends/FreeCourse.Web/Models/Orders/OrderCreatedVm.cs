namespace FreeCourse.Web.Models.Orders
{
    public class OrderCreatedVm
    {
        public int OrderId { get; set; }

        public string Error { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
