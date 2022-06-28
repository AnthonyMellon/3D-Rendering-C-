using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Graphics
{
    class Object
    {
        private List<Face> faces = new List<Face>();

        public Vector3f position;

        public Object(Vector3f position)
        {
            this.position = position;
        }

        public List<Face> addFace(Face newFace)
        {
            faces.Add(newFace);
            return faces;
        }

        /// <summary>
        /// Removes a face at the given index from the object
        /// </summary>
        /// <param name="index"> Index of the face to be removed </param>
        /// <returns> The new list of faces </returns>
        public List<Face> removeFace(int index)
        {
            faces.RemoveAt(index);
            return faces;
        }

        /// <summary>
        /// Removes a given face from the object
        /// </summary>
        /// <param name="face"> The face to be removed </param>
        /// <returns> The new list of faces </returns>
        public List<Face> removeFace(Face face)
        {
            faces.Remove(face);
            return faces;
        }

        /// <summary>
        /// Used to get the faces that make up this object
        /// </summary>
        /// <returns> The faces the make up this object </returns>
        public List<Face> getFaces()
        {
            return faces;
        }
    }
}
