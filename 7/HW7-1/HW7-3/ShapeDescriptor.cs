using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_3
{
    class ShapeDescriptor
    {
        public int Count { get;}
        private Point[] Points { set; get; }
        private string ShapeType { get;}

        ShapeDescriptor(params Point[] points)//instead of many-point constructors 
        {   
            Count = points.Length;
            Points = points;
            switch (Count)
            {
                case 1: ShapeType = "Point";
                    break;
                case 2: ShapeType = "Line";
                    break;
                case 3: ShapeType = "Triangle";
                    break;
                case 4: ShapeType = "Square";
                    break;
                default: ShapeType = "Polygon";
                    break;
            }

        }
        static void Main(string[] args)
        {
            ShapeDescriptor shapeDescriptor1  = new ShapeDescriptor(new Point(1,2), new Point(3,4), new Point(5,6));
            ShapeDescriptor shapeDescriptor2 = new ShapeDescriptor(new Point(5, 12));
            Console.WriteLine(shapeDescriptor1.ShapeType);
            Console.WriteLine(shapeDescriptor2.ShapeType);
            Console.ReadKey();

        }
    }
}
