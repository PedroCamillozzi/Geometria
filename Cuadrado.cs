using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Poligono
    {
        private float m_lado;

        public Cuadrado(float l)
        {
            this.m_lado = l;
        }

        public float Lado
        {
            get => m_lado;
            set
            {
                m_lado = value;
            }
        }

        public override void CalcularPerimetro()
        {
            Console.WriteLine("El perimetro del cuadrado de lados: " + m_lado + ". Es: " + (4 *m_lado)) ;
        }

        public override void CalcularSuperficie()
        {
            Console.WriteLine("La superficie del cuadrado de lados: " + m_lado + ". Es: " +  (m_lado * m_lado)) ;
        }
    }
}