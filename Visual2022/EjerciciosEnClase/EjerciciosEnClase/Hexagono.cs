using System;
using System.Drawing;

namespace EjerciciosEnClase
{
    internal class Hexagono
    {
        public static PointF[] CalcularVertices(Point centro, float radio)
        {
            PointF[] vertices = new PointF[6];
            double anguloGrados = 60;

            for (int i = 0; i < 6; i++)
            {
                double anguloRadianes = Math.PI / 180 * anguloGrados * i;

                float x = centro.X + radio * (float)Math.Cos(anguloRadianes);
                float y = centro.Y + radio * (float)Math.Sin(anguloRadianes);

                vertices[i] = new PointF(x, y);
            }

            return vertices;
        }
    }
}
