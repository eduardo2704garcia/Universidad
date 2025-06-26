using System.Collections.Generic;
using System.Drawing;

namespace P2_D2_Algoritmos_GarciaE.Interfaces
{
    public interface IFiguraCurva
    {
        List<PointF> CalcularPuntos(List<PointF> puntosControl);
        void Dibujar(Graphics g, List<PointF> puntos, Pen lapiz);
        int MinimoPuntos { get; } 
    }
}
