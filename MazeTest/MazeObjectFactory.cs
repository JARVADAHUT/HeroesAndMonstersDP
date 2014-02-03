using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class MazeObjectFactory
    {
        public static MazeObject getMazeObject(int s)
        {
            switch ((EnumMazeObject)s)
            {
                case EnumMazeObject.Air:
                    return new MazeObjectAir();

                case EnumMazeObject.Chest:
                    return new MazeObjectChest();

                case EnumMazeObject.Exit:
                    return new MazeObjectExit();

                case EnumMazeObject.Player:
                    return Player.getInstance();

                default:
                    return new MazeObjectWall();

            }

        }




    }
}
