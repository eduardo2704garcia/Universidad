using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmEjercicio1());
            Application.Run(new FrmEjercicio2());
            //Application.Run(new FrmHome());
            //Application.Run(new FrmLine());
            //Application.Run(new FrmRectangle());
            //Application.Run(new FrmSquare());
            //Application.Run(new FrmCircle());
            //Application.Run(new FrmTriangle());
            //Application.Run(new FrmEllipse());
            //Application.Run(new FrmSemicircle());
            //Application.Run(new FrmTrapezoid());
            //Application.Run(new FrmRhombus());
            //Application.Run(new FrmRhombusoid());
            //Application.Run(new FrmDeltoid());
            //Application.Run(new FrmStar());
        }
    }
}
