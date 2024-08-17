using System;

namespace week1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aboutme = ("Hello, My name is Nikembi, An aspiring Full Stack Developer, " +
                        "I'm excited to learn complex programming concepts, and eventually land my first job.");
            Console.WriteLine(aboutme);

            int product = Multiply(1, 2);
            Console.ReadLine();
            Console.WriteLine($"The product is: {product}");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"This for loop has run {i} number of times");
            }

            string[] friends = {"Lisha", "Davion", "Colburn", "Kobe"};
            foreach (string friend in friends)
            {   
                Console.WriteLine($"First friend is {friends[0]}");
                Console.WriteLine($"Second friend is {friends[1]}");
                Console.WriteLine($"Third friend is {friends[2]}");
                Console.WriteLine($"Fourth friend is {friends[3]}");
                break;
            }
        }
        //static string ForLoop()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine($"This for loop has run {i} number of times");

        //        break;
        //    }

        //}
        static int Multiply(int x, int y)
            {

                return x * y;
            }
    }
}
