using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation
{
    public class Testing
    {
        ValidationUser userRegistration = new ValidationUser();
        public string userdetails(string uc1firstname, string uc2lastname, string uc3email, string uc4mobile, string uc5password)
        {
            if (userRegistration.uc1Validation(uc1firstname) && (userRegistration.uc2Validation(uc2lastname)) && (userRegistration.uc3Validation(uc3email)) && (userRegistration.uc4Validation(uc4mobile)) && (userRegistration.uc5Validation(uc5password)))
            {
                return "VALID FORMATE";
            }
            else
                return "INVALID FORMATE";
        }
    }
}
