using CourseManagement.Domain.Exceptions.CourseManagementExceptions;

namespace CourseManagement.Domain.ValueObjects
{
    public record Biography
    {

        public string Value { get; }

        public Biography(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new BiographyNullOrEmptyException();
            }

            if (value.Length > 300)
            {
                throw new InvalidBiographyLengthException();
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator string(Biography biography) => biography.Value;

        // For Create New Instance
        public static implicit operator Biography(string biography) => new(biography);
    }
}
