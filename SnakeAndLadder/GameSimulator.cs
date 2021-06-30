using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class GameSimulator
    {
        public int position = 0;
        public const int noPlay = 1;//noplay has no chance to play 
        public const int ladder = 2;//ladder option going up when got a ladder
        public const int snake = 3;//snake option when hit by a snake goes down
        public void Game()
        {
            
            Random random = new Random();
            while (position <= 100)
            {
                // generating random for rolling dice
                int rolled_dice = random.Next(1, 7);
                //creating random no to pick 3 options 1)No play 2)Ladder 3)Snake
                int option = random.Next(1, 4);
                Console.WriteLine($"The Dice rolled as {rolled_dice}");
                
                if (option == 2)
                {
                    Console.WriteLine("**Player got Ladder and Climbing up**");
                    position += rolled_dice;//picking up ladder and moving forward
                    
                }
                else if (option == 3)
                {
                    Console.WriteLine("**Player hit by a snake**");
                    //hit by a snake and going down using conditonal opertor to check below 0 then move to start position as 0
                    position = (position- rolled_dice) <0 ? 0:position-rolled_dice;

                    if (position < 0)//if player goes below 0 assign initial position
                    {
                        position = 0;
                    }
                }
                else
                {
                    Console.WriteLine("**Player had no chance to play**");
                }

               
            }
                Console.WriteLine("Player Wins!!!!");
            
        }


    }
}
