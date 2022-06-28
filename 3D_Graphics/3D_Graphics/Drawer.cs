using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3D_Graphics
{
    class Drawer
    {
        private Graphics graphics;
        public Drawer(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public void drawObject(Object myObject)
        {
            //Go throgh each face
            foreach(Face face in myObject.getFaces())
            {
                //used to store the (x, y) coordintes of each vertex
                PointF[] vertices = new PointF[3];

                //Get the edges that make up this face
                Edge[] edges = face.GetEdges();

                //Get the first point of each edge and store it in the 2d vertices to be drawn
                for(int i = 0; i < edges.Length; i++)
                {
                    Vector3f point3D = edges[i].getPoints()[0].getPosition();
                    vertices[i].X = point3D.X;
                    vertices[i].Y = point3D.Y;
                }

                //Draw the face
                graphics.FillPolygon(new SolidBrush(face.color), vertices);
            }
        }
    }
}
