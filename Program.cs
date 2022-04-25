/****************************
* Logan Huston
* Lab 01: tic-tac-toe
*
*************************************/

using System;

namespace cse210_tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> board = new List<string>();
            board.Add("1");
            board.Add("2");
            board.Add("3");
            board.Add("4");
            board.Add("5");
            board.Add("6");
            board.Add("7");
            board.Add("8");
            board.Add("9");
            
            Turn(board);
        }

        static void Turn(List<string> board)
        {
            string done = "false";
            int turns = 1;
            string player;
            
            while (done == "false")
            {
                Display(board);

                // Select player turn here.
                if ((turns % 2) == 1)
                {
                    player = "x";
                }
                else
                {
                    player = "o";
                }

                Console.WriteLine($"{player}'s turn to choose a square (1-9): ");
                string selection = Console.ReadLine();
                int square = int.Parse(selection);
                board[square - 1] = player;

                // check for a win.
                if (turns >= 5)
                {
                    // Add win logic.
                }

                // Once the board is full, end the game.
                if (turns == 9)
                {
                    done = "true";
                    Display(board);
                    Console.WriteLine("Tied game. Thanks for playing!");
                }

                turns ++;
            }
        }

        static void Display(List<string> board) 
        {
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }
    }
}

