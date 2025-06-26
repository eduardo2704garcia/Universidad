using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_D2_Algoritmos_GarciaE.Interfaces
{
    public interface IAnimable
    {
        Task Animar(Graphics g, List<Point> puntos, PictureBox canvas, int velocidad);
    }
}
