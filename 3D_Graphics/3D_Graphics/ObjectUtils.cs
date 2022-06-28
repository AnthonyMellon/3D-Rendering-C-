using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3D_Graphics
{
    static class ObjectUtils
    {
        public static Object create2DTriangle(Vector3f position, float size)
        {
            Object triangle = new Object(position);

            //Setup the three vertices
            Vector3f p1 = new Vector3f(position.X, position.Y - size / 2, position.Z); //Top vertex
            Vector3f p2 = new Vector3f(position.X - size / 2, position.Y + size / 2, position.Z); //Bottom-left vertex
            Vector3f p3 = new Vector3f(position.X + size / 2, position.Y + size / 2, position.Z); //Bottom-right vertex
            
            vertex v1 = new vertex(p1);
            vertex v2 = new vertex(p2);
            vertex v3 = new vertex(p3);

            //Setup the three edges
            Edge e1 = new Edge(v1, v2);
            Edge e2 = new Edge(v2, v3);
            Edge e3 = new Edge(v3, v1);

            //Setup the one face
            Face f1 = new Face(e1, e2, e3, Color.Red);

            triangle.addFace(f1);

            return triangle;
        }
    }
}
