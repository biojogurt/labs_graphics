using System.Drawing;

namespace lab_2
{
    class Polygon
    {
        public Vertex Vertex0 { get; }

        public Vertex Vertex1 { get; }

        public Vertex Vertex2 { get; }

        public Color Color { get; }

        public Polygon(Vertex v0, Vertex v1, Vertex v2, Color c)
        {
            Vertex0 = v0;
            Vertex1 = v1;
            Vertex2 = v2;
            Color = c;
        }

        public Vertex Normal
        {
            get { return Vertex1.Minus(Vertex0).GetVectorMult(Vertex2.Minus(Vertex0)); }
        }

        public Vertex NormalCam
        {
            get { return Vertex1.Vcam.Minus(Vertex0.Vcam).GetVectorMult(Vertex2.Vcam.Minus(Vertex0.Vcam)); }
        }
    }
}