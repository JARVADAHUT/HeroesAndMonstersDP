using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MazeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = Player.getInstance();


            Maze maze = Maze.getInstance();
            maze.setGenerator(new DefaultMazeGenerator());
            maze.setDiplayer(new DefaultMazeDisplay());
            maze.generate(50);

            maze.Display();

            //Thread.Sleep(20);
            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey();
                
                switch(k.KeyChar)
                {
                    case 'w':
                        p.interact(EnumDirection.Up);
                        break;
                    case 'a':
                        p.interact(EnumDirection.Left);
                        break;
                    case 's':
                        p.interact(EnumDirection.Down);
                        break;
                    case 'd':
                        p.interact(EnumDirection.Right);
                        break;
                }

                Console.Clear();
                
                maze.Display();



            }
            //p.interact(EnumDirection.Right);
            //p.interact(EnumDirection.Right);

            //Console.WriteLine("\n\n\n\n\n");

            //maze.Display();
            




        }
    }
}
