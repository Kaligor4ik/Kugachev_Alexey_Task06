using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class CoordinateUtils
    { 
        public static Point SetCoordinate(string pointName)
        {
            int x, y;
            x = InputReader.GetIntValue(string.Format("Ввести координату Х для точки {0}: ", pointName));
            y = InputReader.GetIntValue(string.Format("Ввести координату У для точки {0}: ", pointName));
            return new Point(x, y);
        }
    }
}