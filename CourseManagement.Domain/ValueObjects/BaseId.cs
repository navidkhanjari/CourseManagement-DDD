
using CourseManagement.Domain.Exceptions;

namespace CourseManagement.Domain.ValueObjects
{
    //Value Objects should be Immutable 
    public record BaseId
    {
        public Guid Value { get; }

        public BaseId(Guid value)
        {
            //اعتبار سنجی ها در داخل سازنده انجام میشود

            if (value == Guid.Empty)
            {
                throw new BaseIdNullException();
            }

            Value = value;
        }


        // return value ( Guid )
        public static implicit operator Guid(BaseId id) => id.Value;

        // For Create New Instance
        public static implicit operator BaseId(Guid id) => new(id);
    }
}
