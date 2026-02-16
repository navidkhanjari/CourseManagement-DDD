using Shared.Abstraction.Exceptions;

namespace CourseManagement.Domain.Exceptions.CourseManagementExceptions
{
    internal class VideoUrlNullOrEmptyException : CourseManagementException
    {
        public VideoUrlNullOrEmptyException() : base("VideoUrl can not be null or empty!")
        {
        }
    }

    internal class InvalidVideoExtentionException : CourseManagementException
    {
        public InvalidVideoExtentionException() : base("VideoUrl must be mp4!")
        {
        }
    }
}
