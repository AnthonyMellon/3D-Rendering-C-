using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_Graphics
{
    public partial class Form1 : Form
    {
        private Graphics game_dispGraphics;
        private Graphics game_bufferGraphics;
        private Bitmap game_bufferBitmap;
        public Form1()
        {
            InitializeComponent();

            //Create the graphics object used to draw all game elements to
            game_dispGraphics = gamePanel.CreateGraphics();

            //Setup the buffers
            game_bufferBitmap = new Bitmap(gamePanel.Width, gamePanel.Height);
            game_bufferGraphics = Graphics.FromImage(game_bufferBitmap);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game_bufferGraphics.Clear(Color.Black);

            //Run the game

            game_dispGraphics.DrawImage(game_bufferBitmap, 0, 0);
        }
    }
}
