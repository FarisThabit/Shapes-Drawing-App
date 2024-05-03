using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Tringlee : Shapes
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private int x3;
        private int y3;
        private static string name = "Tringle";
        public static int shapeCounter = 0;
        private Point[] points = new Point[3];
        private Random rn = new Random();
        private int width;
        private int height;
        private int shapeNumber;
        public Tringlee() {
            this.x1 = rn.Next(100, 800);
            this.y1 = rn.Next(100, 550);
            this.x2 = x1 + rn.Next(100, 150);
            this.y2 = y1;
            this.x3 = (x1 + x2) / 2;
            this.y3 = (y1 - rn.Next(100, 150));
            this.points[0] = new Point(this.x3,this.y3);
            this.points[1] = new Point(this.x1,this.y1);
            this.points[2] = new Point(this.x2, this.y2);
            this.width = x3-x1;
            this.height = y2 - y1;
            shapeCounter++;
            this.shapeNumber = shapeCounter;
        }
        public void draw( Panel drawingPannel)
        {
            Graphics g = drawingPannel.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Red, 4);
            g.DrawPolygon(p,points);


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
            String triinfo = name + " " + shapeNumber + "(x= " + x1 + " ," + "y =" + y1 + ", " + "width =" + " " + width
                + ", " + "height = " + height + ")";
            Graphics g = infoPannel.CreateGraphics();
            System.Drawing.Font font = new System.Drawing.Font("Arial", 16);
            Brush brush = Brushes.Black;
            g.DrawString(triinfo, font, brush, new PointF(0, Shapes.posCounterF2));
            Shapes.posCounterF2 = Shapes.posCounterF2 + 20;

        }
    }
}
