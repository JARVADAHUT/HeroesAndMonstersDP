﻿using System;
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
            Player p = Player.GetInstance();

            HiveMind h = HiveMind.GetInstance();

            Maze maze = Maze.GetInstance();
            maze.Generate(8);

            maze.Display();

            //Thread.Sleep(20);
            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey();
                
                switch(k.KeyChar)
                {
                    case 'w':
                        p.Interact(EnumDirection.Up);
                        break;
                    case 'a':
                        p.Interact(EnumDirection.Left);
                        break;
                    case 's':
                        p.Interact(EnumDirection.Down);
                        break;
                    case 'd':
                        p.Interact(EnumDirection.Right);
                        break;
                }

                h.MoveMinions();

                Maze.GetInstance().Display();

                


            }
            //p.interact(EnumDirection.Right);
            //p.interact(EnumDirection.Right);

            //Console.WriteLine("\n\n\n\n\n");

            //maze.Display();
            




        }
    }
}
