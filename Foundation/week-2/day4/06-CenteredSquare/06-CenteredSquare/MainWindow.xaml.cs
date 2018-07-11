﻿using System;
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

namespace _06_CenteredSquare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw a green 10x10 square to the canvas' center.

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Width/2-5, canvas.Height/2-5, canvas.Width/2+5, canvas.Height/2-5);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Width / 2 + 5, canvas.Height / 2 - 5, canvas.Width / 2 + 5, canvas.Height / 2 +5);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Width / 2 + 5, canvas.Height / 2 + 5, canvas.Width / 2 - 5, canvas.Height / 2 + 5);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Width / 2 - 5, canvas.Height / 2 - 5, canvas.Width / 2 - 5, canvas.Height / 2 + 5);

        }
    }
}
