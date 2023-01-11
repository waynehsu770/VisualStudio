using System;


namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Anonymous Income Comparison Program");
            Console.WriteLine("Hello Person 1");
            Console.WriteLine("Please enter your Hourly Rate:");
            string hourly_1 = Console.ReadLine();;
            int hourly_rate_1 = Convert.ToInt32(hourly_1);
            Console.WriteLine("Please enter your Hours Worked Per Week");
            string hours_1 = Console.ReadLine();
            int hours_week_1 = Convert.ToInt32(hours_1);
            Console.WriteLine("Hello Person 2");
            Console.WriteLine("Please enter your Hourly Rate:");
            string hourly_2 = Console.ReadLine();
            int hourly_rate_2 = Convert.ToInt32(hourly_2);
            Console.WriteLine("Please enter your Hours Worked Per Week");
            string hours_2 = Console.ReadLine();
            int hours_week_2 = Convert.ToInt32(hours_2);
            int annual_1 = hourly_rate_1 * hours_week_1 * 52;
            string annual_salary_1 = Convert.ToString(annual_1);
            Console.WriteLine("Annual Salary Of Person 1: " + annual_salary_1);
            int annual_2 = hourly_rate_2 * hours_week_2 * 52;
            string annual_salary_2 = Convert.ToString(annual_2);
            Console.WriteLine("Annual Salary Of Person 2: " + annual_salary_2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compare = (annual_1 > annual_2);
            Console.WriteLine(compare);
            Console.ReadLine(); 

        }
    }
}
