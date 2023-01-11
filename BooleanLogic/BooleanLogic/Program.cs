using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int user_age = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI? Please answer true or false");
            string answer = Console.ReadLine();
            bool dui_answer = Convert.ToBoolean(answer);
            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int ticket_answer = Convert.ToInt32(ticket);
            bool application_success = (user_age > 15 && dui_answer == false && ticket_answer <= 3);
            Console.WriteLine("Qualified");
            Console.WriteLine(application_success);
            Console.ReadLine();
        }
    }
}
