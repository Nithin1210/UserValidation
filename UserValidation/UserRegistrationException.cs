using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation
{

    public class UserRegistrationException : Exception
    {
        public bool valid;
        public enum ExceptionType
        {
            INVALID
        }
        public ExceptionType type;
        public UserRegistrationException(ExceptionType type, bool valid)
        {
            this.type = type;
            this.valid = valid;
        }
    }
    
}
