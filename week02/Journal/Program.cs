using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";

        while (choice != "5")
        {

            Journal journal = new Journal();

            Console.WriteLine("Welcome to the Journal Program!.");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }

            if (choice == "2")
            {
                journal.DisplayAll();
            }

             if (choice == "3")
            {
                //journal3.SaveToFile();
            }
        
        else
        {
            Console.WriteLine("Thank you, goodbye!");
        }

        }
    }
}