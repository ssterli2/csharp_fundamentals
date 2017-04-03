using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i < 100; i+=2)
            {   
                if (i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
             for (float i = 1; i < 100; i+=2)
            {   
                if (i/3 - Math.Floor(i/3) == 0 && i/5 - Math.Floor(i/5) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i/3 - Math.Floor(i/3) == 0) 
                {
                    Console.WriteLine("Fizz");
                }
                else if (i/5 - Math.Floor(i/5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            Random rand = new Random();
            for (int i = 1; i <= 10; i++)
            {   
                int randomNum = rand.Next();
                Console.WriteLine(randomNum);
                if (randomNum%3 == 0 && randomNum%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (randomNum%3 == 0)
                { 
                    Console.WriteLine("Fizz");
                }
                else if (randomNum%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
