using System;

namespace SelectionStatementstest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //numberGuessingGame

            //var r = new Random();
            ////
            //var favNumber = r.Next(1, 420);
            ////var favNumber = 5;
            ////declaring userInput
            //int userInput;
            //var counter = 0;


            //do
            //{

            //    Console.WriteLine("Pick a number from 1-420");
            //    userInput = int.Parse(Console.ReadLine());

            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too low");
            //    }
            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too high");

            //    }
            //    else
            //    {
            //        Console.WriteLine("You Guessed it!");
            //    }
            //    counter++;

            //    Console.WriteLine($"You have guessed {counter} times");

            //} while (userInput != favNumber);

            //Switch-Case
            Console.WriteLine("What is your favorite subject");

            string subject = Console.ReadLine();

      
            switch (subject.ToLower())
                
            {
                case "math":
                    Console.WriteLine("I hate math");
                    break;
                case "science":
                case "physics":
                case "biology":
                    Console.WriteLine("I Love Science");
                    break;
                case "PE":
                case "Physical Education":
                case "Phys Ed":
                    Console.WriteLine("Pe is the Best!");
                    break;
                case "history":
                    Console.WriteLine("History is cool");
                    break;
                case "english":
                    Console.WriteLine("English is horrible");
                    break;
                default:
                    Console.WriteLine("I dont know that subject");
                    break;




            } 




        }
    }
}
