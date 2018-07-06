using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Benefits
{
    class Apple : BaseBenefit
    {
        public Apple(Point p) : base(p) { }
        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void GiveBenefit()
        {
            // timer - 5 sec, changing coordinates on 2 point
        }
    }
}
