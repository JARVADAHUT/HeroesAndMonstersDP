using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    interface IMazeDisplay
    {
        void Display(MazeObject maze);
        void DebugDisplay(MazeObject maze);
    }
}
