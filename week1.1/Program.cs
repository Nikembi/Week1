using System;

namespace week1._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintAboutMe();
            DemonstrateMultiplication();
            RunForLoop();
            PrintFriends();
        }


        static void PrintAboutMe()
        {
            string aboutMe = "Hello, My name is Nikembi, An aspiring Full Stack Developer. " +
                             "I'm excited to learn complex programming concepts, and eventually land my first job.";
            Console.WriteLine(aboutMe);
        }

        static void DemonstrateMultiplication()
        {
            int product = Multiply(1, 2);
            Console.WriteLine($"The product is: {product}");
        }

        static void RunForLoop()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"This for loop has run {i} number of times");
            }
        }

        static void PrintFriends()
        {
            string[] friends = { "Lisha", "Davion", "Colburn", "Kobe" };
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine($"Friend {i + 1} is {friends[i]}");
            }
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
