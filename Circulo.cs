using System;

namespace Geometria
{
    public class Circulo : Poligono
    {
        private float m_radio;

        public float Radio
        {
            get => m_radio;
            set
            {
                m_radio = value;
            }
        }

        public Circulo(float radio)
        {
            this.m_radio = radio;
        }

        public override void CalcularPerimetro()
        {
            Console.WriteLine("El perimetro del circulo de radio: " + m_radio + ". Es: " + (2 * m_radio * 3.14));
        }

        public override void CalcularSuperficie()
        {
            Console.WriteLine("La superfice del circulo de radio: " + m_radio + ". Es: " + ((m_radio * m_radio) * 3.14));
        }
    }
}
