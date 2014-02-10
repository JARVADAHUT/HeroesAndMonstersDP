﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    static class MazeMover
    {

        public static void Move(EnumDirection dir, MazeObject movee)
        {
            switch (dir)
            {
                case EnumDirection.Up:
                    SwapUpDown(movee.getSurroundings().GetUp(), movee);
                    break;

                case EnumDirection.Down:
                    SwapUpDown(movee, movee.getSurroundings().GetDown());
                    break;

                case EnumDirection.Left:
                    SwapLeftRight(movee, movee.getSurroundings().GetLeft());
                    break;

                case EnumDirection.Right:
                    SwapLeftRight(movee.getSurroundings().GetRight(), movee);
                    break;

                default:
                    throw new UnauthorizedAccessException();

            }

        }

        private static void SwapUpDown(MazeObject from, MazeObject to)
        {
            //link all the outer nodes looking at the two being swapped
            //Maze.GetInstance().Display();
            //Console.ReadKey();

            from.getSurroundings().GetLeft().getSurroundings().setRight( to );
            from.getSurroundings().GetUp().getSurroundings().setDown( to );
            from.getSurroundings().GetRight().getSurroundings().setLeft( to );

            to.getSurroundings().GetLeft().getSurroundings().setRight( from );
            to.getSurroundings().GetDown().getSurroundings().setUp( from ); // always blows here
            to.getSurroundings().GetRight().getSurroundings().setLeft( from );


            //link all the inner nodes of the two being swappeds
            from.getSurroundings().setDown( to.getSurroundings().GetDown() );
            to.getSurroundings().setUp( from.getSurroundings().GetUp() );

            MazeObject holder = from.getSurroundings().GetLeft();
            from.getSurroundings().setLeft( to.getSurroundings().GetLeft() );
            to.getSurroundings().setLeft( holder );

            holder = from.getSurroundings().GetRight();
            from.getSurroundings().setRight( to.getSurroundings().GetRight() );
            to.getSurroundings().setRight( holder );

            to.getSurroundings().setDown(from);
            from.getSurroundings().setUp(to);
            
        }

        private static void SwapLeftRight(MazeObject from, MazeObject to)
        {

            //link all the outer nodes looking at the two being swapped
            from.getSurroundings().GetUp().getSurroundings().setDown(to);
            from.getSurroundings().GetRight().getSurroundings().setLeft(to);
            from.getSurroundings().GetDown().getSurroundings().setUp(to);

            to.getSurroundings().GetUp().getSurroundings().setDown(from);
            to.getSurroundings().GetLeft().getSurroundings().setRight(from);
            to.getSurroundings().GetDown().getSurroundings().setUp(from);


            //link all the inner nodes of the two being swappeds
            from.getSurroundings().setLeft(to.getSurroundings().GetLeft());
            to.getSurroundings().setRight(from.getSurroundings().GetRight());

            MazeObject holder = from.getSurroundings().GetUp();
            from.getSurroundings().setUp(to.getSurroundings().GetUp());
            to.getSurroundings().setUp(holder);

            holder = from.getSurroundings().GetDown();
            from.getSurroundings().setDown(to.getSurroundings().GetDown());
            to.getSurroundings().setDown(holder);

            to.getSurroundings().setLeft(from);
            from.getSurroundings().setRight(to);
        }


    }
}
