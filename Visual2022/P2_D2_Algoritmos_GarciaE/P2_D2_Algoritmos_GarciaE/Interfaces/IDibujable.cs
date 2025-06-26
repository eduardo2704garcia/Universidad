using System.Collections.Generic;
using System.Drawing;

namespace P2_D2_Algoritmos_GarciaE.Interfaces
{
    public interface IDibujable
    {
        void Dibujar(Graphics g, List<Point> puntos);
    }
}
