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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Drawing;

namespace Figures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public List<System.Windows.Point> points = new List<System.Windows.Point>();

        public MainWindow()
        {
            InitializeComponent();

            Drawer.window = this;
            Drawer.Scale = 10;
        }

        private void can_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Point point = Mouse.GetPosition(can);
            points.Add(point);
        }        

        private void Button_Click_Ellipse(object sender, RoutedEventArgs e)
        {
            if (points.Count < 2)
                return;

            var ellipse = new ClassLibraryFigures.Ellipse(points[0].X, points[0].Y, points[1].X, points[1].Y);
            Drawer.Draw(ellipse);            

            points.Clear();
        }

        private void Button_Click_Rectangle(object sender, RoutedEventArgs e)
        {
            if (points.Count < 2)
                return;

            var rect = new ClassLibraryFigures.Rectangle(points[0].X, points[0].Y, points[1].X, points[1].Y);
            Drawer.Draw(rect);

            points.Clear();
        }

        private void Button_Click_Line(object sender, RoutedEventArgs e)
        {
            if (points.Count < 2)
                return;

            var line = new ClassLibraryFigures.Line(points[0].X, points[0].Y, points[1].X, points[1].Y);
            Drawer.Draw(line);

            points.Clear();
        }

        private void Button_Click_Triangle(object sender, RoutedEventArgs e)
        {
            if (points.Count != 3)
                return;

            var triangle = new ClassLibraryFigures.Triangle(points[0].X, points[0].Y,
                            points[1].X, points[1].Y,
                            points[2].X, points[2].Y);
            Drawer.Draw(triangle);

            points.Clear();
        }
    }          
}
