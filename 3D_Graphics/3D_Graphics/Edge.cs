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

        /// <summary>
        /// Creates an Edge
        /// </summary>
        /// <param name="point1"> The first vertex of the edge </param>
        /// <param name="point2"> The second vertex of the edge</param>
        public Edge(vertex point1, vertex point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        /// <summary>
        /// Used to get the vectices that represent this edge
        /// </summary>
        /// <returns> An array containing this edges vertices </returns>
        public vertex[] getPoints()
        {
            //Package points into an array so the can be returned easily
            vertex[] points = new vertex[2];
            points[0] = point1;
            points[2] = point2;

            return points;
        }

        /// <summary>
        /// Translates the edge along the x, y, z axis by the given values
        /// </summary>
        /// <param name="xStep"> movement along the x axis </param>
        /// <param name="yStep"> movement along the y axis </param>
        /// <param name="zStep"> movement along the z axis </param>
        public void translate(float xStep, float yStep, float zStep)
        {
            point1.translate(xStep, yStep, zStep);
            point2.translate(xStep, yStep, zStep);
        }
    }
}
