using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    public enum EnumDirection
    {
        Up = 3,
        Down = -3,
        Left = 2,
        Right = -2
    }

    public enum EnumMazeObject
    {
        Wall,
        Air,
        Exit,
        Chest,
        Player,
        Monster,
        Door,
        Key
    }

}
