using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 2, 10, 5, 3, 6, 7 };
                Console.WriteLine("Please enter what number you would like each number in the list to be divided by: ");
                int user_number = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int result = number / user_number;
                    Console.WriteLine(result);
                }
                Console.ReadLine();
            }
            catch (FormatException ex) // Catch exception when non-numbers are entered
            {
                Console.WriteLine("Please only enter whole numbers, thank you.");
            }
            catch (DivideByZeroException ex) // Catch exception when user tries to divide by 0
            {
                Console.WriteLine("Please do no try to divide by 0, thank you.");
            }
            catch (Exception ex) // Catch all other exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
