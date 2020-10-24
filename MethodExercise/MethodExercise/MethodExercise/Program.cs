using System;
using System.Diagnostics.CodeAnalysis;

namespace MethodExercise
{
    class Program
    {
      
        public static int Add(int x, int y)
        {
            int answer = x + y;
            return answer;
        }
        public static int Multiply(int x, int y)
        {
            int answer = x * y;
            return answer;
        }
        public static int Subtract(int x, int y)
        {
            int answer = x - y;
            return answer;
        }
        public static int Divide(int x, int y)
        {
            if (y < 1)
            {
                return 0;
            }
            else 
            {int answer = x / y;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("It's Story Time");
            Console.WriteLine("What should we name the character?");
            string storyName = Console.ReadLine();
            Console.WriteLine("sounds good, what is the character's job?");
            string storyJob = Console.ReadLine();
            Console.WriteLine("cool, our hero needs an enemy to face. what should it be?");
            string storyEnemy = Console.ReadLine();
            Console.WriteLine($"good choice, what's this {storyEnemy}'s name?");
            string storyEname = Console.ReadLine();
            Console.WriteLine($"alright, here's the story. \n" +
                $"Once there was a heroic individual named {storyName}. \n" +
                $"They made a living as a {storyJob}. \n " +
                $"One day while at work a {storyEnemy} named {storyEname} showed up callin' people out for playing games at work. \n" +
                $"{storyName} had had about enough of {storyEname}'s crap and punched them in the face. \n" +
                $"all the other {storyJob}s cheered {storyName} for their heroic deed before going back to playing games at work. \n \n \n");

            Console.WriteLine("give us a whole number.");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("give us another whole number.");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{x} and {y} it is. now we'll do some maths.");

            int add = Add(x, y); 
            Console.WriteLine($"Additon results = {add}");

            int mult = Multiply(x, y);
            Console.WriteLine($"Multiplication results = {mult}");

            int sub = Subtract(x, y);
            Console.WriteLine($"Subtraction results = {sub}");

            int div = Divide(x, y);
            if (y == 0)
            {
                Console.WriteLine("You tried to divide by zero.");
            }
            else
            {
                Console.WriteLine($"Division results = {div}");
            }
        }
    }
}
