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

namespace _11_FirstFractal
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

                int xfirst = 0;
                int yfirst = 0;
            int divider = 3; 

            if (xfirst == 3 && yfirst == 3)
            {
                break;
            }
            else
            {
                return 
            }

                foxDraw.FillColor(Colors.Yellow);
                foxDraw.DrawRectangle(xfirst+=divider, yfirst+=divider, canvas.Width, canvas.Height);
            }
            

        }
    }
}
