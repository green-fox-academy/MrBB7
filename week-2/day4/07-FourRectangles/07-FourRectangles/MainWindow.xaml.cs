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

namespace _07_FourRectangles
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
            // draw four different size and color rectangles.
            // avoid code duplication.
            RectangleDrawer();

        }
        public void RectangleDrawer()
        {
            var foxDraw = new FoxDraw(canvas);

            foxDraw.FillColor(Colors.HotPink);
            foxDraw.DrawRectangle(10, 10, 150, 50);

            foxDraw.FillColor(Colors.DarkGoldenrod);
            foxDraw.DrawRectangle(100, 90, 170, 30);

            foxDraw.FillColor(Colors.DarkOliveGreen);
            foxDraw.DrawRectangle(400, 70, 50, 40);

            foxDraw.FillColor(Colors.DarkOrchid);
            foxDraw.DrawRectangle(70, 300, 550, 90);
        }
    }
}
