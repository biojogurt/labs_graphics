using System;
using System.Drawing;

namespace lab_2
{
    class Vertex
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public double Z { get; private set; }

        public double W { get; private set; }

        public Vertex Vcam { get; private set; }

        public Vertex(double x, double y, double z, double w = 1)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
            Vcam = null;
        }

        public Vertex(string str)
        {
            string[] coords = str.Split(' ');
            X = double.Parse(coords[0]);
            Y = double.Parse(coords[1]);
            Z = double.Parse(coords[2]);
            W = 1;
            Vcam = null;
        }

        public Vertex(Point pnt)
        {
            X = pnt.X;
            Y = pnt.Y;
            Z = 0;
            W = 1;
            Vcam = null;
        }

        public double GetX()
        {
            return X / W;
        }

        public double GetY()
        {
            return Y / W;
        }

        public double GetZ()
        {
            return Z / W;
        }

        public double Length
        {
            get { return Math.Sqrt((X * X) + (Y * Y) + (Z * Z)); }
        }

        public Vertex GetVectorMult(Vertex src)
        {
            double x, y, z;
            x = (GetY() * src.GetZ()) - (GetZ() * src.GetY());
            y = (GetZ() * src.GetX()) - (GetX() * src.GetZ());
            z = (GetX() * src.GetY()) - (GetY() * src.GetX());
            return new Vertex(x, y, z);
        }

        public Vertex ApplyMatrix(Matrix matr)
        {
            Vertex result = new Vertex(0, 0, 0, 0);
            double[] input = { X, Y, Z, W };

            for (int i = 0; i < 4; i++)
            {
                result.X += input[i] * matr.Fields[i, 0];
                result.Y += input[i] * matr.Fields[i, 1];
                result.Z += input[i] * matr.Fields[i, 2];
                result.W += input[i] * matr.Fields[i, 3];
            }

            return result;
        }

        public double FindAngle(Vertex src)
        {
            if (Length == 0 || src.Length == 0)
            {
                return 0;
            }

            double cos = ((GetX() * src.GetX()) + (GetY() * src.GetY()) + (GetZ() * src.GetZ())) / (Length * src.Length);
            return Math.Acos(cos);
        }

        public void RotateForCam(Camera cam)
        {
            Vcam = ApplyMatrix(cam.ToRotate);
        }

        public Vertex Minus(Vertex src)
        {
            return new Vertex(GetX() - src.GetX(), GetY() - src.GetY(), GetZ() - src.GetZ());
        }

        public Vertex Scale(double mnozh)
        {
            return new Vertex(GetX() * mnozh, GetY() * mnozh, GetZ() * mnozh);
        }
    }
}