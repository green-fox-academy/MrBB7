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

namespace _04_GoToCenter
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
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.
           
            Loop(60, 15);

        }
        public void Loop(int xfirst, int yfirst)
        {
            var foxDraw = new FoxDraw(canvas);
            for (int i = 0; i < 3; i++)
            {
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(i * xfirst, i * yfirst, canvas.Width / 2, canvas.Height / 2);
            }
        }
    }
}
