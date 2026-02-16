using CourseManagement.Domain.Exceptions.CourseManagementExceptions;

namespace CourseManagement.Domain.ValueObjects
{
    public record VideoUrl
    {

        public string Value { get; }

        public VideoUrl(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new VideoUrlNullOrEmptyException();
            }

            if (value.Length > 50)
            {
                throw new InvalidVideoUrlLengthException();
            }

            if (!value.EndsWith(".mp4"))
            {
                throw new InvalidVideoExtentionException();
            }

            Value = value;
        }

        // return value ( Guid )
        public static implicit operator string(VideoUrl videoUrl) => videoUrl.Value;

        // For Create New Instance
        public static implicit operator VideoUrl(string videoUrl) => new(videoUrl);
    }
}
