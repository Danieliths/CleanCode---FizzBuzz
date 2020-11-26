using System;

namespace BuzzFeed
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Console.WriteLine("enter a number between 1 to 300");
            fizzbuzz.PrintFizzBuzz(44);
            //kolla under 300
            //köra

            Console.ReadKey();
        }
    }
    public class FizzBuzz
    {
        public void PrintFizzBuzz(int num)
        {
            for (int i = 1; i <= num; i++)
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
                Console.WriteLine("You entered the wrong number");
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
