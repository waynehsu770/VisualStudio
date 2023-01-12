using System;


namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            string weight = Console.ReadLine();
            int package_weight = Convert.ToInt32(weight);
            if (package_weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Console.WriteLine("Please enter the package width:");
            string width = Console.ReadLine();
            int package_width = Convert.ToInt32(width);
            Console.WriteLine("Please enter the package height:");
            string height = Console.ReadLine();
            int package_height = Convert.ToInt32(height);
            Console.WriteLine("Please enter the package length:");
            string length = Console.ReadLine();
            int package_length = Convert.ToInt32(length);
            int package_dimensions = package_width + package_height + package_length;
            if (package_dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            int package_cost = ((package_width * package_height * package_length) * package_weight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: " + "$" + package_cost.ToString() + ".\nThank you!");
            Console.ReadLine();
        }
    }
}
