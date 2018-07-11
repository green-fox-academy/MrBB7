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

namespace LinePlay
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

            int xfirst = 30;
            int yfirst = 5;
            int ysecond = 15;

            OpticalIllusion(xfirst, yfirst, ysecond);
        }
        public void OpticalIllusion(int xfirst, int yfirst, int ysecond)
        {
            var foxDraw = new FoxDraw(canvas);
            for (int i = 1; i < 600; i += 25)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(xfirst + i, yfirst, canvas.Width, ysecond + i);
            }
            for (int j = 1; j < 600; j += 25)
            {
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(canvas.Width - j, canvas.Height + ysecond, 0, canvas.Height - j);
            }
        }
    }
}
