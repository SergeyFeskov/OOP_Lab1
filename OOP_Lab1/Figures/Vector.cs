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
            return Math.Atan(Y / X);
        }

        public float X;
        public float Y;
    }
}


