using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get => this.length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                else
                {
                    this.length = value;
                }
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double CalcSurfaceArea()
        {
            double area = 2*length*width + 2*length*height + 2*width*height;
            return area;
        }

        public double CalcLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2*length*height + 2*width*height;
            return lateralSurfaceArea;
        }

        public double CalcVolume()
        {
            double volume = length * width * height;
            return volume;
        }
    }
}
