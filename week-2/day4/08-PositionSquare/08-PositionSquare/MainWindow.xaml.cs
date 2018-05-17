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

namespace _08_PositionSquare
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
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.  
            SquareDrawer(50,50);
        }
        public void SquareDrawer(double xfirst, double yfirst)
        {
            for (int i = 1; i < 4; i++)
            {
                var foxDraw = new FoxDraw(canvas);
                foxDraw.FillColor(Colors.Brown);
                foxDraw.DrawLine(xfirst*i, yfirst*i, xfirst*i + 50, yfirst*i);
                foxDraw.DrawLine(xfirst * i + 50, yfirst * i, xfirst * i + 50, yfirst * i + 50);
                foxDraw.DrawLine(xfirst * i + 50, yfirst * i + 50, xfirst * i, yfirst * i + 50);
                foxDraw.DrawLine(xfirst * i, yfirst * i + 50, xfirst * i, yfirst * i);
            }
            
        }
    }
}
