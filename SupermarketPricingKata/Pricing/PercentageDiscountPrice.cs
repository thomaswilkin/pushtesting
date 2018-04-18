using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricingKata.Pricing
{
    public class PercentageDiscountPrice : Price
    {
        private readonly int _perQuantity;
        private readonly decimal _absoluteDiscountPerQuantity;

        public PercentageDiscountPrice(decimal unitPrice, decimal quantity, int percentageDiscount, int perQuantity) 
            : base(unitPrice, quantity)
        {
            _perQuantity = perQuantity;

            decimal discountPercentageMultiplier = percentageDiscount/(decimal)100;
            decimal totalPricePerDiscountQuantity = UnitPrice * _perQuantity;
            _absoluteDiscountPerQuantity = totalPricePerDiscountQuantity * discountPercentageMultiplier;
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() - GetDiscount();
        }

        public override decimal GetDiscount()
        {
            return (Quantity / _perQuantity) * _absoluteDiscountPerQuantity;
        }
    }
}
