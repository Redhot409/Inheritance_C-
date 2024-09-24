//#define CHECK_1
//#define CHECK_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
    internal class Program
    {
        static void Main(string[] args) 
        {
#if true
#if CHECK_1

            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
            (
            Console.WindowLeft, Console.WindowTop,
            Console.WindowWidth, Console.WindowHeight
            );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
            Rectangle rectangle = new Rectangle(80, 50, 300, 50, 2, Color.AliceBlue);
            rectangle.Info(e);

            Square square = new Square(75, 500, 50, 3, Color.Red);
            square.Info(e);
            Circle circle = new Circle(80, 800, 50, 1, Color.Yellow);
            circle.Info(e);  
#endif
#endif
        }
#if CHECK_2
        Shape[] shapes = new Shape[] 
        {
            new Rectangle(80,50,400,60,2, Color.AliceBlue),
            new Square(75,500,50,3, Color.AliceBlue),
            new Circle(800,700,50,1, Color.AliceBlue),
        };
        for(int i=0;i<shape.Length,i++)
        {
           //if(shapes[i] is IHaveDiagonal)
           //shapes[i].Info(e);
           //if(shapes[i] is IHaveDiameter)
           //shapes[i].Info(e);
        }


#endif

        [DllImport("kernel32.dll")]
    public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

    }
    
}
