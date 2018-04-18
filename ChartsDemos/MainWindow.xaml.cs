using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ChartsDemos.Staff;

namespace ChartsDemos
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //var i = 0;
            //var side = 3;
            //MainGrid.Children.AddRange(
            //    Generate<Button>(10),
            //    x =>
            //    {
            //        Grid.SetRow(x, i / side);
            //        Grid.SetColumn(x, i % side);
            //        ++i;
            //    });

            //Int32 i = 0;
            //Int32 side = 3;
            //IEnumerable<Button> buttons = Generate<Button>(10);
            //foreach (Button button in buttons)
            //{
            //    Grid.SetRow(button, i / side);
            //    Grid.SetColumn(button, i % side);
            //    ++i;
            //    MainGrid.Children.Add(button);
            //}

        }


        private static IEnumerable<T> Generate<T>(Int32 count)
            where T : UIElement, new() =>
            Enumerable.Range(1, count).Select(x => new T());
    }
}
