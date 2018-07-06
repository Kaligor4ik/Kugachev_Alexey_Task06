using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Figures
{
    class Round : BaseFigure
    {
        public Round()
        {
            A = CoordinateUtils.SetCoordinate("A");
            R = InputReader.GetIntValue("Введите радиус: ");
        }

        public Point A { get; set; }
        public int R { get; set; }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Круг радиусом: R = {0}", R);
        }
    }
}
