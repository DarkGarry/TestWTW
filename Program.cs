/*Igor Dubovets TicTacToe task*/
using System;

namespace Task2_TicTacToe
{
    public class TicTacToe
    {
        private int turnCount;
        private int playerWon;
        private int[,] board;
        /// <summary>
        /// Created a Tic Tac Tow game board
        /// </summary>
        /// <param name="n">nxn dimension for the game board</param>
        public TicTacToe(int n)
        {
            board = new int[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    board[i, j] = 0;

            turnCount = 0;
            playerWon = 0;
        }

        /// <summary>
        /// Place a piece on the game board
        /// </summary>
        /// <param name="row">row to place a piece</param>
        /// <param name="col">column to place a piece</param>
        /// <param name="player">the player (1 or 2) the piece is for</param>
        /// <returns>0 = no winner, 1 = player 1 won, 2 = player 2 won</returns>
        public int PlacePiece(int row, int col, int player)
        {
            if (playerWon != 0 || turnCount == board.Length)//Game is over
            {
                throw new Exception("Game is over");
            }
            //input assumed to be correct as per task description so skip input checks

            turnCount++;
            board[row, col] = player;

            playerWon = CheckIsWon(row, col, player);

            return playerWon;
        }

        private int CheckIsWon(int row, int col, int player)
        {
            int sideSize = (int)Math.Sqrt(board.Length);
            if (turnCount < (sideSize * 2 - 1))//too early in the game to check victory condition
            {
                return 0;
            }

            //check row
            bool checkFailed = false;
            for (int i = 0; i < sideSize; i++)
            {
                if (board[row, i] != player)
                {
                    checkFailed = true;
                    break;
                }
            }

            if (!checkFailed) return player;

            //check column
            checkFailed = false;
            for (int i = 0; i < sideSize; i++)
            {
                if (board[i, col] != player)
                {
                    checkFailed = true;
                    break;
                }
            }

            if (!checkFailed) return player;

            //check diagonal 1
            if (row == col)
            {
                checkFailed = false;

                for (int i = 0; i < sideSize; i++)
                {
                    if (board[i, i] != player)
                    {
                        checkFailed = true;
                        break;
                    }
                }
            }
            if (!checkFailed) return player;

            //check diagonal 2
            if (row == sideSize - 1 - col)
            {
                checkFailed = false;

                for (int i = 0; i < sideSize; i++)
                {
                    if (board[sideSize - 1 - i, i] != player)
                    {
                        checkFailed = true;
                        break;
                    }
                }
            }
            if (!checkFailed) return player;

            return 0;
        }
    }

    public class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
