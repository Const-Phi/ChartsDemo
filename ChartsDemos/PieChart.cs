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
        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);

            var center = new Point(ActualWidth / 2, ActualHeight /2);
            var radius = Math.Min(ActualWidth, ActualHeight) * 0.4;

            dc.DrawEllipse(Brushes.Tomato, new Pen(Brushes.Black, 1.0), center, radius, radius);
        }
    }
}
