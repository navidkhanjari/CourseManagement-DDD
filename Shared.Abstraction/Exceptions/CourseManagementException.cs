using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Abstraction.Exceptions
{

    /// abstract means =>  this class only for inheritance and could not be create a new instance

    public abstract class CourseManagementException : Exception
    {
        protected CourseManagementException(string message) : base(message)
        {

        }
    }
}
