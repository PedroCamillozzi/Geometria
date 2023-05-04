using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        private float m_base;
        private float m_altura;

        public Rectangulo(float b, float h)
        {
            this.m_base = b;
            this.m_altura = h;
        }

        public float Base
        {
            get => m_base;
            set => m_base = value;
        }

        public float Altura
        {
            get => m_altura;
            set => m_altura = value;
        }

        public override void CalcularPerimetro()
        {
            Console.WriteLine("El perímetro del rectángulo de base " + m_base + " y altura " + m_altura +" es: " + (2 * m_base) + (2 * m_altura));
        }

        public override void CalcularSuperficie()
        {
            Console.WriteLine("La superficie del rectángulo de base " + m_base + " y altura " + m_altura + " es: " + m_base * m_altura);
        }
    }
}