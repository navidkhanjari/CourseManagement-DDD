using CourseManagement.Domain.Exceptions.CourseManagementExceptions;

namespace CourseManagement.Domain.ValueObjects
{
    public record Description
    {

        public string Value { get; }

        public Description(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new DescriptionNullOrEmptyException();
            }

            if (value.Length > 700)
            {
                throw new InvalidDescriptionLengthException();
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator string(Description description) => description.Value;

        // For Create New Instance
        public static implicit operator Description(string description) => new(description);
    }
}
