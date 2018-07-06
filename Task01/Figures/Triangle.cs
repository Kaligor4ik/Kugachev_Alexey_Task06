using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task01.Figures
{
    class Triangle: BaseFigure
    {
        public Triangle()
        {
            A = CoordinateUtils.SetCoordinate("A");
            B = CoordinateUtils.SetCoordinate("B");
            C = CoordinateUtils.SetCoordinate("C");
        }
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public double AB
        {
            get { return Math.Round(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)), 2); }
        }

        public double AC
        {
            get { return Math.Round(Math.Sqrt(Math.Pow(C.X - A.X, 2) + Math.Pow(C.Y - A.Y, 2)), 2); }
        }

        public double BC
        {
            get { return Math.Round(Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2)), 2); }
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Треугольник со сторонами: АВ = {0}, AC = {1}, BC = {2}", AB, AC, BC);
        }
    }
}
