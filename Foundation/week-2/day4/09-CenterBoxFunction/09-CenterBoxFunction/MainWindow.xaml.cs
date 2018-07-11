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

namespace _09_CenterBoxFunction
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
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.
            SquareDrawerCenter(30);
        }
        public void SquareDrawerCenter(int size)
        {
            var foxDraw = new FoxDraw(canvas);
            int half = size / 2;
            for (int i = 1; i < 4; i++)
            {
                foxDraw.StrokeColor(Colors.Crimson);
                foxDraw.DrawLine(canvas.Width / 2 - half, canvas.Height / 2 - half, canvas.Width / 2 + half, canvas.Height / 2 - half);
                foxDraw.StrokeColor(Colors.Crimson);
                foxDraw.DrawLine(canvas.Width / 2 + half, canvas.Height / 2 - half, canvas.Width / 2 + half, canvas.Height / 2 + half);
                foxDraw.StrokeColor(Colors.Crimson);
                foxDraw.DrawLine(canvas.Width / 2 + half, canvas.Height / 2 + half, canvas.Width / 2 - half, canvas.Height / 2 + half);
                foxDraw.StrokeColor(Colors.Crimson);
                foxDraw.DrawLine(canvas.Width / 2 - half, canvas.Height / 2 - half, canvas.Width / 2 - half, canvas.Height / 2 + half);
                half += 15;
            }



        }
    }
}
