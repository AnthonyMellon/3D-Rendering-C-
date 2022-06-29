using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Graphics
{
    static class extraMath
    {
        public static float DegToRad(float deg)
        {
            return (float)(deg * Math.PI / 180);
        }

        public static float RadTodDeg(float rad)
        {
            return (float)(rad * 180 / Math.PI);
        }
    }
}
