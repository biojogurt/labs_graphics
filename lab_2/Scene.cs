using System;
using System.Collections.Generic;
using System.Drawing;

namespace lab_2
{
    class Scene
    {
        private Color Brush { get; }

        private int Height { get; }

        private int Width { get; }

        private List<Vertex> Verts { get; }

        private List<Polygon> Polys { get; }

        private Camera Cam { get; set; }

        private double Del { get; set; }

        private double[,] Zbuffer { get; set; }

        public Bitmap Pic { get; }

        public Vertex LightPoint { get; set; }

        public Scene(int h, int w, Color b)
        {
            Height = h;
            Width = w;
            Brush = b;
            Pic = new Bitmap(Width, Height);
            Verts = new List<Vertex>();
            Polys = new List<Polygon>();
        }

        public void MakePyramide(double height, double baseRadius, int sideCount)
        {
            double angleStep = 360.0 / sideCount;

            List<Vertex> baseVerts = new List<Vertex>();
            for (int i = 0; i < sideCount; i++)
            {
                double angleRad = i * angleStep * Math.PI / 180.0;
                double x = baseRadius * Math.Cos(angleRad);
                double y = baseRadius * Math.Sin(angleRad);
                baseVerts.Add(new Vertex(x, y, 0));
            }

            Vertex topVert = new Vertex(0, 0, height);

            for (int i = 0; i < sideCount; i++)
            {
                int nextIndex = (i + 1) % sideCount;
                Polys.Add(new Polygon(baseVerts[i], baseVerts[nextIndex], topVert, Brush));
            }

            Verts.AddRange(baseVerts);
            Verts.Add(topVert);
        }

        public void AddCamera(Camera c)
        {
            Cam = c;
            Del = 1 / Math.Tan(Cam.Angle / 2);
        }

        public Point ConvertToScreenPoint(Vertex v)
        {
            Point result = new Point
            {
                X = (int) Math.Round((v.Vcam.GetX() / v.Vcam.GetZ() * Del * Width / 2) + ((double) Width / 2)),
                Y = (int) Math.Round((v.Vcam.GetY() / v.Vcam.GetZ() * Del * Width / 2) + ((double) Height / 2))
            };
            return result;
        }

        public bool CheckPoint(Point pnt, List<Point> pnts)
        {
            Vertex v0, v1, v2;
            v0 = new Vertex(pnt).Minus(new Vertex(pnts[0]));
            v1 = new Vertex(pnts[1]).Minus(new Vertex(pnts[0]));
            v2 = new Vertex(pnts[2]).Minus(new Vertex(pnts[0]));

            if (Math.Abs(v2.FindAngle(v1) - v2.FindAngle(v0) - v1.FindAngle(v0)) > 1e-3)
            {
                return false;
            }

            v0 = new Vertex(pnt).Minus(new Vertex(pnts[1]));
            v1 = new Vertex(pnts[0]).Minus(new Vertex(pnts[1]));
            v2 = new Vertex(pnts[2]).Minus(new Vertex(pnts[1]));

            return Math.Abs(v2.FindAngle(v1) - v2.FindAngle(v0) - v1.FindAngle(v0)) <= 1e-3;
        }

        public Vertex FindVertex(Point pnt, Polygon poly)
        {
            Vertex onScreen = new Vertex((pnt.X - ((double) Width / 2)) / (Del * Width / 2), (pnt.Y - ((double) Height / 2)) / (Del * Width / 2), 1);
            Vertex norm = poly.NormalCam;
            double A = norm.X,
                   B = norm.Y,
                   C = norm.Z,
                   D = -((A * poly.Vertex0.Vcam.GetX()) + (B * poly.Vertex0.Vcam.GetY()) + (C * poly.Vertex0.Vcam.GetZ()));
            double t = -D / ((A * onScreen.GetX()) + (B * onScreen.GetY()) + (C * onScreen.GetZ()));
            return onScreen.Scale(t);
        }

        public Color ColorWithLight(Polygon poly)
        {
            double R = 20, G = 20, B = 20;
            Vertex norm = poly.Normal;
            Vertex ray = LightPoint;

            if (ray.FindAngle(norm) < Math.PI / 2)
            {
                double cos = Math.Pow(Math.Cos(ray.FindAngle(norm)), 0.5);
                R = cos * poly.Color.R;
                G = cos * poly.Color.G;
                B = cos * poly.Color.B;
            }

            return Color.FromArgb(Math.Min((int) R, 255), Math.Min((int) G, 255), Math.Min((int) B, 255));
        }

        public void DrawPolygon(Polygon poly)
        {
            List<Point> pnts = new List<Point>
            {
                ConvertToScreenPoint(poly.Vertex0),
                ConvertToScreenPoint(poly.Vertex1),
                ConvertToScreenPoint(poly.Vertex2)
            };

            int minX, minY, maxX, maxY;
            minX = maxX = pnts[0].X;
            minY = maxY = pnts[0].Y;

            foreach (Point pnt in pnts)
            {
                minX = Math.Min(minX, pnt.X);
                maxX = Math.Max(maxX, pnt.X);
                minY = Math.Min(minY, pnt.Y);
                maxY = Math.Max(maxY, pnt.Y);
            }

            minX = Math.Max(minX, 0);
            minY = Math.Max(minY, 0);
            maxX = Math.Min(maxX, Width - 1);
            maxY = Math.Min(maxY, Height - 1);

            for (int X = minX; X <= maxX; X++)
            {
                for (int Y = minY; Y <= maxY; Y++)
                {
                    Point curp = new Point(X, Y);
                    if (CheckPoint(curp, pnts))
                    {
                        Vertex curV = FindVertex(curp, poly);
                        if (curV.GetZ() < Zbuffer[X, Y])
                        {
                            Zbuffer[X, Y] = curV.GetZ();
                            Pic.SetPixel(X, Y, ColorWithLight(poly));
                        }
                    }
                }
            }
        }

        public void Render()
        {
            if (Cam != null)
            {
                foreach (Vertex vr in Verts)
                {
                    vr.RotateForCam(Cam);
                }

                LightPoint.RotateForCam(Cam);
                Graphics gr = Graphics.FromImage(Pic);
                gr.Clear(Color.White);
                Zbuffer = new double[Width, Height];
                for (int i = 0; i < Width; i++)
                {
                    for (int j = 0; j < Height; j++)
                    {
                        Zbuffer[i, j] = 10000;
                    }
                }

                foreach (Polygon pl in Polys)
                {
                    if (pl.Vertex0.Minus(Cam.Pos).FindAngle(pl.Normal) > Math.PI / 2)
                    {
                        if (pl.Vertex0.Vcam.GetZ() > 0.2 && pl.Vertex1.Vcam.GetZ() > 0.2 && pl.Vertex2.Vcam.GetZ() > 0.2)
                        {
                            DrawPolygon(pl);
                        }
                    }
                }
            }
        }
    }
}