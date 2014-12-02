using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsGraphics_uppgift_1
{
    public partial class Form1 : Form
    {
        string strFigure = "Ellipse";
        Point[] arrTriangle = new Point[] { new Point(120, 120), new Point(60, 170), new Point(180, 170) };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            strFigure = "Triangle";
            Invalidate();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            strFigure = "Ellipse";
            Invalidate();
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            strFigure = "Rectangle";
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Red);
            if (strFigure.Equals("Rectangle"))
            {
                g.FillRectangle(brush, 100, 100, 100, 100);
            }

            else if (strFigure.Equals("Ellipse"))
            {
                brush.Color = Color.Blue;
                g.FillEllipse(brush, 100, 100, 100, 100);
            }

            else if (strFigure.Equals("Triangle"))
            {
                brush.Color = Color.Purple;
                g.FillPolygon(brush, arrTriangle);
            }
        }

    }
}
