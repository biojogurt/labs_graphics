using System;

namespace lab_2
{
    class Camera
    {
        public Vertex Pos { get; }

        public Vertex Direction { get; }

        public double Angle { get; }

        public Matrix ToRotate { get; }

        public Camera(Vertex p, Vertex d, double a)
        {
            Pos = p;
            Direction = d;

            if (Direction.Length == 0)
            {
                Direction.ApplyMatrix(Matrix.GetShiftMatr(0, 0, 1));
            }

            Angle = a * Math.PI / 180;
            Matrix shift = Matrix.GetShiftMatr(-Pos.GetX(), -Pos.GetY(), -Pos.GetZ());
            Vertex proj = new Vertex(Direction.GetX(), Direction.GetY(), 0);
            double ang = proj.FindAngle(new Vertex(0, 1, 0));

            if (proj.GetX() < 0)
            {
                ang = -ang;
            }

            Matrix rotZ = Matrix.GetRorateZMatr(ang);
            Matrix rotX = Matrix.GetRorateXMatr(Direction.FindAngle(new Vertex(0, 0, 1)));
            ToRotate = shift.MulMatrs(rotZ.MulMatrs(rotX));
        }
    }
}