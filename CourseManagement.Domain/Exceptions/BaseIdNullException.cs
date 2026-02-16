using Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Domain.Exceptions
{
    internal class BaseIdNullException : CourseManagementException
    {
        public BaseIdNullException() : base("Id can not be empty")
        {
        }
    }
}
