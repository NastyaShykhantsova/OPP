using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using CircleSpace;
using EllipseSpace;
using LineSpace;
using PoligonSpace;
using RectangleSpace;
using ShapeSpace;
using SquareSpace;


namespace lab_rab_1
{
    public partial class fMain : Form
    {
        
        public PictureBox pb;
        
        public Shape fig;
        public int thickness = 2; //толщина
        public bool drLine, drRect, drCir, drEll, drSqu, drPol, drPolProc, drPolEnd, press;
        public Button curb;
        
        public Point pos1, pos2;
        public Color curColor;
        public List<Point> ps;
        MyImage myIm = new MyImage();
        public fMain()
        {

        }



        private void bLine_Click(object sender, EventArgs e)
        {

        }

        private void bRectangle_Click(object sender, EventArgs e)
        {

        }

        private void bEllipse_Click(object sender, EventArgs e)
        {
 
        }

        private void bTriangle_Click(object sender, EventArgs e)
        {

        }

        private void bSquare_Click(object sender, EventArgs e)
        {
          
        }

        private void bCircle_Click(object sender, EventArgs e)
        {

        }

        private void pbHolst_MouseUp(object sender, MouseEventArgs e)
        {

        }


        private void cbThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void pbHolst_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void pbHolst_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void bColor_Click(object sender, EventArgs e)
        {

        }

        private void bClear_Click(object sender, EventArgs e)
        {

        }
       
    }
    [Serializable]
    public class MyImage
    {

    }
}