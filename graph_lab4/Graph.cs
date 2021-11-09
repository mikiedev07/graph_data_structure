using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace graph_lab4
{
    class Graph
    {
        public List<Vertex> V = new List<Vertex>();
        public List<Edge> E = new List<Edge>();

        public int VertexCount => V.Count;
        public int EdgeCount => E.Count;

        public void AddVertex(Vertex vertex)
        {
            V.Add(vertex);
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            E.Add(edge);
        }

        public int[,] getMatrix()
        {

            var matrix = new int[V.Count, V.Count];

            foreach (var edge in E)
            {
                var row = edge.From.number - 1;
                var column = edge.To.number - 1;

                matrix[row, column] = edge.Weight;
            }

            return matrix;
        }

        public List<Vertex> GetVertexLists(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach (var edge in E)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }

            return result;  // список смежных вершин
        }


        public List<Vertex> BFS(Vertex start, Vertex finish, Graphics g)
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.PowderBlue);
            var list = new List<Vertex>();

            list.Add(start);
            Rectangle rect = new Rectangle(start.xCoord - 9, start.yCoord + 3, 8, 8);
            Rectangle rect1 = new Rectangle(start.xCoord - 9, start.yCoord + 3, 8, 8);
            g.FillRectangle(redBrush, rect);
            System.Threading.Thread.Sleep(500);
            g.FillRectangle(whiteBrush, rect1);

            for (int i = 0; i < list.Count; i++)
            {
                var vertex = list[i];
                foreach (var v in GetVertexLists(vertex))
                {
                    if (!list.Contains(v))
                    {
                        list.Add(v);
                        Rectangle rect2 = new Rectangle(v.xCoord - 9, v.yCoord + 3, 8, 8);
                        Rectangle rect3 = new Rectangle(v.xCoord - 9, v.yCoord + 3, 8, 8);
                        g.FillRectangle(redBrush, rect2);
                        System.Threading.Thread.Sleep(500);
                        g.FillRectangle(whiteBrush, rect3);
                        if (v == finish)
                        {
                            Console.WriteLine("Finished:");
                            return list;
                        }
                    }
                }
            }
            Console.WriteLine("Not found");
            return list;
        }

        private Vertex finish;
        private List<Vertex> visited = new List<Vertex>();
        private LinkedList<Vertex> result_path = new LinkedList<Vertex>();

        public LinkedList<Vertex> DFS(Vertex start, Vertex finish, Graphics g)
        {
            visited.Clear();
            result_path.Clear();
            this.finish = finish;

            DFS(start, g);

            if (result_path.Count > 0)
            {
                result_path.AddFirst(start);
            }
            return result_path;
        }

        public bool DFS(Vertex node, Graphics g)
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.PowderBlue);

            if (node == finish)
            {
                return true;
            }
            visited.Add(node);
            Rectangle rect = new Rectangle(node.xCoord - 9, node.yCoord + 3, 8, 8);
            Rectangle rect1 = new Rectangle(node.xCoord - 9, node.yCoord + 3, 8, 8);
            g.FillRectangle(redBrush, rect);
            System.Threading.Thread.Sleep(500);
            g.FillRectangle(whiteBrush, rect1);

            foreach (var child in GetVertexLists(node).Where(x => !visited.Contains(x)))
            {
                if (DFS(child, g))
                {
                    result_path.AddFirst(child);
                    Rectangle rect3 = new Rectangle(child.xCoord - 9, child.yCoord + 3, 8, 8);
                    Rectangle rect4 = new Rectangle(child.xCoord - 9, child.yCoord + 3, 8, 8);
                    g.FillRectangle(redBrush, rect3);
                    System.Threading.Thread.Sleep(500);
                    g.FillRectangle(whiteBrush, rect4);
                    return true;
                }
            }
            return false;
        }
    }
}
