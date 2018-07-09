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
        private const int DefaultIncrement = 1;
        private Point position;
        private int stepLength;

        public BaseActor(Point p)
        {
            position = p;
            stepLength = DefaultIncrement;
        }

        public Point Position { get => position; }
        public int StepLength { get => stepLength; set => stepLength = value; }
        public void MoveLeft() => position.X = position.X - StepLength;
        public void MoveRight() => position.X = position.X + StepLength;
        public void MoveUp() => position.Y = position.Y + StepLength;
        public void MoveDown() => position.Y = position.Y - StepLength;

        public abstract void Draw();
    }
}
