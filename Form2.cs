using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form2 : Form
    {
        private bool clear = false;
        public Form2()
        {

            InitializeComponent();
            Shapes.posCounterF2 = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
      

        private void Refresh_Butt_Click(object sender, EventArgs e)
        {
            clear = true;
            InfoPannel.Refresh();
            Shapes.posCounterF2 = 0;
            for (int i = 0; i < Form1.shapesList.Count; i++)
                {
                    Form1.shapesList[i].shapeInfo(InfoPannel);

                }
            }
            
        

        private void InfoPannel_Paint(object sender, PaintEventArgs e)
        {
            if (!clear)
            {
                for (int i = 0; i < Form1.shapesList.Count; i++)
                {
                    Form1.shapesList[i].shapeInfo(InfoPannel);

                }
            }
            else {
            
            }
         
        }
    }
}
