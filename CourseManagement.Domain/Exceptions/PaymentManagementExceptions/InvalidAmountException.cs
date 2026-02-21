using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.PaymentManagementExceptions
{
    internal class InvalidAmountException : PaymentManagementException
    {
        public InvalidAmountException() : base("Amount can not be negative")
        {
        }
    }
}
