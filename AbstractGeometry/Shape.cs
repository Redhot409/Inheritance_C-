
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace AbstractGeometry
{
    abstract class Shape
    {
       
        
        public static readonly int MIN_START_X = 150;
        public static readonly int MAX_START_X = 80;
        public static readonly int MIN_START_Y = 100;
        public static readonly int MAX_START_Y = 150;
        public static readonly int MAX_LINE_WIDTH = 16;
        public static readonly int MIN_LINE_WIDTH = 1;
        public static readonly Color DEFAULT_COLOR = Color.AliceBlue;
        public static readonly int MIN_SIZE = 20;
        public static readonly int MAX_SIZE = 120;

            int start_x;
            int start_y;
            int line_width;
            public Color Color { get; set; }

        public int Start_X
        { 
            get=> start_x;
            set
            {
                if (value < MIN_START_X) value = MIN_START_X;
                if (value < MAX_START_X) value = MAX_START_X;
                this.start_x = value;

            }
        
        }
        public int Start_Y
        {
            get => start_y;
            set=>start_y=
                value<MIN_START_Y?MIN_START_Y:
                value >MAX_START_Y?MAX_START_Y:
                value;
        }
        public int LineWidth
        {
            get => line_width;
            set=>line_width=
                value < MIN_LINE_WIDTH ? MIN_LINE_WIDTH:
                value >MAX_LINE_WIDTH ? MAX_LINE_WIDTH:
                value;
        }

                    //Constructors:

        public Shape(int start_x,int start_y,int line_width,Color color)
            {
                Start_X=start_x;
                Start_Y=start_y;
                LineWidth=line_width;
                Color=color;
            }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw(PaintEventArgs e);
        public virtual void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Площадь фигуры:{GetArea()}");
            Console.WriteLine($"Периметр фигуры:{GetPerimeter()}");
            Draw(e);
        }
                       
    }
}
