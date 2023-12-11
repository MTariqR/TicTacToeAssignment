using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }


        public void Run()
        {
            bool onOff = true;
            int xTurnCount = 0;
            int oTurnCount = 0;

            while (onOff)
            {
                bool xTurn = true;
                bool oTurn = false;
                
                while (xTurn)
                {
                    // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE
                    _boardRenderer.Render();
                    Console.SetCursorPosition(2, 19);

                    Console.Write("Player X");

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);


                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();


                    
                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true); // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)

                    xTurn = false;
                    oTurn = true;
                    xTurnCount += 1;
                }

                if (xTurnCount == 5)
                {
                    break;
                }

                while (oTurn)
                {
                    // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE
                    _boardRenderer.Render();
                    Console.SetCursorPosition(2, 19);

                    Console.Write("Player O");

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);


                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();

                    

                    // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                    _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);
                    oTurn = false;
                    xTurn = true;
                    oTurnCount += 1;
                    
                }

                
            }
        }

    }
}
