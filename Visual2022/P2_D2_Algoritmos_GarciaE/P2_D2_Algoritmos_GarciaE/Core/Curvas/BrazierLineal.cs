using System.Collections.Generic;
using System.Drawing;
using P2_D2_Algoritmos_GarciaE.Interfaces;

namespace P2_D2_Algoritmos_GarciaE.Core.Curvas
{
    public class BezierLineal : IFiguraCurva
    {
        public int MinimoPuntos => 2;
        public List<PointF> CalcularPuntos(List<PointF> puntos)
        {
            var resultado = new List<PointF>();
            for (float t = 0; t <= 1; t += 0.01f)
            {
                float x = (1 - t) * puntos[0].X + t * puntos[1].X;
                float y = (1 - t) * puntos[0].Y + t * puntos[1].Y;
                resultado.Add(new PointF(x, y));
            }
            return resultado;
        }

        public void Dibujar(Graphics g, List<PointF> curva, Pen lapiz)
        {
            for (int i = 0; i < curva.Count - 1; i++)
            {
                g.DrawLine(lapiz, curva[i], curva[i + 1]);
            }
        }
    }
}
