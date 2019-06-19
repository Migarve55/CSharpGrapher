using System;
using System.Collections.Generic;
using System.Diagnostics;
using GraphUtil;
using System.Drawing;
using System.IO;

namespace MazeSolver
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /**
            SolveMaze("tiny");
            SolveMaze("small");
            SolveMaze("normal");
            SolveMaze("braid200");
            SolveMaze("logo");
            SolveMaze("combo400");
            SolveMaze("braid2k");
            SolveMaze("perfect2k");
            SolveMaze("perfect4k");
            SolveMaze("combo6k");
            **/
            SolveMaze("perfect10k");
            //SolveMaze("perfect15k");
        }

        private static void SolveMaze(string name)
        {
            string input = $"mazes/{name}.png";
            string output = $"solved/{name}.png";
            GridGraph graph = FromFile(input, out int sx, out int sy, out int ex, out int ey);
            
            Console.Out.WriteLine("Solving {0}...", name);
            Stopwatch stopwatch = Stopwatch.StartNew();
            IEnumerable<CellNode> path = graph.Dijkstra(sx, sy, ex, ey);
            stopwatch.Stop();
            if (path == null)
            {
                Console.Out.WriteLine("Could not solve {0}", name);
                return;
            }

            Console.Out.WriteLine("Solved in {0}", stopwatch.Elapsed);
            
            WriteToFile(input, output, path);
        }

        private static GridGraph FromFile(string path, out int sx, out int sy, out int ex, out int ey)
        {
            var maze = new Bitmap(path);
            sx = 1;
            sy = 1;
            ex = maze.Width - 1;
            ey = maze.Height - 1;
            var graph = new GridGraph( maze.Width, maze.Height);
            for (int i = 0; i < maze.Width; i++)
            {
                for (int j = 0; j < maze.Height; j++)
                {
                    Color color = maze.GetPixel(i, j);
                    if (color.R == 0 && color.G == 0 && color.B == 0)
                        graph.SetCell(i, j, true);
                    else if (j == 0)
                        sx = i;
                    else if (j == maze.Height - 1)
                        ex = i;
                }
            }
            return graph;
        }

        private static void WriteToFile(string pathToOriginal, string pathToOutput, IEnumerable<CellNode> path)
        {
            var maze = new Bitmap(new Bitmap(pathToOriginal));
            foreach (var node in path)
            {
                maze.SetPixel(node.X, node.Y, Color.Red);
            }
            maze.Save(pathToOutput);
        }
        
    }
}