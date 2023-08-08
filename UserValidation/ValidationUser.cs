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
        string uc2lastname  = "^[A-Z]{1}[a-z]{2,}$";
        string uc3email     = "^[a-z0-9]{1,}[._+-]{0,1}[a-z0-9]{0,}[@]{1}[a-z0-9]{1,}[.]{1}[a-z]{2,}[.]{0,1}[a-z]{0,}$";  // program.cs -> for All emails Check !! 
        string uc4mobile    = "^[0-9]{2}[ ][0-9]{10}$";
        string uc5password  = "^[A-Z]{1}[a-z]{8,}[@#$]{1}[0-9]{1,8}$";

        public void uc1Validation(string input)
        {
            bool result = Regex.IsMatch(input, uc1firstname);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc2Validation(string input)
        {
            bool result = Regex.IsMatch(input, uc2lastname);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc3Validation(string input)
        {
            bool result = Regex.IsMatch(input, uc3email);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc4Validation(string input)
        {
            bool result = Regex.IsMatch(input, uc4mobile);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }
        public void uc5Validation(string input)
        {
            bool result = Regex.IsMatch(input, uc5password);
            if (result)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("! inValid");
        }


    }

}
