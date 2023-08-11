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

        public bool uc1Validation(string name)
        {
            if (Regex.IsMatch(name, uc1firstname))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("In valid");
                return false;
            }
        }
        public bool uc2Validation(string name)
        {
            if (Regex.IsMatch(name, uc2lastname))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("In valid");
                return false;
            }
        }
        public bool uc3Validation(string mail)
        {
            if (Regex.IsMatch(mail, uc3email))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("In valid");
                return false;
            }
        }
        public bool uc4Validation(string number)
        {
            if (Regex.IsMatch(number, uc4mobile))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("In valid");
                return false;
            }
        }
        public bool uc5Validation(string password)
        {
            if (Regex.IsMatch(password, uc5password))
            {
                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("In valid");
                return false;
            }
        }

    }

}
