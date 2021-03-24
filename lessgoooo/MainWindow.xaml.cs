using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lessgoooo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            Canv.Children.Clear();

            Line line1 = new Line();
            Line line2 = new Line();
            Line line3 = new Line();

            Canv.Children.Add(line1);
            Canv.Children.Add(line2);
            Canv.Children.Add(line3);

            line1.X1 = double.Parse(x1.Text);
            line1.Y1 = double.Parse(y1.Text);
            line1.X2 = double.Parse(x2.Text);
            line1.Y2 = double.Parse(y2.Text);

            line1.Stroke = Brushes.Black;
            line1.StrokeThickness = 4;

            line2.X1 = double.Parse(x2.Text);
            line2.Y1 = double.Parse(y2.Text);
            line2.X2 = double.Parse(x3.Text);
            line2.Y2 = double.Parse(y3.Text);

            line2.Stroke = Brushes.Black;
            line2.StrokeThickness = 4;

            line3.X1 = double.Parse(x1.Text);
            line3.Y1 = double.Parse(y1.Text);
            line3.X2 = double.Parse(x3.Text);
            line3.Y2 = double.Parse(y3.Text);

            line3.Stroke = Brushes.Black;
            line3.StrokeThickness = 4;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Canv.Children.Clear();
        }

        private void Median_Click(object sender, RoutedEventArgs e)
        {
            Point p1 = new Point((double.Parse(x1.Text) + double.Parse(x2.Text)) / 2, (double.Parse(y1.Text) + double.Parse(y2.Text)) / 2);
            Point p2 = new Point((double.Parse(x2.Text) + double.Parse(x3.Text)) / 2, (double.Parse(y2.Text) + double.Parse(y3.Text)) / 2);
            Point p3 = new Point((double.Parse(x1.Text) + double.Parse(x3.Text)) / 2, (double.Parse(y1.Text) + double.Parse(y3.Text)) / 2);

            drawMedians(p1);
            drawMedians(p2);
            drawMedians(p3);
        }

        private void drawMedians(Point p1)
        {
            Line m1 = new Line();
            Line m2 = new Line();
            Line m3 = new Line();

            Canv.Children.Add(m1);
            Canv.Children.Add(m2);
            Canv.Children.Add(m3);

            m1.X1 = p1.X;
            m1.Y1 = p1.Y;

            m1.X2 = double.Parse(x1.Text);
            m1.Y2 = double.Parse(y1.Text);

            m1.Stroke = Brushes.Black;
            m1.StrokeThickness = 3;

            m2.X1 = p1.X;
            m2.Y1 = p1.Y;

            m2.X2 = double.Parse(x2.Text);
            m2.Y2 = double.Parse(y2.Text);

            m2.Stroke = Brushes.Black;
            m2.StrokeThickness = 3;

            m3.X1 = p1.X;
            m3.Y1 = p1.Y;

            m3.X2 = double.Parse(x3.Text);
            m3.Y2 = double.Parse(y3.Text);

            m3.Stroke = Brushes.Black;
            m3.StrokeThickness = 3;
        }
    }
}
