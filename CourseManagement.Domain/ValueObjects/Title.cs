using CourseManagement.Domain.Exceptions.CourseManagementExceptions;

namespace CourseManagement.Domain.ValueObjects
{
    public record Title
    {

        public string Value { get; }

        public Title(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new TitleNullOrEmptyException();
            }

            if (value.Length > 50)
            {
                throw new InvalidTitleLengthException(50);
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator string(Title title) => title.Value;

        // For Create New Instance
        public static implicit operator Title(string title) => new(title);
    }
}
