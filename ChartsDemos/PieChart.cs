using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChartsDemos
{
    public class PieChart : BaseChart
    {
        public PieChart()
        {
            Provider = new DataProvider(1, 2, 3);
        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);


            var center = new Point(ActualWidth / 2, ActualHeight / 2);
            var radius = Math.Min(ActualWidth, ActualHeight) * 0.4;

            var startAngle = 0.0;
            foreach (var value in Provider.GetDataAsPercent())
            {
                var angle = 2 * Math.PI * value;
                var startPoint = PointByValue(center, radius, startAngle);
                var targetPoint = PointByValue(center, radius, startAngle - angle);
    
                var figure = new PathFigure
                {
                    IsClosed = true,
                    StartPoint = center
                };
                figure.Segments.Add(new LineSegment(startPoint, true));
                figure.Segments.Add(new ArcSegment(targetPoint, new Size(radius, radius), angle, angle > Math.PI, SweepDirection.Counterclockwise, true));

                var geometry = new PathGeometry();
                geometry.Figures.Add(figure);

                dc.DrawGeometry(Brushes.Coral, new Pen(Brushes.Black, 2.0), geometry);

                startAngle -= angle;
            }


            //dc.DrawEllipse(Brushes.Tomato, new Pen(Brushes.Black, 1.0), center, radius-50, radius);
            //dc.DrawEllipse(Brushes.Tomato, new Pen(Brushes.Black, 1.0), center, radius - 100, radius );
            //dc.DrawEllipse(Brushes.Tomato, new Pen(Brushes.Black, 1.0), center, radius - 150, radius );
        }

        private static Point PointByValue(Point center, double radius, double angle)
        { 
            var x = center.X + radius * Math.Cos(angle);
            var y = center.Y + radius * Math.Sin(angle);
            return new Point(x, y);
        }
    }
}
