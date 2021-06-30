using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class GameSimulator
    {
       
        public static int dice_Count = 0;
        public const int noPlay = 1;//noplay has no chance to play 
        public const int ladder = 2;//ladder option going up when got a ladder
        public const int snake = 3;//snake option when hit by a snake goes down

        public static int player1_Position = 0;
        public static int player2_Position = 0;


        public static void Game()
        {
            Player1Turn();//calling Player1 to start the game 
            Console.WriteLine($"No Of times Dice Rolled {dice_Count}");
        }
        public static void Player1Turn()
        {
            
                Random random = new Random();
            //checking player position less than 100
            //if other player reaches 100 it terminates
                while (player1_Position < 100 && player2_Position != 100)
                {
                    //to check no of time dice rolled 
                    // generating random for rolling dice
                    int rolled_dice = random.Next(1, 7);
                    //creating random no to pick 3 options 1)No play 2)Ladder 3)Snake
                    int option = random.Next(1, 4);
                    Console.WriteLine($"The Dice rolled as {rolled_dice}");

                    if (option == 2)
                    {
                        Console.WriteLine("**Player1 got Ladder and Climbing up**");
                        player1_Position += rolled_dice;//picking up ladder and moving forward

                        //if player goes above 100 going back to previous position
                        if (player1_Position > 100)

                        {
                            player1_Position -= rolled_dice;
                            Console.WriteLine($"Player1 current position{player1_Position}");
                            Player1Turn();

                        }
                        else if (player1_Position == 100)
                        {
                            Console.WriteLine($"Player1 current position{player1_Position}");
                            Console.WriteLine("!!!!!Player1 Wins!!!!!");
                            break;
                        }
                        else
                        {
                            continue;
                        }



                    }
                    else if (option == 3)
                    {
                        Console.WriteLine("**Player1 hit by a snake**");
                        player1_Position -= rolled_dice;
                        if (player1_Position < 0)//if player goes below 0 assign initial position
                        {
                            player1_Position = 0;
                        }
                        Console.WriteLine($"Player1 current position{player1_Position}");
                        Player2Turn();
                    }

                    else
                    {
                        Console.WriteLine("**Player1 had no chance to play**");
                        Console.WriteLine($"Player1 current position{player1_Position}");
                        Player2Turn();
                    }

                    dice_Count++;

                }

        }
        public static void Player2Turn()
        {
            
                Random random = new Random();
                while (player2_Position < 100 && player1_Position!=100)
                {

                    int rolled_dice = random.Next(1, 7);

                    int option = random.Next(1, 4);
                    Console.WriteLine($"The Dice rolled as {rolled_dice}");

                    if (option == 2)
                    {
                        Console.WriteLine("**Player2 got Ladder and Climbing up**");
                        player2_Position += rolled_dice;

                        if (player2_Position > 100)
                        {
                            player2_Position -= rolled_dice;
                            Console.WriteLine($"Player2 current position{player2_Position}");
                            Player2Turn();
                        }
                        else if (player2_Position == 100)
                        {
                            Console.WriteLine($"Player2 current position{player2_Position}");
                            Console.WriteLine("!!!!!Player 2 Wins!!!!!");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (option == 3)
                    {
                        Console.WriteLine("**Player2 hit by a snake**");
                        player2_Position -= rolled_dice;
                        if (player2_Position < 0)
                        {
                            player2_Position = 0;
                        }
                        Console.WriteLine($"Player2 current position{player2_Position}");
                        Player1Turn();
                    }

                    else
                    {
                        Console.WriteLine("**Player2 had no chance to play**");
                        Console.WriteLine($"Player2 current position{player2_Position}");
                        Player1Turn();
                    }

                    dice_Count++;

                }

        }
        
    }
}
