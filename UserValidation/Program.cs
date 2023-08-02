using UserValidation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("UC1 First_Name :");
        ValidationUser firstname = new ValidationUser();
        firstname.uc1Validation("Nithin");

        Console.WriteLine("UC2 Last_Name :");
        ValidationUser lastname = new ValidationUser();
        lastname.uc2Validation("Reddy");

        Console.WriteLine("UC3 Email");
        ValidationUser email = new ValidationUser();
        email.uc3Validation("nithin@reddy.com");

        Console.WriteLine("UC4 PhoneNumber");
        ValidationUser num = new ValidationUser();
        num.uc4Validation("91 1234567890");

        Console.WriteLine("UC5 Password");
        ValidationUser pass = new ValidationUser();
        pass.uc5Validation("Qwerty12");

    }

}