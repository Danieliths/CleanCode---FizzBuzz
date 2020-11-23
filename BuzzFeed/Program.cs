using System;

namespace BuzzFeed
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            fizzbuzz.Run();
            Console.ReadKey();
        }
    }
    public class FizzBuzz
    {
        public void Run()
        {
            int userInput = 0;
            while (userInput == 0)
            {
                Console.WriteLine("enter a number between 1 to 300");
                userInput = CheckInput(Console.ReadLine());
            }
            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine(GetFizzBuzzString(i));
            }
        }
        public int CheckInput(string numInput)
        {
            int num;
            var parseSuccess = int.TryParse(numInput, out num);
            if (num >= 1 && num <= 300 && parseSuccess)
            {
                return num;
            }
            else
            {
                return 0;
            }
        }
        public string GetFizzBuzzString(int num)
        {
            if (num == 42)
            {
                return "Answer to the Ultimate Question of Life, the Universe, and Everything";
            }
            else if (num % 3 == 0 && num % 5 == 0)
            {
                return "Fizzbuzz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return num.ToString();
            }
        }
    }
}
