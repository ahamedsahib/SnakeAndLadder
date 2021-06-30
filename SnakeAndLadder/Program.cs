using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder simulator");
            int position = 0;
            Console.WriteLine($"player start with position {position}");
            Random random = new Random();
            int rolled_dice = random.Next(1, 7);
            Console.WriteLine($"The Dice rolled as {rolled_dice}");


        }
    }
}
