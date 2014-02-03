using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    interface IMazeGenerator
    {
        MazeObject generate(int size);
    }
}
