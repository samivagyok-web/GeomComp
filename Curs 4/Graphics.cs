using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Curs_4
{
    public static class myGraphics 
    {
        //GDI / GDI+
        public static Bitmap bmp;
        public static Graphics grp;
        public static PictureBox display;
        public static int resx, resy;
        public static Color backColor = Color.AliceBlue;

        public static void initGraph(PictureBox Display) 
        {
            display = Display;
            bmp = new Bitmap(display.Width, display.Height);
            grp = Graphics.FromImage(bmp);
            resx = display.Width;
            resy = display.Height;
            clearGraph();
        }

        public static void clearGraph()
        {
            grp.Clear(backColor);
        }
        public static void refreshGraph()
        {
            display.Image = bmp;
        }

        public static void mediane()
        {
            grp.DrawLine(Pens.Black, 250, 200, 100, 200);
            grp.DrawLine(Pens.Black, 200, 300, 200, 150);
            grp.DrawLine(Pens.Black, 300, 100, 150, 250);
        }
        //transformari de puncte pt zoom;
    }
}
