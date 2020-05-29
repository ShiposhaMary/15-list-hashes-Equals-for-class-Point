using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals_for_class_Point
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        //Equals позволяет определять логику "быть равным" для наших типов данных
        public override bool Equals(object obj)
        {
            if (!(obj is Point)) return false;
            var point = obj as Point;
            return X == point.X && Y == point.Y;
        }
    }

    class Program
    {
        public static void Main()
        {
            var point = new Point { X = 1, Y = 1 };

            var list = new List<Point>();
            //var list = new List<Point>();

            list.Add(point);
            Console.WriteLine(list.Contains(point));
            Console.WriteLine(list.Contains(new Point { X = 1, Y = 1 }));
        }
    }
}
