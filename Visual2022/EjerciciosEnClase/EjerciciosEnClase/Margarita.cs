using System;
using System.Collections.Generic;
using System.Drawing;

namespace EjerciciosEnClase
{
    internal class Margarita
    {
        private float lado;
        private float radio;

        public Margarita(float lado)
        {
            this.lado = lado;
            this.radio = lado / (2 * (float)Math.Sin(Math.PI / 5));
        }

        public PointF[] CalcularPentagono(PointF centro, float anguloRotacion)
        {
            PointF[] puntos = new PointF[5];
            for (int i = 0; i < 5; i++)
            {
                float angulo = (float)(2 * Math.PI * i / 5 + anguloRotacion);
                puntos[i] = new PointF(
                    centro.X + radio * (float)Math.Cos(angulo),
                    centro.Y + radio * (float)Math.Sin(angulo)
                );
            }
            return puntos;
        }

        public List<PointF[]> ObtenerPentagonosFlor(PointF centro)
        {
            List<PointF[]> pentagonos = new List<PointF[]>();

            float rotacion = -(float)(Math.PI / 2); // Para que apunte hacia arriba
            float separacion = radio * 1.65f;

            for (int i = 0; i < 5; i++)
            {
                float angulo = (float)(2 * Math.PI * i / 5 + rotacion);
                PointF nuevoCentro = new PointF(
                    centro.X + separacion * (float)Math.Cos(angulo),
                    centro.Y + separacion * (float)Math.Sin(angulo)
                );

                PointF[] petalo = CalcularPentagono(nuevoCentro, rotacion);
                pentagonos.Add(petalo);
            }

            return pentagonos;
        }
    }
}
