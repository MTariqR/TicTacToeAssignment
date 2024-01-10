using System;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }

        public static string[,] gameBoardArray = 
        { 
            { "", "", "" },     
            { "", "", "" }, 
            { "", "", "" } 
        };

        public void Run()
        {
            int xTurnCount = 0;
            int oTurnCount = 0;

            while (true)
            {

                while (true)
                {
                    _boardRenderer.Render();
                    Console.SetCursorPosition(2, 19);

                    Console.Write("Player X");

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var xrow = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);


                    Console.Write("Please Enter Column: ");
                    var xcolumn = Console.ReadLine();


                    if (gameBoardArray[int.Parse(xrow), int.Parse(xcolumn)] == "")
                    {
                        _boardRenderer.AddMove(int.Parse(xrow), int.Parse(xcolumn), PlayerEnum.X, true);
                        gameBoardArray[int.Parse(xrow), int.Parse(xcolumn)] = "X";
                        xTurnCount += 1;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.SetCursorPosition(10, 2);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Invalid! Please try again.");
                    }
                }

                if (TicTacToe.CheckWin().Length > 5 | xTurnCount == 5)
                {
                    Console.SetCursorPosition(20, 25);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(TicTacToe.CheckWin());
                    Console.SetCursorPosition(20, 27);
                    Console.WriteLine("Thank you for playing");
                    Console.ReadLine();
                    break;
                }

                while (true)
                {
                    _boardRenderer.Render();
                    Console.SetCursorPosition(2, 19);

                    Console.Write("Player O");

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var orow = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);


                    Console.Write("Please Enter Column: ");
                    var ocolumn = Console.ReadLine();



                    if (gameBoardArray[int.Parse(orow), int.Parse(ocolumn)] == "")
                    {
                        _boardRenderer.AddMove(int.Parse(orow), int.Parse(ocolumn), PlayerEnum.O, true);
                        gameBoardArray[int.Parse(orow), int.Parse(ocolumn)] = "O";
                        oTurnCount += 1;
                        break;
                    }
                    else 
                    {
                        Console.Clear();
                        Console.SetCursorPosition(10, 2);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Invalid! Please try again.");
                    }
                }

                if (TicTacToe.CheckWin().Length > 5)
                {
                    Console.SetCursorPosition(20, 25);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(TicTacToe.CheckWin());
                    Console.SetCursorPosition(20, 27);
                    Console.WriteLine("Thank you for playing");
                    Console.ReadLine();
                    break;
                }

            }
        }
        public static string CheckWin()
        {
            string win;
            if ((gameBoardArray[0,0] != "") & (gameBoardArray[0, 0] == gameBoardArray[0, 1] & gameBoardArray[0, 1] == gameBoardArray[0, 2]))
            {
                win = $"Player {gameBoardArray[0, 0]} Wins!";
            }
            else if ((gameBoardArray[1, 0] != "") & (gameBoardArray[1, 0] == gameBoardArray[1, 1] & gameBoardArray[1, 1] == gameBoardArray[1, 2]))
            {
                win = $"{gameBoardArray[1, 0]} Player Wins!";
            }
            else if ((gameBoardArray[2, 0] != "") & (gameBoardArray[2, 0] == gameBoardArray[2, 1] & gameBoardArray[1, 1] == gameBoardArray[2, 2]))
            {
                win = $"Player {gameBoardArray[2, 0]} Wins!";

            }
            else if ((gameBoardArray[0, 0] != "") & (gameBoardArray[0, 0] == gameBoardArray[1, 1] & gameBoardArray[1, 1] == gameBoardArray[2, 2]))
            {
                win = $"Player {gameBoardArray[0, 0]} Wins!";

            }
            else if ((gameBoardArray[0, 2] != "") & (gameBoardArray[0, 2] == gameBoardArray[1, 1] & gameBoardArray[1, 1] == gameBoardArray[2, 0]))
            {
                win = $"Player {gameBoardArray[0, 2]} Wins!";

            }
            else if ((gameBoardArray[0, 0] != "") & (gameBoardArray[0, 0] == gameBoardArray[1, 0] & gameBoardArray[1, 0] == gameBoardArray[2, 0]))
            {
                win = $"Player {gameBoardArray[0, 0]} Wins!";
            }
            else if ((gameBoardArray[0, 1] != "") & (gameBoardArray[0, 1] == gameBoardArray[1, 1] & gameBoardArray[1, 1] == gameBoardArray[2, 1]))
            {
                win = $"Player {gameBoardArray[0, 1]} Wins!";
            }
            else if ((gameBoardArray[0, 2] != "") & (gameBoardArray[0, 2] == gameBoardArray[1, 2] & gameBoardArray[1, 2] == gameBoardArray[2, 2]))
            {
                win = $"Player {gameBoardArray[0, 2]} Wins!";
            }
            else
            {
                win = "Draw!";
            }
            return win;
        }
    }
}
