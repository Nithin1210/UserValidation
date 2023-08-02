using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserValidation
{
    public class ValidationUser
    {
        string uc1firstname = "^[A-Z]{1}[a-z]{2,}$";

        public void uc1Validation(string input)
        {
            bool result = Regex.IsMatch(input, uc1firstname);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
  

    }

}
