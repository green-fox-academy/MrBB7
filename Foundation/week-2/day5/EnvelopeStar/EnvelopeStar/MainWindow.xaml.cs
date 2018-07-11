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

namespace EnvelopeStar
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

            StarDrawer();
           
        }
        public void StarDrawer()
        {
        var foxDraw = new FoxDraw(canvas);

            for (int i = 15; i < 300; i += 15)
            {
                foxDraw.StrokeColor(Colors.Green);      
                foxDraw.DrawLine(canvas.Width / 2, (canvas.Height / 2) + i, canvas.Width - i, canvas.Height / 2);

                foxDraw.StrokeColor(Colors.Green);    
                foxDraw.DrawLine(0 + i, canvas.Height / 2, canvas.Width / 2, canvas.Height / 2 + i);

                foxDraw.StrokeColor(Colors.Green);   
                foxDraw.DrawLine(canvas.Width - i, canvas.Height / 2, canvas.Width / 2, canvas.Height / 2 - i);

                foxDraw.StrokeColor(Colors.Green);  
                foxDraw.DrawLine(0 + i, canvas.Height / 2, canvas.Width / 2, canvas.Height / 2 - i);
            }
        }
    }
}
