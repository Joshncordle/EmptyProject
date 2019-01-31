using System;

namespace EmptyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name...");

            try
            {
                string input = Console.ReadLine();
                int user_input = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Please only enter your name");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
        }
    }
}
