using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using ClassLibraryFigures;

namespace Figures
{
    public partial class MainWindow
    {
        static class Drawer
        {
            static public MainWindow window { get; set; }
            static public int Scale { get; set; }                                 
            
            static public void Draw(ClassLibraryFigures.Rectangle rectangle)
            {
                var figure = new System.Windows.Shapes.Rectangle();

                figure.Stroke = Brushes.Red;

                figure.Width = Math.Abs(rectangle.X1 - rectangle.X2);
                figure.Height = Math.Abs(rectangle.Y1 - rectangle.Y2);

                figure.StrokeThickness = 1 * Scale;

                var myThinkness = new Thickness();
                myThinkness.Left = rectangle.X1 < rectangle.X2 ? rectangle.X1 : rectangle.X2;
                myThinkness.Top = rectangle.Y1 < rectangle.Y2 ? rectangle.Y1 : rectangle.Y2;

                figure.Margin = myThinkness;

                window.can.Children.Add(figure);
            }

            static public void Draw(ClassLibraryFigures.Ellipse ellipse)
            {
                var figure = new System.Windows.Shapes.Ellipse();

                figure.Stroke = Brushes.LightSteelBlue;

                figure.Width = Math.Abs(ellipse.X1 - ellipse.X2);
                figure.Height = Math.Abs(ellipse.Y1 - ellipse.Y2);

                figure.StrokeThickness = 1 * Scale;

                var myThinkness = new Thickness();
                myThinkness.Left = ellipse.X1 < ellipse.X2 ? ellipse.X1 : ellipse.X2;
                myThinkness.Top = ellipse.Y1 < ellipse.Y2 ? ellipse.Y1 : ellipse.Y2;

                figure.Margin = myThinkness;

                window.can.Children.Add(figure);
            }

            static public void Draw(Triangle triangle)
            {
                var figure = new Polygon();

                figure.Stroke = Brushes.Green;

                var p1 = new Point(triangle.X1, triangle.Y1);
                var p2 = new Point(triangle.X2, triangle.Y2);
                var p3 = new Point(triangle.X3, triangle.Y3);

                var pointCollection = new PointCollection();

                pointCollection.Add(p1);
                pointCollection.Add(p2);
                pointCollection.Add(p3);

                figure.Points = pointCollection;

                figure.StrokeThickness = 1 * Scale;

                var myThinkness = new Thickness();
                myThinkness.Left = triangle.X1 < triangle.X2 ? triangle.X1 : triangle.X2;
                myThinkness.Top = triangle.Y1 < triangle.Y2 ? triangle.Y1 : triangle.Y2;

                figure.Margin = myThinkness;

                window.can.Children.Add(figure);
            }

            static public void Draw(ClassLibraryFigures.Line line)
            {
                var figure = new System.Windows.Shapes.Line();

                figure.Stroke = Brushes.Blue;                

                figure.X1 = line.X1;
                figure.X2 = line.X2;
                figure.Y1 = line.Y1;
                figure.Y2 = line.Y2;

                var pointCollection = new PointCollection();

                figure.StrokeThickness = 1 * Scale;

                var myThinkness = new Thickness();

                figure.Margin = myThinkness;

                window.can.Children.Add(figure);
            }
        }

    }

          
}
