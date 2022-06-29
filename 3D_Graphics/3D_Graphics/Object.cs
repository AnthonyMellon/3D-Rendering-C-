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
        public Vector3f rotation;

        private Vector3f centerPoint;

        public Object(Vector3f position, Vector3f rotation)
        {
            this.position = position;
            this.rotation = rotation;
        }

        public Vector3f rotate(int axis, float degreeIncrement)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Rotation: ({rotation.ToString()})");

            //Increment rotation along axis
            float[] tempRotation = rotation.AsArray();
            tempRotation[axis] += degreeIncrement;
            tempRotation[axis] = tempRotation[axis] % 360;
            rotation.fromArray(tempRotation);

            //Rotate all points            
            foreach(vertex vertex in getPoints())
            {
                Console.WriteLine(centerPoint);
                vertex.rotate(centerPoint, axis, extraMath.DegToRad(degreeIncrement));                
            }
            //centerPoint = getCenterPoint();


            return rotation;
        }

        private Vector3f getCenterPoint()
        {
            List<vertex> points = getPoints();

            //Add up all points into on vector
            Vector3f centerPoint = new Vector3f(0, 0, 0);
            foreach(vertex vertex in points)
            {
                centerPoint.X += vertex.getPosition().X;
                centerPoint.Y += vertex.getPosition().Y;
                centerPoint.Z += vertex.getPosition().Z;
            }

            //Average all vector components
            centerPoint.X = centerPoint.X / points.Count();
            centerPoint.Y = centerPoint.Y / points.Count();
            centerPoint.Z = centerPoint.Z / points.Count();

            return centerPoint;
        }

        private List<vertex> getPoints()
        {
            //Gather all points in the object
            List<vertex> points = new List<vertex>();
            foreach (Face face in faces)//Loop through each face in the object
            {
                foreach (Edge edge in face.GetEdges())//Loop through each edge in the face
                {
                    foreach (vertex vertex in edge.getPoints())//Loop through each vertex in edge
                    {
                        points.Add(vertex);
                    }
                }
            }

            //Remove duplicate points
            List<vertex> pointsClean = new List<vertex>();
            foreach (vertex vertex in points) //Loop through all the gathered points
            {
                bool duplicate = false;
                foreach (vertex cleanVertex in pointsClean) //Loop through all unique points found so far
                {
                    if (vertex == cleanVertex) //Check if the current point is a duplicate
                    {
                        duplicate = true;
                    }
                }
                if (!duplicate) //If its not a duplicate, add it to the list of unique points
                {
                    pointsClean.Add(vertex);
                }
            }

            return pointsClean;
        }

        public List<Face> addFace(Face newFace)
        {
            faces.Add(newFace);
            centerPoint = getCenterPoint();
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
