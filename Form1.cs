using System.Collections;
using System.Security.Cryptography;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public static List<Shapes> shapesList = new List<Shapes>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Drawing_Pannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rectangle_Butt_Click(object sender, EventArgs e)
        {
            Rectangle r1 = new Rectangle();
            shapesList.Add(r1);
            r1.Draw(Drawing_Pannel);
            r1.shapeName(ShapesInfo_Pannel);

        }

        private void Square_Butt_Click(object sender, EventArgs e)
        {
            Square s1 = new Square();
            shapesList.Add(s1);
            s1.draw(Drawing_Pannel);
            s1.shapeName(ShapesInfo_Pannel);
        }

        private void Circle_Butt_Click(object sender, EventArgs e)
        {
            Circle c1 = new Circle();
            shapesList.Add(c1);
            c1.draw(Drawing_Pannel);
            c1.shapeName(ShapesInfo_Pannel);
        }

        private void ShapesInfo_Pannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tringle_Click(object sender, EventArgs e)
        {
            Tringlee t1 = new Tringlee();
            shapesList.Add(t1);
            t1.draw(Drawing_Pannel);
            t1.shapeName(ShapesInfo_Pannel);
        }

        private void Line_Butt_Click(object sender, EventArgs e)
        {
            Line l1 = new Line();
            shapesList.Add(l1);
            l1.draw(Drawing_Pannel);
            l1.shapeName(ShapesInfo_Pannel);

        }

        private void InfoMode_Butt_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Shapes.posCounter = 0;
            Rectangle.shapeCounter = 0;
            Tringlee.shapeCounter = 0;
            Square.shapeCounter = 0;
            Circle.shapeCounter = 0;
            Line.shapeCounter = 0;
            shapesList.Clear();
            Drawing_Pannel.Refresh();
            ShapesInfo_Pannel.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
