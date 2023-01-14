using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // array iteration practice
            string[] names = { "Andy", "Selena", "James", "Jessica", "Dan", "Nancy" };
            Console.WriteLine("Please enter a random word: ");
            string random_word = Console.ReadLine();
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i] + " " + random_word;
            }
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }
            // END array iteration practice

            // infinite loop practice
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("The condition is true!");
                condition = false; // Added this change in the bool value to stop the infinite loop
            }
            // END infinite loop practice

            // < and <= practice
            int x = 0;
            while (x < 10)
            {
                x++;
                Console.WriteLine(x);
            }

            int y = 5;
            while (y <= 10)
            {
                Console.WriteLine(y);
                y++;
            }
            // END < and <= practice

            // string list practice
            List<string> meats = new List<string>() { "beef", "chicken", "pork", "fish", "lamb" };
            Console.WriteLine("Please input a type of meat: ");
            string meat_user = Console.ReadLine();
            string meat_user_lower = meat_user.ToLower();
            bool meat_match = false;
            for (int m = 0; m < meats.Count; m++)
            {
                if (meats[m] == meat_user_lower)
                {
                    Console.WriteLine("The index of your input is: " + m);
                    meat_match = true;
                }
            }
            if (meat_match == false) // if user input is not on the list
            {
                Console.WriteLine("Sorry, your input is not on the list. Please try again.");

            }
            // END string list practice

            // string list with identical strings
            List<string> last_names = new List<string>() { "Jackson", "Jordan", "Jordan", "Shamin", "Jefferson"};
            Console.WriteLine("Please enter one of the following: Jackson, Jordan, Shamin, Jefferson :");
            string user_last_name = Console.ReadLine();
            bool last_name_match = false;
            for (int l = 0; l < last_names.Count; l++)
            {
                if (last_names[l].ToLower() == user_last_name.ToLower())
                {
                    Console.WriteLine("The index(s) of your input is/are: " + l);
                    last_name_match = true;
                }
            }
            if (last_name_match == false) // if user input is not on the list
            {
                Console.WriteLine("Sorry, your input is not on the list. Please try again.");

            }
            // END string list with identical strings

            // string list with identical strings foreach loop
            List<string> fruits = new List<string>() { "pear", "orange", "apple", "cherry", "apple", "banana" };
            IEnumerable<string> new_fruits = fruits.GroupBy(f => f).SelectMany(g => g.Skip(1));
            foreach (string fruit in fruits)
            {
                if (new_fruits.Contains(fruit))
                {
                    Console.WriteLine(fruit + " - this item is a duplicate.");
                } else
                {
                    Console.WriteLine(fruit + " - this item is unique.");
                }
            }


            Console.ReadLine();
        }
    }
}
