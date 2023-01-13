using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Jack", "Selena", "Anthony", "Justine", "Bob", "Angela" };
            Console.WriteLine("Please choose a number between 0 and 5: ");
            int names_choice = Convert.ToInt32(Console.ReadLine());
            if (names_choice > 5 || names_choice < 0)
            {
                Console.WriteLine("Invalid choice, application stopping. Please restart and enter a number between 0 and 5."); // If statement that runs if the user input is outside of 0-5
                Console.Read();
                System.Environment.Exit(0);
            } else
            {
                Console.WriteLine(names[names_choice]);
            }
            
            

            int[] lottery = new int[] { 2, 72, 23, 81, 12, 32, 44, 9, 68 };
            Console.WriteLine("Please choose a number between 0 and 8: ");
            int lottery_choice = Convert.ToInt32(Console.ReadLine());
            if (lottery_choice > 8 || lottery_choice < 0)
            {
                Console.WriteLine("Invalid choice, application stopping. Please restart and enter a number between 0 and 8."); // If statement that runs if the user input is outside of 0-8
                Console.Read();
                System.Environment.Exit(0);
            } else
            {
                Console.WriteLine(lottery[lottery_choice]);
            }
           
            
            List<string> nameList = new List<string>();
            nameList.Add("Michael");
            nameList.Add("Tyson");
            nameList.Add("Jackson");
            nameList.Add("Jordan");
            Console.WriteLine("Please choose a number between 0 and 3: ");
            int nameList_choice = Convert.ToInt32(Console.ReadLine());
            if (nameList_choice > 3 || nameList_choice < 0)
            {
                Console.WriteLine("Invalid choice, application stopping. Please restart and enter a number between 0 and 3."); // If statement that runs if the user input is outside of 0-3
                Console.Read();
                System.Environment.Exit(0);
            } else
            {
                Console.WriteLine(nameList[nameList_choice]);
            }
            


            Console.Read();
        }
    }
}
