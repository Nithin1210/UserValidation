using UserValidation;

public class Program
{
    static string[] allemails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };

    public static void Main(string[] args)
    {
        Console.WriteLine("UC1 First_Name :");
        ValidationUser firstname = new ValidationUser();
        firstname.uc1Validation("Nithin");

        Console.WriteLine("\nUC2 Last_Name :");
        ValidationUser lastname = new ValidationUser();
        lastname.uc2Validation("Reddy");

        Console.WriteLine("\nUC3 Email");
        ValidationUser email = new ValidationUser();
        email.uc3Validation("nithin@reddy.com");

        Console.WriteLine("\nUC4 PhoneNumber");
        ValidationUser num = new ValidationUser();
        num.uc4Validation("91 1234567890");

        Console.WriteLine("\nUC5 Password");
        ValidationUser pass = new ValidationUser();
        pass.uc5Validation("Qwertyuiop@123");

        Console.WriteLine("\nAll Emails check ! with ! Sample Emails !!");
        ValidationUser Email = new ValidationUser();
        foreach (string emails in allemails)
        {
            Console.WriteLine(emails);
            email.uc3Validation(emails);
        }

    }

}