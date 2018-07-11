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

namespace Triangles
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

            TrianglesInTriangles();

        }
        public void TrianglesInTriangles()
        {
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(canvas.Width / 2, 0, canvas.Width, canvas.Height / 2);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(canvas.Width, canvas.Height / 2, 0, canvas.Height / 2);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(0, canvas.Height / 2, canvas.Width / 2, 0);

            for (int i = 15; i < 300; i += 15)
            {
                foxDraw.StrokeColor(Colors.Black);
                foxDraw.DrawLine(canvas.Width / 2 - i, 0 + i, canvas.Width - i * 2, canvas.Height / 2);

                foxDraw.StrokeColor(Colors.Black);
                foxDraw.DrawLine(canvas.Width / 2 + i, 0 + i, 0 + i * 2, canvas.Height / 2);

                foxDraw.StrokeColor(Colors.Black);
                foxDraw.DrawLine(canvas.Width / 2 - i, 0 + i, canvas.Width / 2 + i, 0 + i);
            }
        }
    }
}
