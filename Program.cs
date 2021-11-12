using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Problem: Create a variable (use your best judgment for type) 
            that stores the numberOfCupsOfCoffee that you drink every day.
            Number of cups of Coffee over the course of a week. 
              Examples: monday = 2 tuesday = 6 wednesday = 2 thursday = 3 friday = 4
              Data: there are two variables 1. the numberOfCupsOfCoffee 2. day of the week 2.
              Algorithm: for each day record the numberOfCupsOfCoffee based of the day of the week */


            Console.WriteLine("How many cups of coffee have you had today ?");
            //Recording the number of cups of coffee on a given day
            var numberOfCupsOfCoffee = 3;
            var fullname = " Nicholas Amheiser ";
            var today = DateTime.Now;
            Console.WriteLine(numberOfCupsOfCoffee + fullname + today);

            // Type your username and press enter
            Console.Write("Enter username:");
            var username = Console.ReadLine();
            Console.WriteLine(" Greetings " + username);

            //Asking user for input
            Console.Write("Enter two numbers: ");
            var numbers = Console.ReadLine();




        }
    }
}
