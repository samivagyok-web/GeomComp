using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_4
{
    public partial class Form1 : Form
    {
        public static Bitmap bmp;
        public static Graphics grp;
        public static PictureBox display;
        public static int resx, resy;
        public static Color backColor = Color.AliceBlue;

        public Form1()
        {
            InitializeComponent();
            myGraphics.initGraph(pictureBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // CLEAR
        {
            myGraphics.clearGraph();
            myGraphics.refreshGraph();
        }

        private void button4_Click(object sender, EventArgs e) // REFRESH
        {
            myGraphics.refreshGraph();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float X = float.Parse(textBox1.Text);
            float Y = float.Parse(textBox2.Text);
            Engine.points.Add(new myPoint(X, Y));
            Engine.draw(myGraphics.grp);
            myGraphics.refreshGraph();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grp.DrawLine(new Pen(Color.Red, 2), 250, 200, 100, 200);
            grp.DrawLine(new Pen(Color.Red, 2), 200, 300, 200, 150);
            grp.DrawLine(new Pen(Color.Red, 2), 300, 100, 150, 250);
        }
    }
}
