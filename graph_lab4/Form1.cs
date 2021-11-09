using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace graph_lab4
{
    public partial class Form1 : Form
    {
        Graph inst = new Graph();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox2.CreateGraphics();
            path.Clear();
            int v1 = int.Parse(vertex_1.Text);
            int v2 = int.Parse(vertex_2.Text);
            int tmp = 0;

            List<Vertex> newList = inst.BFS(inst.V[v1 - 1], inst.V[v2 - 1], g);

            int count = newList.Count - 1;

            for (int i = 0; i < newList.Count; i++)
            {
                path.AppendText(newList[i].number.ToString());
                if (tmp < count)
                {
                    path.AppendText(" > ");
                }
                tmp++;
            }
        }

        private void dfs_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox2.CreateGraphics();
            path.Clear();

            int v1 = int.Parse(vertex_1.Text);
            int v2 = int.Parse(vertex_2.Text);
            int tmp = 0;

            LinkedList<Vertex> newList = inst.DFS(inst.V[v1 - 1], inst.V[v2 - 1], g);

            int count = newList.Count - 1;

            foreach(var elem in newList)
            {
                path.AppendText(elem.number.ToString());
                if (tmp < count)
                {
                    path.AppendText(" > ");
                }
                tmp++;
            }
        }

        private void show_graph_Click(object sender, EventArgs e)
        {
            Font drawFont = new Font("Arial", 11);
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            Graphics g = pictureBox2.CreateGraphics();

            string path = @"input_data.txt";
            string[] reafText = File.ReadAllLines(path);
            string[] vertexes = reafText[0].Split(' ');
            string[] coordinates;
            string[] edge;

            foreach (var elem in vertexes)
            {
                int val = int.Parse(elem);
                var v = new Vertex(val);
                inst.AddVertex(v);
            }

            for(int i = 1; i <= vertexes.Length; i++)
            {
                coordinates = reafText[i].Split(' ');
                inst.V[i - 1].xCoord = int.Parse(coordinates[0]);
                inst.V[i - 1].yCoord = int.Parse(coordinates[1]);

                g.DrawEllipse(Pens.Black, inst.V[i - 1].xCoord, inst.V[i - 1].yCoord, 25, 25);

                if (inst.V[i - 1].number.ToString().Length == 1)
                {
                    g.DrawString(inst.V[i - 1].number.ToString(), drawFont, solidBrush, inst.V[i - 1].xCoord+6, inst.V[i - 1].yCoord+4);
                }
                else
                {
                    g.DrawString(inst.V[i - 1].number.ToString(), drawFont, solidBrush, inst.V[i - 1].xCoord + 2, inst.V[i - 1].yCoord + 4);
                }
            }


            for (int i = vertexes.Length + 1; i < reafText.Length; i++)
            {
                edge = reafText[i].Split(' ');
                int val1 = int.Parse(edge[0]);
                int val2 = int.Parse(edge[1]);

                inst.AddEdge(inst.V[val1 - 1], inst.V[val2 - 1]);

                Point pt1 = new Point(inst.V[val1 - 1].xCoord+12, inst.V[val1 - 1].yCoord+20);
                Point pt2 = new Point(inst.V[val2 - 1].xCoord+12, inst.V[val2 - 1].yCoord+20);

                g.DrawLine(Pens.Black, pt1, pt2);
            }
        }
        private static void PrintPath(LinkedList<Vertex> path)
        {
            Console.WriteLine();
            if (path.Count == 0)
            {
                Console.WriteLine("You shall no pass!");
            }
            else
            {
                Console.WriteLine("finished");
                Console.WriteLine(string.Join(" ", path.Select(x => x.number)));
            }
            Console.Read();
        }
    }
}
