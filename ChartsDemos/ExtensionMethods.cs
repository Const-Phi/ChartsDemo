using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ChartsDemos.Staff
{
    public static class ExtensionMethods
    {
        public static void AddRange(this UIElementCollection collection,
            IEnumerable<UIElement> elements)
        {
            foreach (var element in elements)
                collection.Add(element);
        }

        public static void AddRange(this UIElementCollection collection,
    IEnumerable<UIElement> elements, Action<UIElement> action)
        {
            foreach (var element in elements)
            {
                action(element);
                collection.Add(element);
            }
        }
    }
}
