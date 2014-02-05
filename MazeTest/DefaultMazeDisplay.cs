using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class DefaultMazeDisplay : IMazeDisplay
    {
        public DefaultMazeDisplay()
        {

        }

        public void Display(MazeObject head)
        {
            Console.Clear();
            MazeObject displayCol = head;

            while(displayCol != null)//for (int x = 0; x < maze.Length; x++)
            {
  
                MazeObject displayRow = displayCol;
                while (displayRow != null)
                {
                    Console.Write(displayRow);

                    displayRow = displayRow.getSurroundings().getRight();
                }

                displayCol = displayCol.getSurroundings().getDown();
                Console.WriteLine();
            }
        }

        public void DebugDisplay(MazeObject head)
        {
            Console.Clear();
            MazeObject displayCol = head;

            while (displayCol != null)//for (int x = 0; x < maze.Length; x++)
            {

                MazeObject displayRow = displayCol;
                while (displayRow != null)
                {
                    if (displayRow.getSurroundings().getDown() == null)
                        Console.Write("x");
                    else
                        Console.Write(displayRow);

                    displayRow = displayRow.getSurroundings().getRight();
                }

                displayCol = displayCol.getSurroundings().getDown();
                Console.WriteLine();
            }
        }

    }
}
