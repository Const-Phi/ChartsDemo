using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ChartsDemos
{
    public abstract class BaseChart : Canvas
    {
        public DataProvider Provider { get; protected set; }
    }
}
