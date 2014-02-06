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
            _displayer = new DefaultMazeDisplay();
            _mazeGen = new DefaultMazeGenerator();
        }

        public static Maze GetInstance()
        {
            return _thisMaze ?? (_thisMaze = new Maze());
        }

        public void Exit()
        {
            _thisMaze = null;
        }

        public void Display()
        {
            _displayer.Display(_theMaze);
        }

        public void Generate(int size)
        {
            _theMaze = _mazeGen.Generate(size);
        }

        public void SetGenerator(IMazeGenerator mazeGen)
        {
            _mazeGen = mazeGen;
        }

        public void SetDiplayer(IMazeDisplay mazeDesp)
        {
            _displayer = mazeDesp;
        }

    }
}
