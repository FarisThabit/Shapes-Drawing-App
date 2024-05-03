using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace Shapes
{
    internal class Rectangle : Shapes
    {
        private int x;
        private int y;
        private int height;
        private int width;
        private static string name = "Rectangle";
        private Random rn = new Random();
        public static int shapeCounter = 0;
        private int shapeNumber;
        public Rectangle()
        {
            this.x = rn.Next(100, 800);
            this.y = rn.Next(100, 550);
            this.height = rn.Next(50, 100);
            this.width = rn.Next(50, 100);
            shapeCounter++;
            this.shapeNumber = shapeCounter;
        }
        public void Draw(Panel drawingPannel) {
            Graphics g = drawingPannel.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Red, 3);
            g.DrawRectangle(p,x,y,width,height);
        }
        public void shapeName(Panel shapeInfoPannel)
        {
            Graphics g = shapeInfoPannel.CreateGraphics();
            System.Drawing.Font font = new System.Drawing.Font("Arial", 16);
            Brush brush = Brushes.Black;
            g.DrawString(name + " " + shapeNumber, font, brush, new PointF(0, Shapes.posCounter));
            Shapes.posCounter = Shapes.posCounter + 20;


        }
        public override void shapeInfo(Panel infoPannel)
        {
            String recInfo = name + " " + shapeNumber + "(x= " + x + " ," + "y =" + y + ", " + "width =" + " " + width
                + ", " + "height = " + height + ")";
            Graphics g = infoPannel.CreateGraphics();
            System.Drawing.Font font = new System.Drawing.Font("Arial", 16);
            Brush brush = Brushes.Black;
            g.DrawString(recInfo, font, brush, new PointF(0, Shapes.posCounterF2));
            Shapes.posCounterF2 = Shapes.posCounterF2 + 20;

        }
    }
}
