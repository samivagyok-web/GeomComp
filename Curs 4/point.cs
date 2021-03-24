using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Curs_4
{
    public class myPoint
    {
        public static int size = 4; 
        public float X, Y;
        public Color fillColor;
        public Color drawColor;
        public string nume;

        public myPoint(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
            this.fillColor = Color.Red;
            this.drawColor = Color.Black;
        }

        public myPoint(float X, float Y, Color fillColor, Color drawColor)
        {
            this.X = X;
            this.Y = Y;
            this.fillColor = fillColor;
            this.drawColor = drawColor;
        }

        public void draw (Graphics grp)
        {
            Pen p = new Pen(drawColor);
            SolidBrush sb = new SolidBrush(fillColor);
            grp.FillEllipse(sb, X - size, Y - size, size * 2 + 1, size * 2 + 1);
            grp.DrawEllipse(p, X - size, Y - size, size * 2 + 1, size * 2 + 1);
            grp.DrawString(nume, new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Black), new PointF(X, Y));
        }
    }
}
