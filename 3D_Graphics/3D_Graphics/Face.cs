using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3D_Graphics
{    
    /// <summary>
    /// A face made of three edges, forming a triangle
    /// </summary>
    class Face
    {
        public Edge edge1;
        public Edge edge2;
        public Edge edge3;

        public Color color;

        /// <summary>
        /// Creates a triangluar face from three edges
        /// </summary>
        /// <param name="edge1"> The first edge of the face </param>
        /// <param name="edge2"> The second edge of the face </param>
        /// <param name="edge3"> The third edge of the face </param>
        /// <param name="color"> The color of the face </param>
        public Face(Edge edge1, Edge edge2, Edge edge3, Color color)
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
            this.edge3 = edge3;
            this.color = color;
        }

        /// <summary>
        /// Used to get the edges that represent this face
        /// </summary>
        /// <returns> An array containing this faces edges </returns>
        public Edge[] GetEdges()
        {
            //Package the edges into an array so they can be easily returned
            Edge[] edges = new Edge[3];
            edges[0] = edge1;
            edges[1] = edge2;
            edges[2] = edge3;

            return edges;
        }        

        /// <summary>
        /// Translates the face along the x, y, z axis by the given values
        /// </summary>
        /// <param name="xStep"> movement along the x axis </param>
        /// <param name="yStep"> movement along the y axis </param>
        /// <param name="zStep"> movement along the z axis </param>
        public void translate(float xStep, float yStep, float zStep)
        {
            edge1.translate(xStep, yStep, zStep);
            edge2.translate(xStep, yStep, zStep);
            edge3.translate(xStep, yStep, zStep);
        }
    }
}
