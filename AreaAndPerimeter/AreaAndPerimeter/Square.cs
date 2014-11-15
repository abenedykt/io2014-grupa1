using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaAndPerimeter
{
    public class Square : I2DPylygon
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

        public double Area
        {
            get
            {
                return X * X;
            }
        }

        public double Perimeter
        {
            get
            {
                return X * 4;
            }
        }
    }
}
