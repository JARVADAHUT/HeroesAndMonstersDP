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

        public void display(MazeObject head)
        {

            MazeObject temp = head;
            int count = 0;
            while(temp.getSurroundings().getDown() != null)//for (int x = 0; x < maze.Length; x++)
            {
                
                int goDown = 0;

                while(goDown < count)
                {
                    temp = temp.getSurroundings().getDown();
                    goDown++;
                }

                if (temp == null)
                    break;

                while(temp != null)
                {
                    Console.Write(temp);

                    temp = temp.getSurroundings().getRight();
                }

                temp = head;
                Console.WriteLine();
                count++;
            }
        }

    }
}
