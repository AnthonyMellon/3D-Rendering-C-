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
        /// Creates a vertex
        /// </summary>
        /// <param name="position"> the (x, y, z) position of the vertex </param>
        public vertex(Vector3f position)
        {
            this.position = position;
        }

        /// <summary>
        /// Rotates the vertex around a given radius !!!To be implemented!!!
        /// </summary>
        /// <param name="anchorPoint"> The point to rotate around </param>
        /// <param name="axis"> The axis of rotation </param>
        /// <param name="angleRad"> The angle of rotation in radians </param>
        /// <returns> The new position of the vertex </returns>
        public Vector3f rotate(Vector3f anchorPoint, int axis, float angleRad)
        {
            //Take vector components not on rotational axis for rotation point and anchor point
            List<float> pos2D = position.AsList();
            float oldPoint = pos2D[axis];
            pos2D.RemoveAt(axis);

            List<float> anchor2D = anchorPoint.AsList();
            anchor2D.RemoveAt(axis);

            //Rotate the point
            float xRot = (float)(Math.Cos(angleRad) * (pos2D[0] - anchor2D[0]) - Math.Sin(angleRad) * (pos2D[1] - anchor2D[1]) + anchor2D[0]);
            float yRot = (float)(Math.Sin(angleRad) * (pos2D[0] - anchor2D[0]) + Math.Cos(angleRad) * (pos2D[1] - anchor2D[1]) + anchor2D[1]);
            pos2D[0] = xRot;
            pos2D[1] = yRot;

            //Re-insert vector components not on rotational axis into the position
            pos2D.Insert(axis, oldPoint);
            position.fromList(pos2D);
            Console.WriteLine($"Position2D: ({pos2D[0]}, {pos2D[1]})");
            Console.WriteLine($"Position: ({position})");

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
        
        /// <summary>
        /// Used to get the position of the vertex
        /// </summary>
        /// <returns> The 3D position of the vertex </returns>
        public Vector3f getPosition()
        {
            return position;
        }
    }
}
