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

namespace Rect
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
            canvas.Children.Clear();

            Rectangle rec = new Rectangle();
            canvas.Children.Add(rec);

            rec.Height = double.Parse(Hgt.Text);
            rec.Width = double.Parse(Wdt.Text);
            rec.Stroke = Brushes.Black;
            rec.StrokeThickness = 3;

            Canvas.SetTop(rec, double.Parse(Hgt.Text));
            Canvas.SetLeft(rec, double.Parse(Wdt.Text));

            drawAtlo(rec, double.Parse(Hgt.Text), double.Parse(Wdt.Text), rec.Height, rec.Width);
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Random rnd = new Random();
            double h = canvas.ActualHeight;
            double w = canvas.ActualWidth;

            for (int i = 0; i < 8; i++)
            {
                Rectangle rec = new Rectangle();
                canvas.Children.Add(rec);

                rec.Height = rnd.Next(80, 200);
                rec.Width = rnd.Next(70, 200);
                rec.Stroke = Brushes.Black;
                rec.StrokeThickness = 3;

                double top = rnd.Next(0, (int)h);
                double left = rnd.Next(0, (int)w);

                Canvas.SetTop(rec, top);
                Canvas.SetLeft(rec, left);

                drawAtlo(rec, top, left, rec.Height, rec.Width);
            }
        }

        private void drawAtlo(Rectangle rec, double top, double left, double h, double w)
        {
            Line l1 = new Line();
            Line l2 = new Line();
            canvas.Children.Add(l1);
            canvas.Children.Add(l2);

            l1.X1 = left;
            l1.Y1 = top;
            l1.X2 = left + w;
            l1.Y2 = top + h;

            l1.Stroke = Brushes.Red;
            l1.StrokeThickness = 2;

            l2.X1 = left + w;
            l2.Y1 = top;
            l2.X2 = left;
            l2.Y2 = top + h;

            l2.Stroke = Brushes.Red;
            l2.StrokeThickness = 2;
        }
        
    }
}
