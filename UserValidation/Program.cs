using UserValidation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("UC1 First_Name :");
        ValidationUser firstname = new ValidationUser();
        firstname.uc1Validation("Nithin");

    }

}