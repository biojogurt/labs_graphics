using System;

namespace lab_2
{
    class Matrix
    {
        public double[,] Fields { get; }

        public Matrix()
        {
            Fields = new double[4, 4];
        }

        public static Matrix GetShiftMatr(double shiftX, double shiftY, double shiftZ)
        {
            Matrix result = new Matrix();
            result.Fields[0, 0] = 1;
            result.Fields[1, 1] = 1;
            result.Fields[2, 2] = 1;
            result.Fields[3, 3] = 1;
            result.Fields[3, 0] = shiftX;
            result.Fields[3, 1] = shiftY;
            result.Fields[3, 2] = shiftZ;
            return result;
        }

        public static Matrix GetRorateXMatr(double angle)
        {
            Matrix result = new Matrix();
            result.Fields[0, 0] = 1;
            result.Fields[1, 1] = Math.Cos(angle);
            result.Fields[2, 2] = Math.Cos(angle);
            result.Fields[1, 2] = Math.Sin(angle);
            result.Fields[2, 1] = -Math.Sin(angle);
            result.Fields[3, 3] = 1;
            return result;
        }

        public static Matrix GetRorateZMatr(double angle)
        {
            Matrix result = new Matrix();
            result.Fields[2, 2] = 1;
            result.Fields[0, 0] = Math.Cos(angle);
            result.Fields[1, 1] = Math.Cos(angle);
            result.Fields[0, 1] = Math.Sin(angle);
            result.Fields[1, 0] = -Math.Sin(angle);
            result.Fields[3, 3] = 1;
            return result;
        }

        public Matrix MulMatrs(Matrix m2)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        result.Fields[i, j] += this.Fields[i, k] * m2.Fields[k, j];
                    }
                }
            }
            return result;
        }
    }
}