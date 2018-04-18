using NUnit.Framework;
using SupermarketPricingKata.Pricing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricingKata.Tests
{
    [TestFixture]
    public class PercentageDiscountPriceTests
    {
        [TestCase(2, 2, 10, 2, 3.6, TestName = "DiscountQuantityRequirementNotMet_NoDiscountApplied")]
        [TestCase(2, 2, 10, 2, 3.6, TestName = "SingleDiscountQuantity_DiscountAppliedCorrectly")]
        [TestCase(2, 4, 10, 2, 7.2, TestName = "MultipleDiscountQuantity_DiscountAppliedCorrectly")]
        public void Test(int unitPrice, int quantity, int percentageDiscount, int perQuantity, decimal expectedPrice)
        {
            var price = new PercentageDiscountPrice(unitPrice, quantity, percentageDiscount, perQuantity);

            var actualPrice = price.GetPrice();
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
