using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shapes
{
    internal class Square : Shapes
    {
       private int x;
        private int y;
        private int side;
        public static int shapeCounter = 0;
        private static String name = "Square";
        private Random rn = new Random();
        private int shapeNumber;
        public Square() {
            this.x = rn.Next(100, 800);
            this.y = rn.Next(100, 550);
            this.side = rn.Next(50, 100);
            shapeCounter++;
            this.shapeNumber = shapeCounter;


        }

        public void draw(Panel darwingPannel)
        {
            Graphics g= darwingPannel.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Red, 3);
            g.DrawRectangle(p, x, y, side, side);

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
            String squInfo = name + " " + shapeNumber + "(x= " + x + " ," + "y =" + y + ", " + "Side=" + " " + side + " " + ")";
            Graphics g = infoPannel.CreateGraphics();
            System.Drawing.Font font = new System.Drawing.Font("Arial", 16);
            Brush brush = Brushes.Black;
            g.DrawString(squInfo, font, brush, new PointF(0, Shapes.posCounterF2));
            Shapes.posCounterF2 = Shapes.posCounterF2 + 20;

        }

    }
}
