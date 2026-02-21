using CourseManagement.Domain.Exceptions.CourseManagementExceptions;
using CourseManagement.Domain.Exceptions.PaymentManagementExceptions;

namespace CourseManagement.Domain.ValueObjects
{
    public record Amount
    {
        public decimal Value { get; }

        public Amount(decimal value)
        {
            if (value < 0)
            {
                throw new InvalidAmountException();
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator decimal(Amount amount) => amount.Value;

        // For Create New Instance
        public static implicit operator Amount(decimal amount) => new(amount);
    }
}
