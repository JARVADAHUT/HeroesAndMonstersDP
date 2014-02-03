using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{

    class DefaultMazeGenerator : IMazeGenerator
    {
        private readonly int minSize = 10;
        private MazeObject _head; // top left most block
        
        public DefaultMazeGenerator()
        {

        }
/*
        private void SetDiscovered()
        {
            discovered[position[0]][position[1]] = "N";
            //if the area to the top left is/isnt a wall
            
            if (maze[position[0] - 1][position[1] - 1] == (int)Surface.Air)
                discovered[position[0] - 1][position[1] - 1] = PATH;

            //if the area above is/isnt a wall
           
            if (maze[position[0] - 1][position[1]] == (int)Surface.Air)
                discovered[position[0] - 1][position[1]] = PATH;

            //if the area to the top right is/isnt a wall
           
            if (maze[position[0] - 1][position[1] + 1] == (int)Surface.Air)
                discovered[position[0] - 1][position[1] + 1] = PATH;

            //if the area to the right is/isnt a wall
           
            if (maze[position[0]][position[1] + 1] == (int)Surface.Air)
                discovered[position[0]][position[1] + 1] = PATH;

            //if the area to the bottom right is/isnt a wall
           
            if (maze[position[0] + 1][position[1] + 1] == (int)Surface.Air)
                discovered[position[0] + 1][position[1] + 1] = PATH;

            //if the area below is/isnt a wall
            
            if (maze[position[0] + 1][position[1]] == (int)Surface.Air)
                discovered[position[0] + 1][position[1]] = PATH;

            //if the area to the bottom left is/isnt a wall
           
           if (maze[position[0] + 1][position[1] - 1] == (int)Surface.Air)
                discovered[position[0] + 1][position[1] - 1] = PATH;

            //if the area to the left is/isnt a wall
           
            if (maze[position[0]][position[1] - 1] == (int)Surface.Air)
                discovered[position[0]][position[1] - 1] = PATH; 

            //MAKE EXIT---------------

            //to right
            if (maze[position[0] - 1][position[1] - 1] == (int)Surface.Exit)
                discovered[position[0] - 1][position[1] - 1] = EXIT;

            //if the area above is/isnt a wall

            if (maze[position[0] - 1][position[1]] == (int)Surface.Exit)
                discovered[position[0] - 1][position[1]] = EXIT;

            //if the area to the top right is/isnt a wall

            if (maze[position[0] - 1][position[1] + 1] == (int)Surface.Exit)
                discovered[position[0] - 1][position[1] + 1] = EXIT;

            //if the area to the right is/isnt a wall

            if (maze[position[0]][position[1] + 1] == (int)Surface.Exit)
                discovered[position[0]][position[1] + 1] = EXIT;

            //if the area to the bottom right is/isnt a wall

            if (maze[position[0] + 1][position[1] + 1] == (int)Surface.Exit)
                discovered[position[0] + 1][position[1] + 1] = EXIT;

            //if the area below is/isnt a wall

            if (maze[position[0] + 1][position[1]] == (int)Surface.Exit)
                discovered[position[0] + 1][position[1]] = EXIT;

            //if the area to the bottom left is/isnt a wall

            if (maze[position[0] + 1][position[1] - 1] == (int)Surface.Exit)
                discovered[position[0] + 1][position[1] - 1] = EXIT;

            //if the area to the left is/isnt a wall

            if (maze[position[0]][position[1] - 1] == (int)Surface.Exit)
                discovered[position[0]][position[1] - 1] = EXIT; 

            //make chest --------------------------------------

            if (maze[position[0] - 1][position[1] - 1] == (int)Surface.Chest)
                discovered[position[0] - 1][position[1] - 1] = CHEST;

            //if the area above is/isnt a wall

            if (maze[position[0] - 1][position[1]] == (int)Surface.Chest)
                discovered[position[0] - 1][position[1]] = CHEST;

            //if the area to the top right is/isnt a wall

            if (maze[position[0] - 1][position[1] + 1] == (int)Surface.Chest)
                discovered[position[0] - 1][position[1] + 1] = CHEST;

            //if the area to the right is/isnt a wall

            if (maze[position[0]][position[1] + 1] == (int)Surface.Chest)
                discovered[position[0]][position[1] + 1] = CHEST;

            //if the area to the bottom right is/isnt a wall

            if (maze[position[0] + 1][position[1] + 1] == (int)Surface.Chest)
                discovered[position[0] + 1][position[1] + 1] = CHEST;

            //if the area below is/isnt a wall

            if (maze[position[0] + 1][position[1]] == (int)Surface.Chest)
                discovered[position[0] + 1][position[1]] = CHEST;

            //if the area to the bottom left is/isnt a wall

            if (maze[position[0] + 1][position[1] - 1] == (int)Surface.Chest)
                discovered[position[0] + 1][position[1] - 1] = CHEST;

            //if the area to the left is/isnt a wall

            if (maze[position[0]][position[1] - 1] == (int)Surface.Chest)
                discovered[position[0]][position[1] - 1] = CHEST; 
        }
*/
        #region MazeGeration

        public MazeObject generate(int size)
        {
            if (size < minSize)
                return null;

            int[][] maze;
            int height = size - 1;
            int width = size - 1;


            maze = new int [size][];
            for (int x = 0; x < size; x++)
                maze[x] = new int[size];
            List<string> walls = new List<string>();
            int wallChoice;
            string coordinates;
            Random rnd = new Random();
            maze[1][1] = (int)EnumMazeObject.Air;
            AddWalls(1, 1, walls, maze, height, width);

            while (walls.Count != 0)
            {
                int r, c;
                string temp;

                //randomly select a wall and get it from the list
                wallChoice = rnd.Next(walls.Count);
                coordinates = walls.ElementAt<string>(wallChoice);

                //take the string coordinates and assign them to row and coulumn
                temp = coordinates.Substring(0, coordinates.IndexOf(','));
                r = int.Parse(temp);
                temp = coordinates.Substring(coordinates.IndexOf(',') + 1);
                c = int.Parse(temp);

                //boolean to tell if a path was made and it will try each option if needed

                //make a wall passage if no cell is air on the other side
               
                    //Up
                if ((r + 1) < height && maze[r + 1][c] == (int)EnumMazeObject.Air)
                {
                    //the bounds around the movement are inside the array
                    if ((r - 2) >= 0 && (c - 1) >= 0 && (c + 1) <= width && maze[r][c] == (int)EnumMazeObject.Wall)
                        //the movement is possible if this is true because there is a 1 block radius to any other part
                        if (maze[r][c - 1] == (int)EnumMazeObject.Wall && /*maze[r - 1][c - 1] == (int)Surface.Wall &&*/
                            maze[r - 1][c] == (int)EnumMazeObject.Wall && /*maze[r - 1][c + 1] == (int)Surface.Wall &&*/
                            maze[r][c + 1] == (int)EnumMazeObject.Wall)
                        {
                            maze[r][c] = (int)EnumMazeObject.Air;
                            AddWalls(r, c, walls, maze, height, width);                               
                        }
                }
                    //Down
                else if ((r - 1) > 0 && maze[r - 1][c] == (int)EnumMazeObject.Air)
                {
                    //the bounds around the movement are inside the array
                    if ((r + 1) <= height && (c - 1) >= 0 && (c + 1) <= width)
                        //the movement is possible if this is true because there is a 1 block radius to any other part
                        if (maze[r][c - 1] == (int)EnumMazeObject.Wall && /*maze[r + 1][c - 1] == (int)Surface.Wall &&*/
                            maze[r + 1][c] == (int)EnumMazeObject.Wall && /*maze[r + 1][c + 1] == (int)Surface.Wall &&*/
                            maze[r][c + 1] == (int)EnumMazeObject.Wall)
                        {
                            maze[r][c] = (int)EnumMazeObject.Air;
                            AddWalls(r, c, walls, maze, height, width);      
                        }
                }
                    //Came from Left
                else if ((c - 1) > 0 && maze[r][c - 1] == (int)EnumMazeObject.Air)
                {
                    //the bounds around the movement are inside the array
                    if ((c + 1) <= width && (r - 1) >= 0 && (r + 1) <= height)
                        //the movement is possible if this is true because there is a 1 block radius to any other part
                        if (maze[r - 1][c] == (int)EnumMazeObject.Wall && /*maze[r - 1][c + 1] == (int)Surface.Wall &&*/
                            maze[r][c + 1] == (int)EnumMazeObject.Wall && /*maze[r + 1][c + 1] == (int)Surface.Wall &&*/
                            maze[r + 1][c] == (int)EnumMazeObject.Wall)
                        {
                            maze[r][c] = (int)EnumMazeObject.Air;
                            AddWalls(r, c, walls, maze, height, width);                           
                        }
                }
                    //Came from Right
                else if ((c + 1) < width && maze[r][c + 1] == (int)EnumMazeObject.Air)
                {
                    //the bounds around the movement are inside the array
                    if ((c - 1) >= 0 && (r - 1) >= 0 && (r + 1) <= height)
                        //the movement is possible if this is true because there is a 1 block radius to any other part
                        if (maze[r - 1][c] == (int)EnumMazeObject.Wall && /*maze[r - 1][c - 1] == (int)Surface.Wall &&*/
                            maze[r][c - 1] == (int)EnumMazeObject.Wall && /*maze[r + 1][c - 1] == (int)Surface.Wall &&*/
                            maze[r + 1][c] == (int)EnumMazeObject.Wall)
                        {
                            maze[r][c] = (int)EnumMazeObject.Air;
                            AddWalls(r, c, walls, maze, height, width);                           
                        }
                }

                //remove wall from the list
                walls.RemoveAt(wallChoice);
            }//end outer while

            //put an exit in the bottom row
            for (int y = width - 1; y > 0; y--)
            {
                if (maze[height - 1][y] == (int)EnumMazeObject.Air && OneWayIn(height-1, y, maze))
                {
                    maze[height - 1][y] = (int)EnumMazeObject.Exit;
                    break;
                }
            }



            //add chests in the maze randomly -------------------------------------- not so random at the moment
            for (int x = 1; x < height; x++)
            {
                for (int y = 1; y < width; y++)
                {
                    if (OneWayIn(x, y, maze))
                        maze[x][y] = (int)EnumMazeObject.Chest;
                }
            }


            //place the player at the start (will always be a valid position)
            maze[1][1] = (int)EnumMazeObject.Player;
             
            //turn into node system
            
            return arrayToGraph(maze);



        }

        private MazeObject arrayToGraph(int[][] maze)
        {
            _head = new MazeObjectWall();

            for(int r = 0; r < maze.Length; r++)
            {
                MazeObject temp = _head;
                for(int z = 0; z < r; z++)
                {
                    temp = temp.getSurroundings().getDown();
                }

                for(int c = 0; c < maze[0].Length; c++)
                {
                    if (r > 0)
                    {
                        int up = maze[r - 1][c];
                        if (temp.getSurroundings().getUp() == null)
                        {
                            temp.getSurroundings().setUp( FMazeObjectFactory.getMazeObject(up) );
                            temp.getSurroundings().getUp().getSurroundings().setDown(temp);
                        }
                    }
                    if (c > 0)
                    {
                        int left = maze[r][c - 1];
                        if (temp.getSurroundings().getLeft() == null)
                        {
                            temp.getSurroundings().setLeft( FMazeObjectFactory.getMazeObject(left) );
                            temp.getSurroundings().getLeft().getSurroundings().setRight(temp);
                        }
                    }
                    if (r < maze.Length - 1)
                    {
                        int down = maze[r + 1][c];
                        if (temp.getSurroundings().getDown() == null)
                        {
                            temp.getSurroundings().setDown( FMazeObjectFactory.getMazeObject(down) );
                            temp.getSurroundings().getDown().getSurroundings().setUp(temp);

                            if (c > 0)
                            {
                                MazeObject downBelow = temp.getSurroundings().getDown();
                                MazeObject downLeft = temp.getSurroundings().getLeft().getSurroundings().getDown();

                                downBelow.getSurroundings().setLeft(downLeft);
                                downLeft.getSurroundings().setRight(downBelow);

                            }

                        }
                    }
                    if (c < maze[0].Length - 1)
                    {
                        int right = maze[r][c + 1];
                        if (temp.getSurroundings().getRight() == null)
                        {
                            temp.getSurroundings().setRight( FMazeObjectFactory.getMazeObject(right) );
                            temp.getSurroundings().getRight().getSurroundings().setLeft(temp);
                        }
                    }

                    temp = temp.getSurroundings().getRight();
                }
            }


            

            //Player.getInstance().setPosition( _head.getSurroundings().getDown().getSurroundings().getRight() );


            return _head;

        }//end Generate


        private bool OneWayIn(int x, int y, int[][]maze)
        {
            if ((x != 1 || y != 1) && maze[x][y] == (int)EnumMazeObject.Air)
            {
                int numSurfaceAir = 0;

                if (maze[x - 1][y] == (int)EnumMazeObject.Air || maze[x - 1][y] == (int)EnumMazeObject.Chest || maze[x - 1][y] == (int)EnumMazeObject.Exit)
                    numSurfaceAir++;

                if (maze[x + 1][y] == (int)EnumMazeObject.Air || maze[x + 1][y] == (int)EnumMazeObject.Chest || maze[x + 1][y] == (int)EnumMazeObject.Exit)
                    numSurfaceAir++;

                if (maze[x][y - 1] == (int)EnumMazeObject.Air || maze[x][y - 1] == (int)EnumMazeObject.Chest || maze[x][y - 1] == (int)EnumMazeObject.Exit)
                    numSurfaceAir++;

                if (maze[x][y + 1] == (int)EnumMazeObject.Air || maze[x][y + 1] == (int)EnumMazeObject.Chest || maze[x][y + 1] == (int)EnumMazeObject.Exit)
                    numSurfaceAir++;

                if (numSurfaceAir == 1)
                    return true;
            }
            return false;

        }


        private void AddWalls(int r, int c, List<string> walls, int [][] maze, int height, int width)
        {
            //add wall above
            if((r - 1) > 0 && (maze[r - 1][c] == (int)EnumMazeObject.Wall))
                if (maze[r - 1][c - 1] == (int)EnumMazeObject.Wall && maze[r - 2][c - 1] == (int)EnumMazeObject.Wall &&
                    maze[r - 2][c] == (int)EnumMazeObject.Wall && maze[r - 2][c + 1] == (int)EnumMazeObject.Wall &&
                    maze[r - 1][c + 1] == (int)EnumMazeObject.Wall && maze[r - 1][c] == (int)EnumMazeObject.Wall)
                        walls.Add("" + (r - 1) + "," + (c));

            //add wall below
            if ((r + 1) < (height) && (maze[r + 1][c] == (int)EnumMazeObject.Wall))
                if (maze[r + 1][c + 1] == (int)EnumMazeObject.Wall && maze[r + 2][c + 1] == (int)EnumMazeObject.Wall &&
                    maze[r + 2][c] == (int)EnumMazeObject.Wall && maze[r + 2][c - 1] == (int)EnumMazeObject.Wall &&
                    maze[r + 1][c - 1] == (int)EnumMazeObject.Wall && maze[r + 1][c] == (int)EnumMazeObject.Wall)
                        walls.Add("" + (r + 1) + "," + (c)); 

            //add wall to left
            if ((c - 1) > 0 && (maze[r][c - 1] == (int)EnumMazeObject.Wall))
                if (maze[r + 1][c - 1] == (int)EnumMazeObject.Wall && maze[r + 1][c - 2] == (int)EnumMazeObject.Wall &&
                    maze[r][c - 2] == (int)EnumMazeObject.Wall && maze[r - 1][c - 2] == (int)EnumMazeObject.Wall &&
                    maze[r - 1][c - 1] == (int)EnumMazeObject.Wall && maze[r][c - 1] == (int)EnumMazeObject.Wall)
                        walls.Add("" + (r) + "," + (c - 1));

            //add wall to right
            if ((c + 1) < (width) && (maze[r][c + 1] == (int)EnumMazeObject.Wall))
                if (maze[r - 1][c + 1] == (int)EnumMazeObject.Wall && maze[r - 1][c + 2] == (int)EnumMazeObject.Wall &&
                    maze[r][c + 2] == (int)EnumMazeObject.Wall && maze[r + 1][c + 2] == (int)EnumMazeObject.Wall &&
                    maze[r + 1][c + 1] == (int)EnumMazeObject.Wall && maze[r][c + 1] == (int)EnumMazeObject.Wall)
                        walls.Add("" + (r) + "," + (c + 1));
        }

        #endregion






    }

}