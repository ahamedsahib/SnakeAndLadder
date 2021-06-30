using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder simulator");
            GameSimulator game = new GameSimulator();//creating object of game simulator class
            game.Game();//calling game method in Game Smiulator class with Object

        }
    }
}
