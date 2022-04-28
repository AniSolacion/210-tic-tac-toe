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
            List<string> board = new List<string>()
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9"
            };
            gameLoop(board);
        }

        static void gameLoop(List<string> board)
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

                Console.Write($"\n{player}'s turn to choose a square (1-9): ");
                string selection = Console.ReadLine();
                int square = int.Parse(selection);
                Console.WriteLine("");

                // Check if a square is already filled.
                while (board[square - 1] == "x" || board[square - 1] == "o")
                {
                    Console.Write("Please input a square that hasn't been filled: ");
                    selection = Console.ReadLine();
                    square = int.Parse(selection);
                }

                board[square - 1] = player;

                // check for a win.
                if (turns >= 5)
                {
                    done = checkForWin(board, player);
                }
                // Once the board is full, end the game.
                else if (turns == 9)
                {
                    done = "true";
                    Display(board);
                    Console.WriteLine("Tied game. Thanks for playing!\n");
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

        static string checkForWin(List<string> board, string player)
        {
            if (board[0] == player && board[1] == player && board[2] == player ||
                board[3] == player && board[4] == player && board[5] == player ||
                board[6] == player && board[7] == player && board[8] == player ||
                board[0] == player && board[3] == player && board[6] == player ||
                board[1] == player && board[4] == player && board[7] == player ||
                board[2] == player && board[5] == player && board[8] == player ||
                board[0] == player && board[4] == player && board[8] == player ||
                board[2] == player && board[4] == player && board[6] == player)
                {
                    Display(board);
                    Console.WriteLine($"{player} wins! Thanks for playing!\n");
                    return "true";
                }
            return "false";
        }
    }
}

