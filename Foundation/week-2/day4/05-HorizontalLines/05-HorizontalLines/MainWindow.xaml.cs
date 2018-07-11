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

namespace _05_HorizontalLines
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
            LineDrawer(40, 80);
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // Draw 3 lines with that function. Use loop for that.
        }
        public void LineDrawer(int xfirst, int yfirst)
        {
            var foxDraw = new FoxDraw(canvas);

            for (int i = 1; i < 4; i++)
            {
                foxDraw.StrokeColor(Colors.DarkOrange);
                xfirst *= i;
                yfirst *= i;
                foxDraw.DrawLine(xfirst, yfirst, xfirst+50, yfirst);
            }
        }
    }
}
