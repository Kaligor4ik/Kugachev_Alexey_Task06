using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Actors
{
    abstract class BaseActor
    {
        private Point position;

        public BaseActor(Point p)
        {
            position = p;
        }

        public Point Position { get => position; }
        public void MoveLeft() => position.X--;
        public void MoveRight() => position.X++;
        public void MoveUp() => position.Y++;
        public void MoveDown() => position.Y--;

        public abstract void Draw();
    }
}
