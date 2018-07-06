using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Actors
{
    internal class Player: BaseActor
    {
        private static readonly Point p = new Point(0, 0);
        public Player() : base(p) { }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
