using System;
using System.Collections.Generic;
using System.Text;


namespace Point
{
    class Point
    {
        float _x;
        float _y;
        float _z;
        public Point (float x,float y,float z) { X = x; Y = y; Z = z; }                         

        public float X
        {
            get 
            { 
                return _x; 
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("ArgumentExeption");
                }
                else
                {
                    _x = value;
                }

            }

        }

        public float Y
        {
            get
            {
                return _y;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("ArgumentExeption");
                }
                else
                {
                    _y = value;
                }
            }

        }

        public float Z
        {
            get
            {
                return _z;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("ArgumentExeption");
                }
                else
                {
                    _z = value;
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return " X: " + X + " Y: " + Y + " Z: " + Z;
        }

        public override bool Equals(object point)
        {
            var myPoint = point as Point;
            if (Math.Abs(X - myPoint.X) < System.Double.Epsilon &&
                Math.Abs(Y - myPoint.Y) < System.Double.Epsilon &&
                Math.Abs(Z - myPoint.Z) < System.Double.Epsilon)
                return true;
            else return false;            
        }

        public double FindDistance(Point point_one, Point point_two)
        {
            double distance = (Math.Sqrt(point_one.X - point_two.X)*(point_one.X - point_two.X) + 
                    (point_one.Y - point_two.Y)*(point_one.Y - point_two.Y) + 
                    (point_one.Z - point_two.Z)*(point_one.Z - point_two.Z));
            return distance;
        }
    }
}
