using Domain.Rich.Products.ValueObjects;

namespace Domain.Rich.Products
{
    public sealed class Product
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; } = string.Empty;

        public Money Money { get; private set; }

        public Sku Sku { get; private set; }

        private Product()
        {     
        }

        public static Product? Create(string name, decimal money, string sku)
        {
            var moneyVal = Money.Create(money);
            var skuVal = Sku.Create(sku);

            if (moneyVal is null || skuVal is null)
            {
                return null;
            }

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = name,
                Money = moneyVal,
                Sku = skuVal
            };

            return product;
        }
    }
}
