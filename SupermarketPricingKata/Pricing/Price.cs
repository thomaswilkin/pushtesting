namespace SupermarketPricingKata.Pricing
{
    public class Price
    {
        public Price(decimal unitPrice, decimal quantity)
        {
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        protected decimal UnitPrice { get; private set; }
        protected decimal Quantity { get; private set; }

        public void AddQuantity(decimal quantityToAdd)
        {
            Quantity = Quantity + quantityToAdd;
        }

        public virtual decimal GetPrice()
        {
            return Quantity * UnitPrice;
        }

        public virtual decimal GetDiscount()
        {
            return 0;
        }
    }
}
