using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder simulator");
            GameSimulator game = new GameSimulator();
            game.Game();

        }
    }
}
