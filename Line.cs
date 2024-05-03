using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Line : Shapes
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private Point[] points = new Point[2];
        private static string name = "line";
        public static int shapeCounter = 0;
        private int length;
        private Random rn = new Random();
        private int shapeNumber;
        public Line()
        {
            this.x1 = rn.Next(100, 800);
            this.y1 = rn.Next(100, 550);
            this.x2 = x1 + rn.Next(100, 150);
            this.y2 = y1 + rn.Next(100, 150);
            points[0] = new Point(x1, y1);
            points[1] = new Point(x2, y2);
            this.length = y2 - y1;
            shapeCounter++;
            this.shapeNumber = shapeCounter;
        }
        public void draw(Panel drawPannel)
        {

            Graphics g = drawPannel.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Red, 3);
            g.DrawLine(p, points[0], points[1]);

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
            String lineInfo = name + " " + shapeNumber + "(x= " + x1 + " ," + "y =" + y1 + ", " + "length =" + " " + length + " " + ")";
            Graphics g = infoPannel.CreateGraphics();
            System.Drawing.Font font = new System.Drawing.Font("Arial", 16);
            Brush brush = Brushes.Black;
            g.DrawString(lineInfo, font, brush, new PointF(0, Shapes.posCounterF2));
            Shapes.posCounterF2 = Shapes.posCounterF2 + 20;
            

        }

    }
}
