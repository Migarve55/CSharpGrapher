
using System;
using System.Collections.Generic;
using System.Linq;
using Priority_Queue;

namespace GraphUtil
{
    public class GridGraph
    {

        private bool[,] _matrix;
        
        public int X => _matrix.GetLength(0);
        public int Y => _matrix.GetLength(1);

        public GridGraph(int x, int y)
        {
            this._matrix = new bool[x,y];
        }

        public void SetCell(int x, int y, bool active)
        {
            _matrix[x, y] = active;
        }

        public bool GetCell(int x, int y)
        {
            return _matrix[x, y];
        }

        public ICollection<CellNode> AStar(int sx, int sy, int ex, int ey)
        {
            CellNode start = new CellNode(sx, sy);
            CellNode goal = new CellNode(ex, ey);
            
            //Create data structures
            IDictionary<CellNode,CellNode> cameFrom = new Dictionary<CellNode, CellNode>();
            
            ISet<CellNode> closedSet = new HashSet<CellNode>();
            ISet<CellNode> openSet = new HashSet<CellNode>();
            openSet.Add(start);

            int[,] gScore = StartMatrix();
            gScore[start.X, start.Y] = 0;
            
            int[,] fScore = StartMatrix();
            fScore[start.X, start.Y] = HeuristicCostEstimate(start, goal);
            //Start
            while (openSet.Count > 0)
            {
                CellNode current = openSet
                    .Aggregate(((node, cellNode) => fScore[node.X, node.Y] < fScore[cellNode.X, cellNode.Y] ? node : cellNode));
                if (current.Equals(goal))
                    return Path(cameFrom, current);
                openSet.Remove(current);
                closedSet.Add(current);
                //Explore neighbours
                foreach (var neighbor in GetNeighbours(current))
                {
                    if (closedSet.Contains(neighbor))
                        continue;

                    int tentativeGScore = gScore[current.X, current.Y] + 1;

                    if (!openSet.Contains(neighbor))
                        openSet.Add(neighbor);
                    else if (tentativeGScore >= gScore[neighbor.X, neighbor.Y])
                        continue;

                    cameFrom[neighbor] = current;
                    gScore[neighbor.X, neighbor.Y] = tentativeGScore;
                    fScore[neighbor.X, neighbor.Y] = gScore[neighbor.X, neighbor.Y] + HeuristicCostEstimate(neighbor, goal);
                }
            }
            return null;
        }

        public ICollection<CellNode> Dijkstra(int sx, int sy, int ex, int ey)
        {
            CellNode start = new CellNode(sx, sy);
            CellNode goal = new CellNode(ex, ey);
            
            //Create data structures
            IDictionary<CellNode,CellNode> cameFrom = new Dictionary<CellNode, CellNode>();
            IPriorityQueue<CellNode, int> queue = new SimplePriorityQueue<CellNode, int>();
            
            int[,] dist = new int[X, Y];
            dist[start.X, start.Y] = 0;
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (!_matrix[i,j])
                    {
                        var node = new CellNode(i, j);
                        if (!node.Equals(start))
                            dist[i, j] = int.MaxValue;
                        queue.Enqueue(node, dist[i, j]);
                    }
                }
            }
            
            //Start
            while (queue.Count > 0)
            {
                CellNode current = queue.Dequeue();
                foreach (var neighbour in GetNeighbours(current))
                {
                    int alt = 0;
                    alt = dist[current.X, current.Y] + 1;
                    //Check overflow
                    if (alt == int.MinValue)
                        alt = int.MaxValue;
                    if (alt < dist[neighbour.X, neighbour.Y])
                    {
                        dist[neighbour.X, neighbour.Y] = alt;
                        cameFrom[neighbour] = current;
                        queue.UpdatePriority(neighbour, alt);
                    }
                }
            }
            return Path(cameFrom, goal);
        }

        private int[,] StartMatrix()
        {
            int[,] m = new int[_matrix.GetLength(0), _matrix.GetLength(1)];
            for (int i = 0; i < _matrix.GetLength(0); i++)
                for (int j = 0; j < _matrix.GetLength(1); j++)
                    m[i, j] = int.MaxValue;
            return m;
        }

        private int HeuristicCostEstimate(CellNode start, CellNode goal)
        {
            var dx = goal.X - start.X;
            var dy = goal.Y - start.Y;
            return (int) Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

        private ICollection<CellNode> GetNeighbours(CellNode node)
        {
            ICollection<CellNode> neighbours = new List<CellNode>();
            //If it is active, it has no neighbours
            if (_matrix[node.X, node.Y])
                return neighbours;
            //Check surroundings
            int sx = _matrix.GetLength(0) - 1;
            int sy = _matrix.GetLength(1) - 1;
            if (node.X > 0)
                if (!_matrix[node.X - 1, node.Y])
                    neighbours.Add(new CellNode(node.X - 1, node.Y));
            if (node.X < sx)
                if (!_matrix[node.X + 1, node.Y])
                    neighbours.Add(new CellNode(node.X + 1, node.Y));
            if (node.Y > 0)
                if (!_matrix[node.X, node.Y - 1])
                    neighbours.Add(new CellNode(node.X, node.Y - 1));
            if (node.Y < sy)
                if (!_matrix[node.X, node.Y + 1])
                    neighbours.Add(new CellNode(node.X, node.Y + 1));
            return neighbours;
        }

        private ICollection<CellNode> Path(IDictionary<CellNode,CellNode> cameFrom, CellNode current)
        {
            ICollection<CellNode> path = new List<CellNode>();
            while (cameFrom.Keys.Contains(current))
            {
                current = cameFrom[current];
                path.Add(current);
            }
            return path;
        }
        
    }
}