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
            DrawSquare(100, Colors.Red);
            DrawSquare(60, Colors.Blue);
            DrawSquare(30, Colors.Magenta);
            DrawSquare(10, Colors.Maroon);
        }
        public void DrawSquare(int squareSize, Color squareColor)
        {
            var foxDraw = new FoxDraw(canvas);
            Random r = new Random();

            double middleX = canvas.Width / 2;
            double middleY = canvas.Height / 2;

            Color[] colorSet = { Color.FromRgb(Blu, Color.Blue, Color.Green, Color.Yellow , Color.};

            for (int i = 1; i < 8; i++)
                {
                    for (int j = 0; j < colorSet.Length; j++)
                    {                    
                    colorSet[j] = colorSet[i];
                    }
                    foxDraw.DrawRectangle(middleX - (squareSize / 2), middleY - (squareSize / 2), squareSize, squareSize);
                    foxDraw.FillColor(Colors.);
                }
            }
        }
}
