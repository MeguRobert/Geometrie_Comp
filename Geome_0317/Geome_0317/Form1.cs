using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geome_0317
{
   
    public partial class Form1 : Form
    {
        private static Random rnd = new Random();
        private static int border = 10;
        private static int width;
        private static int height;
        public Form1()
        {
            InitializeComponent();
            myGraphics.initGraph(pictureBox1);
            width = pictureBox1.Width;
            height = pictureBox1.Height;
        }

        private void MakeSquares(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Engine.squares.Add(new Square(i));
                Engine.drawSquares(myGraphics.gfx);
            }
            
        }

        

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            myGraphics.refreshGraph();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Engine.clear();
            Matematics.clear();
            myGraphics.clearGraph();
            myGraphics.refreshGraph();
        }

        private void btn_addPoint_Click(object sender, EventArgs e)
        {
            float X = float.Parse(textBox1.Text);
            float Y = float.Parse(textBox2.Text);
            Engine.points.Add(new Point(X, Y));
            Engine.drawPoints(myGraphics.gfx);
            myGraphics.refreshGraph();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            myGraphics.clearGraph();
            Engine.remove();
            Engine.draw(myGraphics.gfx);
            myGraphics.refreshGraph();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Engine.drawLines(myGraphics.gfx);
            myGraphics.refreshGraph();
        }

        private void btn_draw_squares_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            MakeSquares(n);
            myGraphics.refreshGraph();
        }



        private void draw_polygon_Click(object sender, EventArgs e)
        {
            if (Engine.points.Count != 0) return;
            int n = int.Parse(textBox1.Text);
            for (int i = 0; i < n; i++)
            {
                float x = rnd.Next(border , width - border);
                float y = rnd.Next(border , height - border);

                Engine.points.Add(new Point(x,y));
            }
            Engine.drawPolygon(myGraphics.gfx);

            myGraphics.refreshGraph();
        }

    }
}
