using System;
using System.Drawing;

namespace Parcial2.Algoritmos
{
    internal class AlgoritmoCohenSutherland
    {
        const int INSIDE = 0; //0000
        const int LEFT = 1;   //0001
        const int RIGHT = 2;  //0010
        const int BOTTOM = 4; //0100
        const int TOP = 8;    //1000

        private int xmin, ymin, xmax, ymax;

        public AlgoritmoCohenSutherland(int xmin, int ymin, int xmax, int ymax)
        {
            this.xmin = xmin;
            this.ymin = ymin;
            this.xmax = xmax;
            this.ymax = ymax;
        }

        private int CalcularCodigo(int x, int y)
        {
            int code = INSIDE;

            if (x < xmin) code |= LEFT;
            else if (x > xmax) code |= RIGHT;

            if (y < ymin) code |= BOTTOM;
            else if (y > ymax) code |= TOP;

            return code;
        }

        public bool RecortarLinea(ref int x1, ref int y1, ref int x2, ref int y2)
        {
            int code1 = CalcularCodigo(x1, y1);
            int code2 = CalcularCodigo(x2, y2);
            bool aceptar = false;

            while (true)
            {
                if ((code1 | code2) == 0)
                {
                    //Totalmente dentro
                    aceptar = true;
                    break;
                }
                else if ((code1 & code2) != 0)
                {
                    //Totalmente fuera
                    break;
                }
                else
                {
                    int codeFuera;
                    int x = 0, y = 0;

                    if (code1 != 0)
                        codeFuera = code1;
                    else
                        codeFuera = code2;

                    if ((codeFuera & TOP) != 0)
                    {
                        x = x1 + (x2 - x1) * (ymax - y1) / (y2 - y1);
                        y = ymax;
                    }
                    else if ((codeFuera & BOTTOM) != 0)
                    {
                        x = x1 + (x2 - x1) * (ymin - y1) / (y2 - y1);
                        y = ymin;
                    }
                    else if ((codeFuera & RIGHT) != 0)
                    {
                        y = y1 + (y2 - y1) * (xmax - x1) / (x2 - x1);
                        x = xmax;
                    }
                    else if ((codeFuera & LEFT) != 0)
                    {
                        y = y1 + (y2 - y1) * (xmin - x1) / (x2 - x1);
                        x = xmin;
                    }

                    if (codeFuera == code1)
                    {
                        x1 = x;
                        y1 = y;
                        code1 = CalcularCodigo(x1, y1);
                    }
                    else
                    {
                        x2 = x;
                        y2 = y;
                        code2 = CalcularCodigo(x2, y2);
                    }
                }
            }

            return aceptar;
        }
    }
}
