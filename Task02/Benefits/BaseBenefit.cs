using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Benefits
{
    abstract class BaseBenefit
    {
        private Point position;

        public BaseBenefit(Point p)
        {
            position = p;
        }

        public Point Position { get => position; }

        public abstract void Draw();
        public abstract void GiveBenefit();
    }
}
