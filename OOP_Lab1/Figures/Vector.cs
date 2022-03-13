using System;

namespace OOP_Lab2
{
    public class Vector
    {
        public Vector(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Vector(float Length, double Degree)
        {
            X = (float)(Length * Math.Cos(Degree));
            Y = (float)(Length * Math.Sin(Degree));
        }

        public float GetLength()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        public double GetDegree()
        {
            if (X > 0)
            {
                return Math.Atan(Y / X);
            }
            else if (X < 0)
            {
                return Math.PI + Math.Atan(Y / X);
            }
            else
            {
                if (Y > 0)
                    return Math.PI;
                else
                    return -Math.PI;
            }
        }

        public float X;
        public float Y;
    }
}


