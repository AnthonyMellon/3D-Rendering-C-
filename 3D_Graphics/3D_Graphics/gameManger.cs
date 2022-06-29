using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3D_Graphics
{
    class gameManger
    {
        private Graphics gameGraphics;
        private int screenBottom;
        private int ScreenRight;
        private Drawer drawer;
        private Object myTriangle;
        public gameManger(Graphics gameGraphics, int screenBottom, int ScreenRight)
        {
            this.gameGraphics = gameGraphics;
            this.screenBottom = screenBottom;
            this.ScreenRight = ScreenRight;
        }
        public void setup()
        {
            drawer = new Drawer(gameGraphics);
            myTriangle = ObjectUtils.create2DTriangle(new Vector3f(200, 200, 0), new Vector3f(0, 0, 0), 100);
            
        }

        public void loop()
        {
            myTriangle.rotate(2, 1);
            drawer.drawObject(myTriangle);            
        }
    }
}
