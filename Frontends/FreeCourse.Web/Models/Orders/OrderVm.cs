using System;
using System.Collections.Generic;

namespace FreeCourse.Web.Models.Orders
{
    public class OrderVm
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        //Ödeme geçmişimde adress alanına ihtiyaç olmadığından dolayı alınmadı
        // public AddressDto Address { get; set; }

        public string BuyerId { get; set; }

        public List<OrderItemVm> OrderItems { get; set; }
    }
}
