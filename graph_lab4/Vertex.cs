using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_lab4
{
    class Vertex
    {
        public Vertex(int Number)
        {
            number = Number;
        }

        public int number { get; set; }
        public int xCoord { get; set; }
        public int yCoord { get; set; }

        public override string ToString()
        {
            return number.ToString();
        }

    }
}
