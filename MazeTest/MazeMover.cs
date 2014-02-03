using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    static class MazeMover
    {

        public static bool move(EnumDirection dir, MazeObject movee)
        {
            switch (dir)
            {
                case EnumDirection.Up:
                    return swapUpDown(movee.getSurroundings().getUp(), movee);

                case EnumDirection.Down:
                    return swapUpDown(movee, movee.getSurroundings().getDown());

                case EnumDirection.Left:
                    return swapLeftRight(movee, movee.getSurroundings().getLeft());

                case EnumDirection.Right:
                    return swapLeftRight(movee.getSurroundings().getRight(), movee);

                default:
                    throw new UnauthorizedAccessException();

            }

        }

        private static bool swapUpDown(MazeObject from, MazeObject to)
        {
            //link all the outer nodes looking at the two being swapped
            from.getSurroundings().getLeft().getSurroundings().setRight( to );
            from.getSurroundings().getUp().getSurroundings().setDown( to );
            from.getSurroundings().getRight().getSurroundings().setLeft( to );

            to.getSurroundings().getLeft().getSurroundings().setRight( from );
            to.getSurroundings().getDown().getSurroundings().setUp( from );
            to.getSurroundings().getRight().getSurroundings().setLeft( from );


            //link all the inner nodes of the two being swappeds
            from.getSurroundings().setDown( to.getSurroundings().getDown() );
            to.getSurroundings().setUp( from.getSurroundings().getUp() );

            MazeObject holder = from.getSurroundings().getLeft();
            from.getSurroundings().setLeft( to.getSurroundings().getLeft() );
            to.getSurroundings().setLeft( holder );

            holder = from.getSurroundings().getRight();
            from.getSurroundings().setRight( to.getSurroundings().getRight() );
            to.getSurroundings().setRight( holder );

            to.getSurroundings().setDown(from);
            from.getSurroundings().setUp(to);
            
            return true;
        }

        private static bool swapLeftRight(MazeObject from, MazeObject to)
        {

            //link all the outer nodes looking at the two being swapped
            from.getSurroundings().getUp().getSurroundings().setDown(to);
            from.getSurroundings().getRight().getSurroundings().setLeft(to);
            from.getSurroundings().getDown().getSurroundings().setUp(to);

            to.getSurroundings().getUp().getSurroundings().setDown(from);
            to.getSurroundings().getLeft().getSurroundings().setRight(from);
            to.getSurroundings().getDown().getSurroundings().setUp(from);


            //link all the inner nodes of the two being swappeds
            from.getSurroundings().setLeft(to.getSurroundings().getLeft());
            to.getSurroundings().setRight(from.getSurroundings().getRight());

            MazeObject holder = from.getSurroundings().getUp();
            from.getSurroundings().setUp(to.getSurroundings().getUp());
            to.getSurroundings().setUp(holder);

            holder = from.getSurroundings().getDown();
            from.getSurroundings().setDown(to.getSurroundings().getDown());
            to.getSurroundings().setDown(holder);

            to.getSurroundings().setLeft(from);
            from.getSurroundings().setRight(to);

            return true;
        }


    }
}
