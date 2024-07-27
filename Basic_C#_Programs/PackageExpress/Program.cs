using System;

class PackageExpress
{
    static void Main(string[] args)
    {
        // This is the Welcome Message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Input Package Weight First
        Console.Write("Please enter the package weight: ");
        double weight = double.Parse(Console.ReadLine()); // Convert user input to double

        // Check for oversized weight if greater than 50, exit program,
        if (weight > 50)
        {
        // The program will exit if the package is too big.
        Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
         return; 
        
        }

        // Get package width
        Console.Write("Please enter the package width: ");
        double width = double.Parse(Console.ReadLine());

        // Get package height
        Console.Write("Please enter the package height: ");
        double height = double.Parse(Console.ReadLine());

        //Get package length
        Console.Write("Please enter the package length: ");
        double length = double.Parse(Console.ReadLine());

        // Check for oversized dimensions
        double totalDimensions = width + height + length;
        if (totalDimensions > 50)
        {
         // Exit program if dimensions are too large
         Console.WriteLine("Package too big to be shipped via Package Express.");
        return; 
        }

        // Calculated quote total divided by 100
        double volume = width * height * length;
        double quote = (volume * weight) / 100;

        // Displayed quote total as a dollar amount
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}"); 

        Console.WriteLine("Thank you!");
    }
}