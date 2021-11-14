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
            Console.WriteLine($"My name is {fullname}, right now it is {today.ToShortTimeString()} I have had {numberOfCupsOfCoffee} cups of coffee");

            // Type your username and press enter
            var username = Dialog("Enter username:");

            //Changing the dialog to change name in case of "alice"
            if (username =="alice")
            {
                Console.Write("Welcome to the looking glass Alice!");
            }
            Console.WriteLine($" Greetings {username}");

            //Asking user for input
            //I'm not sure I have done with right.  So far this was by far the hardest part
        
            var firstNumberAsString = Dialog("Enter a number: ");

            double firstOperand = Convert.ToDouble(firstNumberAsString);

            var secondNumberAsString = Dialog("Write a second number: ");

            double secondOperand = Convert.ToDouble(secondNumberAsString);

            //Doing Math
            var sum = firstOperand + secondOperand;
            var difference = secondOperand - firstOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = secondOperand % secondOperand;

            Console.WriteLine($"These are your lotto numbers: {sum} {difference} {product} {quotient} {remainder}");
            Dialog("Problem Complete, hit any key to close");

    


            //double.Parse(firstNumberAsString + secondNumberAsString);
            // var firstOperand = double.Parse(firstNumberAsString);
            // var secondOperand = double.Parse(secondNumberAsString);
            //Console.WriteLine(Convert.ToDoublefirstNumberAsString)







       
        }
         private static string Dialog(string message)
            {
            //write the nessage
            Console.Write(message);
            //return what the user entered 
            return Console.ReadLine();
            }
    }
}