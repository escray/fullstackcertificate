using System.Drawing;
using Pastel;

class Program
{
    // Method to calculate the final price after a discount
    static double ApplyDiscount(double price, double discountPercentage)
    {
        if (discountPercentage >= 100 || discountPercentage < 0)
        {
            System.Console.WriteLine("The discount is invalid");
            return price;
        }
        // Answer key
        // double discountAmount = price * (discountPercentage / 100);
        // return price - discountAmount;
        return price * (100 - discountPercentage) / 100;
    }

    public static int FindMax(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            System.Console.WriteLine("The numbers has no items.");
            return 0;
        }
        // Answer Key
        // int max = int.MinValue;
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    public static void PrintColor()
    {
        var spectrum = new (string color, string letter)[]
        {
            ("#124542", "a"),
            ("#185C58", "b"),
            ("#1E736E", "c"),
            ("#248A84", "d"),
            ("#20B2AA", "e"),
            ("#3FBDB6", "f"),
            ("#5EC8C2", "g"),
            ("#7DD3CE", "i"),
            ("#9CDEDA", "j"),
            ("#BBE9E6", "k"),
        };

        Console.WriteLine(string.Join("", spectrum.Select(s => s.letter.Pastel(s.color))));
    }

    public static void Main()
    {
        PrintColor();

        double finalPrice = ApplyDiscount(1000, 15);
        Console.WriteLine("The final price is: " + finalPrice);

        int[] myNumbers = { -5, -10, -3, -8, -2 };
        int maxNumber = FindMax(myNumbers);
        Console.WriteLine("The maximum number is: " + maxNumber);
    }
}

// Console.WriteLine("Hello, World!".Pastel(Color.Green));

//     var spectrum = new (string color, string letter)[]
//     {
//         ("#124542", "a"),
//         ("#185C58", "b"),
//         ("#1E736E", "c"),
//         ("#248A84", "d"),
//         ("#20B2AA", "e"),
//         ("#3FBDB6", "f"),
//         ("#5EC8C2", "g"),
//         ("#7DD3CE", "i"),
//         ("#9CDEDA", "j"),
//         ("#BBE9E6", "k")
//     };

//     Console.WriteLine(string.Join("", spectrum.Select(s => s.letter.Pastel(s.color))));
