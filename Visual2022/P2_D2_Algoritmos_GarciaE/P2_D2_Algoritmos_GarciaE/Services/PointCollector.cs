using System.Collections.Generic;
using System.Drawing;

namespace P2_D2_Algoritmos_GarciaE.Services
{
    public static class PointCollector
    {
        public static void AgregarPunto(List<Point> lista, Point nuevo)
        {
            if (!lista.Contains(nuevo))
                lista.Add(nuevo);
        }

        public static void LimpiarPuntos(List<Point> lista)
        {
            lista.Clear();
        }

        public static string MostrarPuntos(List<Point> lista)
        {
            return string.Join(" | ", lista.ConvertAll(p => $"({p.X},{p.Y})"));
        }
    }
}
