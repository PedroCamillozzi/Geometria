using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Triangulo : Poligono
    {
        private float m_base;
        private float m_altura;

        public Triangulo(float b, float h)
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
            Console.WriteLine($"El perímetro del triángulo de base {m_base} y altura {m_altura} es: {m_base + 2 * (float)Math.Sqrt(Math.Pow(m_base / 2, 2) + Math.Pow(m_altura, 2))}");
        }

        public override void CalcularSuperficie()
        {
            Console.WriteLine($"La superficie del triángulo de base {m_base} y altura {m_altura} es: {(m_base * m_altura) / 2}");
        }
    }
}