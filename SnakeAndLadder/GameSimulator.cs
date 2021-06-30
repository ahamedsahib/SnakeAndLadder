using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class GameSimulator
    {
        public int position = 0;
        public int dice_Count = 0;
        public const int noPlay = 1;//noplay has no chance to play 
        public const int ladder = 2;//ladder option going up when got a ladder
        public const int snake = 3;//snake option when hit by a snake goes down
        public void Game()
        {
            
            Random random = new Random();
            while (position < 100)
            {
                //to check no of time dice rolled 
                // generating random for rolling dice
                int rolled_dice = random.Next(1, 7);
                //creating random no to pick 3 options 1)No play 2)Ladder 3)Snake
                int option = random.Next(1, 4);
                Console.WriteLine($"The Dice rolled as {rolled_dice}");
                
                if (option == 2)
                {
                    Console.WriteLine("**Player got Ladder and Climbing up**");
                    position += rolled_dice;//picking up ladder and moving forward
                    if (position > 100)//if player goes above 100 going back to previous position
                    {
                        position -= rolled_dice;

                    }

                }
                else if (option == 3)
                {
                    Console.WriteLine("**Player hit by a snake**");
                    position = position - rolled_dice;
                    if (position < 0)//if player goes below 0 assign initial position
                    {
                        position = 0;
                    }
                }
                else
                {
                    Console.WriteLine("**Player had no chance to play**");
                }

                dice_Count++;
                Console.WriteLine($"Player Current Position is {position} ");//used to track current position of player

            }
            Console.WriteLine($"The number of times Dice rolled :{dice_Count}");//dice roll count on game

            Console.WriteLine("Player Wins!!!!");
            
        }


    }
}
