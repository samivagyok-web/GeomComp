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

namespace Hull
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Point> points;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Random rnd = new Random();

            int n = int.Parse(numOfPoints.Text);

            double h = canvas.ActualHeight;
            double w = canvas.ActualWidth;
            points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                double x = (double)rnd.Next(1, (int)w);
                double y = (double)rnd.Next(1, (int)h);
              
                points.Add(new Point(x, y));

                Ellipse el = new Ellipse();
                canvas.Children.Add(el);
                el.Width = 7;
                el.Height = 7;
                el.Fill = Brushes.Red;
                Canvas.SetLeft(el, x);
                Canvas.SetTop(el, y);

                
            }

            points = (List<Point>)ConvexHull.MakeHull(points);
       
            for (int i = 0; i < points.Count - 1; i++)
            {
                Line l = new Line();
                canvas.Children.Add(l);
       
                l.X1 = points[i].x;
                l.Y1 = points[i].y;
                l.X2 = points[i + 1].x;
                l.Y2 = points[i + 1].y;
       
                l.Stroke = Brushes.Black;
                l.StrokeThickness = 3;
            }
       
            Line l1 = new Line();
       
            canvas.Children.Add(l1);
       
            l1.X1 = points[0].x;
            l1.Y1 = points[0].y;
            l1.X2 = points[points.Count - 1].x;
            l1.Y2 = points[points.Count - 1].y;
       
            l1.Stroke = Brushes.Black;
            l1.StrokeThickness = 3;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            string[] lol = a.Text.Split(' ');

            points = new List<Point>();
            for (int i = 0; i < lol.Length / 2; i++)
            {
                int x = int.Parse(lol[i]);
                int y = int.Parse(lol[i+1]);

                Point p = new Point(x, y);

                points.Add(p);
            }

            for (int i = 0; i < points.Count; i++)
            {
                Ellipse el = new Ellipse();
                canvas.Children.Add(el);
                el.Width = 7;
                el.Height = 7;
                el.Fill = Brushes.Red;
                Canvas.SetLeft(el, (double)points[i].x);
                Canvas.SetTop(el, (double)points[i].y);
            }

            points = (List<Point>)ConvexHull.MakeHull(points);

            for (int i = 0; i < points.Count - 1; i++)
            {
                Line l = new Line();
                canvas.Children.Add(l);

                l.X1 = points[i].x;
                l.Y1 = points[i].y;
                l.X2 = points[i + 1].x;
                l.Y2 = points[i + 1].y;

                l.Stroke = Brushes.Black;
                l.StrokeThickness = 3;
            }

            Line l1 = new Line();

            canvas.Children.Add(l1);

            l1.X1 = points[0].x;
            l1.Y1 = points[0].y;
            l1.X2 = points[points.Count - 1].x;
            l1.Y2 = points[points.Count - 1].y;

            l1.Stroke = Brushes.Black;
            l1.StrokeThickness = 3;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            points.Clear();
        }
    }
}
