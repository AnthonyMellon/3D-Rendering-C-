using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Graphics
{
    /// <summary>
    /// Represents a 2d Edge that consists of two vertices
    /// </summary>
    class Edge
    {
        public vertex point1;
        public vertex point2;
        public Edge(vertex point1, vertex point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
    }
}
