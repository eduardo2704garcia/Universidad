using System.Collections.Generic;
using System.Drawing;

namespace P2_D2_Algoritmos_GarciaE.Interfaces
{
    public interface IRecortable
    {
        bool RecortarLinea(ref Point p1, ref Point p2, Rectangle ventana);
        List<Point> RecortarPoligono(List<Point> puntos, Rectangle ventana);
    }
}
