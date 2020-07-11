using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeomatricas_FocoNoUsoDoPolimorfismo
{
     abstract class FormasGeometricas
    {
        private int _largura;
        private int _altura;

        public int Largura
        {
            get { return _largura; }
            set { _largura = value; }
        }

        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public void Apresentar()
        {
            Console.WriteLine("Este método pertence a classe base.");
        }

        public abstract void Desenhar();

        public virtual void desenharOutro()
        {
            Console.WriteLine("Método virtual da clase base.");
        }
 
    }

    class Retangulo : FormasGeometricas
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar um retangulo com dimensões : " + Largura + " x " + Altura);
        }

        public override void desenharOutro()
        {
            Console.WriteLine("Este é um método virtual substituido na classe derivada.");
        }
    }

    class Triangulo : FormasGeometricas
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar um triangulo com dimensões : " + Largura + " x " + Altura);
        }
    }

    class Circunferencia : FormasGeometricas
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar uma circunferência com dimensões : " + Largura + " x " + Altura);
        }
    }
}
