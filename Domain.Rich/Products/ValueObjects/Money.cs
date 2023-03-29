namespace Domain.Rich.Products.ValueObjects
{
    public record Money
    {
        private const decimal MAX_AMOUNT = 9999;

        private Money(decimal value) => Value = value;

        public decimal Value { get; init; }

        public static Money? Create(decimal value)
        {
            if (value is <= 0 or > MAX_AMOUNT)
            {
                return null;
            }

            return new Money(value);
        }
    }
}
