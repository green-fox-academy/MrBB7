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

namespace _10_RainbowBoxFunction
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
            // Create a square drawing function that takes 2 parameters:
            // The square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares,
            // all squares should be centered, but growing in size
            RainbowCreator(15, 255);
        }
    }
    public void RainbowCreator(int size, Color layer)
    {
        var foxDraw = new FoxDraw(canvas);
        int half = size / 2;
        for (int i = 1; i < 8; i++)
        {
            foxDraw.StrokeColor(Colors.White);
            foxDraw.DrawLine(canvas.Width / 2 - half, canvas.Height / 2 - half, canvas.Width / 2 + half, canvas.Height / 2 - half);
            foxDraw.StrokeColor(Colors.White);
            foxDraw.DrawLine(canvas.Width / 2 + half, canvas.Height / 2 - half, canvas.Width / 2 + half, canvas.Height / 2 + half);
            foxDraw.StrokeColor(Colors.White);
            foxDraw.DrawLine(canvas.Width / 2 + half, canvas.Height / 2 + half, canvas.Width / 2 - half, canvas.Height / 2 + half);
            foxDraw.StrokeColor(Colors.White);
            foxDraw.DrawLine(canvas.Width / 2 - half, canvas.Height / 2 - half, canvas.Width / 2 - half, canvas.Height / 2 + half);
            half += 15;

        }
    }
}
