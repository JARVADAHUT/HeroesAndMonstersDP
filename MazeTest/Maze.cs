using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class Maze
    {
        //singleton object
        private static Maze _thisMaze = null;

        private IMazeDisplay _displayer;
        private MazeObject _theMaze;
        private IMazeGenerator _mazeGen;


        private Maze()
        {

        }

        public static Maze getInstance()
        {
            return _thisMaze ?? (_thisMaze = new Maze());
        }

        public void Exit()
        {
            _thisMaze = null;
        }

        public void Display()
        {
            _displayer.display(_theMaze);
        }

        public void generate(int size)
        {
            _theMaze = _mazeGen.generate(size);
        }

        public void setGenerator(IMazeGenerator mazeGen)
        {
            _mazeGen = mazeGen;
        }

        public void setDiplayer(IMazeDisplay mazeDesp)
        {
            _displayer = mazeDesp;
        }

    }
}
