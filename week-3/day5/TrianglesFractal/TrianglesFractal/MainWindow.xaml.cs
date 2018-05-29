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
using WPFExample;

namespace TrianglesFractal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FoxDraw foxDraw;
        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);

            DrawTriangle(15, new Point(400,0), new Point(0,800), new Point(800,0));

        }

        public void DrawTriangle(int level, new Point topPoint, new Point leftPoint,new Point rightPoint)
        {
            if (level == 0)
            {
                List<Point> points = { topPoint, leftPoint, rightPoint };
                foxDraw.FillColor(Colors.Purple);
            }
            else
            {
                List<Point> leftMid = new List<Point>();
                leftMid.Add(new Point((topPoint + leftPoint) / 2, (topPoint + leftPoint) / 2));
                List<Point> rightMid = new List<Point>();
                 rightMid.Add(new Point(topPoint + rightPoint) / 2, (topPoint + rightPoint) / 2));
                List<Point> bottomMid = new List<Point>();
                bottomMid.Add(new Point(leftPoint + rightPoint) / 2, (leftPoint + rightPoint) / 2));

                List<Point> endPoints = new List<Point>();
                endPoints.Add(new Point((topPoint + leftPoint) / 2, (topPoint + leftPoint) / 2));
                endPoints.Add(new Point(topPoint + rightPoint) / 2, (topPoint + rightPoint) / 2));
                endPoints.Add(new Point(leftPoint + rightPoint) / 2, (leftPoint + rightPoint) / 2));

                foxDraw.DrawPolygon(endPoints);


                DrawTriangle(level - 1, topPoint, leftMid, rightMid);
                DrawTriangle(level - 1, leftMid, leftPoint, bottomMid);
                DrawTriangle(level - 1, rightMid, bottomMid, rightPoint);
            }         
        }
    }   
}
