using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3D_Graphics
{
    class vertex
    {
        private Vector3f position;

        /// <summary>
        /// A vertex representing a point on an object
        /// </summary>
        /// <param name="position"> the (x, y, z) position of the vertex </param>
        public vertex(Vector3f position)
        {
            this.position = position;
        }

        /// <summary>
        /// Rotates the vertex around a given point !!!To be implemented!!!
        /// </summary>
        /// <returns> The new postion of the vertex </returns>
        public Vector3f rotateAround()
        {
            return position;
        }

        /// <summary>
        /// Translates the vertex along the x, y, z axis by the given values !!!To be implemented!!!
        /// </summary>
        /// <param name="xStep"> movement along the x axis </param>
        /// <param name="yStep"> movement along the y axis </param>
        /// <param name="zStep"> movement along the z axis </param>
        /// <returns> The new position of the vertex </returns>
        public Vector3f translate(float xStep, float yStep, float zStep)
        {
            return position;
        }

        /// <summary>
        /// Moves the vertex to a new position
        /// </summary>
        /// <param name="newPosition"> The position the vertex should be moved to </param>
        /// <returns> The new position of the vertex </returns>
        public Vector3f setPosition(Vector3f newPosition)
        {
            position = newPosition;
            return position;
        }
    }
}
