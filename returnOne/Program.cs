using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numberStorage = new List<int>();
            Console.WriteLine("Enter -1 to exit");
            Console.WriteLine("input your numbers");
            

            while (true)
            {
                int userInput = int.Parse (Console.ReadLine());
                
                Console.Write("do you want to input another number: ");
                if(userInput == -1)
                {
                    Console.WriteLine();
                    Console.WriteLine("here are your Highest and Lowest numbers");
                    break;

                }
                numberStorage.Add(userInput);
            }

            Console.WriteLine($"Highest: {numberStorage.Max()}");
            Console.WriteLine($"Lowest: {numberStorage.Min()}");
           
            /*
            for (int i = 0; i < numberStorage.Count; i++)
            {
                Console.WriteLine(numberStorage[i] + ", ");
            }
            */
        }
    }
}