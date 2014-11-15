using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    public class Rectangle : I2DPylygon
    {
        private double x;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("X must be over 0");
                x = value;
            }
        }

        private double y;
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("X must be over 0");
                y = value;
            }
        }

        public double Area
        {
            get
            {
                return X * Y;
            }
        }

        public double Perimeter
        {
            get
            {
                return 2 * X + 2* Y;
            }
        }
    }
}
