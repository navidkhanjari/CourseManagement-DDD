using CourseManagement.Domain.Exceptions.CourseManagementExceptions;

namespace CourseManagement.Domain.ValueObjects
{
    public record Price
    {

        public decimal Value { get; }

        public Price(decimal value)
        {
            if (value < 0)
            {
                throw new InvalidPriceException();
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator decimal(Price price) => price.Value;

        // For Create New Instance
        public static implicit operator Price(decimal price) => new(price);
    }
}
