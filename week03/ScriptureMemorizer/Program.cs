using System;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKey choice = ConsoleKey.Tab;

        Reference _scripture = new Reference("Mosiah", 2, 17, 18);
        _scripture.GetDisplayText();
        Console.WriteLine();
        Console.Write("Press enter to continue or type 'quit' to finish:");
        Console.WriteLine();

        while (choice != "quit")
        {
            //choice = Console.ReadLine();
            //if (Console.ReadKey().Key == ConsoleKey.Enter)
            //{
                //break;
                //choice = Console.ReadLine();
            //}
            //Console.Write("");
            //choice = Console.ReadLine();
            choice = Console.ReadKey().Key;
            if (choice == ConsoleKey.Enter)
            {}
            if (choice !=ConsoleKey.Enter)
            {
                
            }
        }     
    } 
}