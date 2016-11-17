using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnderwijsBlok6
{
    public interface IMeasurable
    {
        double GetSurfaceArea();
    }

    public class SodaCan : IMeasurable
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public SodaCan(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public double GetSurfaceArea()
        {
            return Math.PI * Math.PI * Radius;
        }

        public double GetVolume()
        {
            return GetSurfaceArea() * Height;
        }
    }
}