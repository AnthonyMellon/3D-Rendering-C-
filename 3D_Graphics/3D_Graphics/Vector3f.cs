using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Graphics
{
    /// <summary>
    /// Represents a 3D vector made of 3 floats (x, y, z)
    /// </summary>
    public struct Vector3f
    {
        /// <summary>
        /// Represents a 3D vector made of 3 floats (x, y, z)
        /// </summary>
        /// <param name="X"> X position of the vector </param>
        /// <param name="Y"> Y position of the vector </param>
        /// <param name="Z"> Z position of the vector </param>
        public Vector3f(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}
