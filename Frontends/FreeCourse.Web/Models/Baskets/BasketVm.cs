using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeCourse.Web.Models.Baskets
{
    public class BasketVm
    {
        public string UserId { get; set; }
        public string DiscountCode { get; set; }
        public int? DiscountRate { get; set; }
        private List<BasketItemVm> _basketItems { get; set; }
        public List<BasketItemVm> BasketItems
        {
            get
            {
                if (HasDiscount)
                {
                    _basketItems.ForEach(x =>
                    {
                        var discountPrice = x.Price * ((decimal)DiscountRate.Value / 100);
                        x.AppliedDiscount(Math.Round(x.Price - discountPrice, 2));
                    });
                }
                return _basketItems;
            }
            set
            {
                _basketItems = value;
            }
        }
        public decimal TotalPrice
        {
            get => BasketItems.Sum(x => x.GetCurrentPrice * x.Quantity);
        }
        public bool HasDiscount { get => !string.IsNullOrEmpty(DiscountCode); }
    }
}
