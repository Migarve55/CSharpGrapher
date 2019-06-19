using System;
using System.Collections.Generic;
using GraphUtil;

namespace AStarTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int x = 70, y = 70;

            int sx = 0, sy = 0;
            int ex = x - 1, ey = y - 1;
            
            GridGraph graph = new GridGraph(x, y);
            
            graph.SetCell(4, 0, true);
            graph.SetCell(4, 1, true);
            graph.SetCell(4, 2, true);
            graph.SetCell(4, 3, true);
            graph.SetCell(4, 4, false);
            graph.SetCell(4, 5, true);
            graph.SetCell(4, 6, true);
            graph.SetCell(4, 7, true);
            graph.SetCell(4, 8, true);
            graph.SetCell(4, 9, true);

            ICollection<CellNode> path = graph.AStar(sx, sy, ex, ey);
            if (path == null)
            {
                Console.Out.WriteLine("Could not find path");
                return;   
            }

            char[,] map = new char[x, y];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    map[i, j] = graph.GetCell(i, j) ? '█' : '▒';
            foreach (var cellNode in path)
            {
                map[cellNode.X, cellNode.Y] = '*';
            }

            map[sx, sy] = 'S';
            map[ex, ey] = 'E';

            Console.Out.WriteLine("Result:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                    Console.Write(map[i, j]);
                Console.WriteLine();
            }
        }
    }
}