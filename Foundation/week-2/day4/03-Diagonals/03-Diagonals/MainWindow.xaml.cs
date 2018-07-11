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

namespace _03_Diagonals
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

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, canvas.Width, canvas.Height);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, canvas.Height, canvas.Width,0);
            //Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.
        }
    }
}
