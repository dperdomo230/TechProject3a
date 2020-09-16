/*
    Author: Daniel Perdomo
    Date: 15 September 2020
    Comments: This C# console application code demonstrates the use of methods 
              after getting input from the user. The program has one void 
              method. The method is designed to display the users name
              depending on what they typed for their name.
*/
using System;

namespace TechProject3a
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line asks the user to enter their name.
            Console.WriteLine("Please enter your name.");
            
            // Execute the Enter_Your_Name method. This is a void method.
            Enter_Your_Name();

        } // End of main 

        /* 
            This static void method is responsible for gathering user input
            and conveying their name on the console application. The accessor
            is private which means the method is limited to the containing
            class. No parameters were used. 
        */
        private static void Enter_Your_Name()
        {
            // This variable will gather data from user input.
            string input = Console.ReadLine();
            // Display a greeting and their name to the user depending on their input.
            Console.WriteLine("Hello " + input + "." + " Thank you for using this program.");
            // Prompt the user to close the program.
            Console.WriteLine("Press any key to exit the program.");
            // Pause the program and await the user to press a key to end the program.
            Console.ReadKey(true);
        } // End of Enter_Your_Name
    } // End of class
} // End of namespace
