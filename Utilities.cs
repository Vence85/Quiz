using System.Diagnostics.Contracts;
using System.Globalization;
class Utilities
{
    public static string ValidateString()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Kontrollera så att du har rätt inmatning!");
            }
            else
            {
                return input;
            }

        }
    }
    public static int ValidateInteger()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Kontrollera så du har rätt inmatning!");
            }
        }
    }

}

