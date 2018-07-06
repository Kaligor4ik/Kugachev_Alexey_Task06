using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Figures
{
    class Ring : BaseFigure
    {
        public Ring()
        {
            A = CoordinateUtils.SetCoordinate("A");
            InR = InputReader.GetIntValue("Введите внутренний радиус: ");
            ExR = InputReader.GetIntValue("Введите внешний радиус: ");
        }

        public Point A { get; set; }
        public int InR { get; set; }
        public int ExR { get; set; }

        

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Кольцо с внутренним радиусом InR = {0} и внешним радиусом ExR = {1}", InR, ExR);
        }
    }
}
