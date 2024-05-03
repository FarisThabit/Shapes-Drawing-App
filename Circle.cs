using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shapes
    {
        private int x;
        private int y;
        private int radius;
        private static String name = "Circle";
        public static int shapeCounter = 0;
        private Random rn = new Random();
        private int shapeNumber;


        public Circle() {
            this.x = rn.Next(100, 800);
            this.y = rn.Next(100, 550);
            this.radius = rn.Next(100, 150);
            shapeCounter++;
            this.shapeNumber = shapeCounter;
        }

        public void draw(Panel drawingPannel) {
            Graphics g = drawingPannel.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Red, 3);
            g.DrawEllipse(p, x, y, radius, radius);


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
            String cirInfo = name + " " + shapeNumber + "(x= " + x + " ," + "y =" + y + ", " + "Radius=" + " " + radius + " " + ")";
            Graphics g = infoPannel.CreateGraphics();
            System.Drawing.Font font = new System.Drawing.Font("Arial", 16);
            Brush brush = Brushes.Black;
            g.DrawString(cirInfo, font, brush, new PointF(0, Shapes.posCounterF2));
            Shapes.posCounterF2 = Shapes.posCounterF2 + 20;

        }
    }
  
    

    
}
