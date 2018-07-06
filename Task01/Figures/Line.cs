using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Figures
{
    class Line: BaseFigure
    {
        public Line()
        {
            A = CoordinateUtils.SetCoordinate("A");
            B = CoordinateUtils.SetCoordinate("B");
        }
        public Point A { get; set; }
        public Point B { get; set; }

        public double AB
        {
            get { return Math.Round(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)), 2); }
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Отрезок диной: АВ = {0}", AB);
        }
    }
}
