using System;


/*
  7. Crie uma classe abstrata Figura, com um campo double x (privado). Crie um construtor para fornecer o valor para esse campo. 
  Crie dois métodos abstract CalcularArea() e CalcularPerimetro() que devem retornar os valores da área e do perímetro de uma figura regular, baseados na medida x através de um overload. 
  Crie as classes derivadas Equilatero, Quadrado, Circulo, Pentagono, Hexagono, Heptagono e Octogono
 */
namespace exercicio_7_da_revisão
{
    public abstract class Figura
    {
        protected double lado;
    
        protected void setX(double x)
        {
            this.lado = x;
        }
        protected double getX()
        {
            return lado;
        }

        public Figura(double x)
        {
            this.lado = x;
        }

        public virtual double CalcularArea()
        {
            return lado * 80;
        }

        public virtual double CalcularPerimetro()
        {

        }

        //------------------------------------------
        public double calcularAreaTrianguloEquilatero(double basee, double altura)
        {
            return (basee * altura) / 2;
        }
        public double calcularPerimetroTrianguloEquilatero(double lado)
        {
            return lado * 3;
        }
        public double calcularAreaQuadrado(double lado)
        {
            return lado * 2;
        }
        public double calcularPerimetroQuadrado(double lado)
        {
            return lado * 4;
        }
        public double calcularAreaCirculo(double raio)
        {
            return Math.PI * (raio * raio);
        }
        public double calcularPerimetroCirculo(double raio)
        {
            return (2 * Math.PI) * raio;
        }
        public double calcularAreaPentagono(double perímetro, double apotema)
        {
            return (perímetro * apotema) / 2;
        }
        public double calcularPerimetroPentagono(double lado)
        {
            return lado*5;
        }
        public double calcularAreaHexagono(double perímetro, double apotema)
        {
            return (perímetro * apotema) / 2;
        }
        public double calcularPerimetroHexagono(double lado)
        {
            return lado * 6;
        }
        public double calcularAreaHeptagono(double perímetro, double apotema)
        {
            return (perímetro * apotema) / 2;
        }
        public double calcularPerimetroHeptagono(double lado)
        {
            return lado * 7;
        }
        public double calcularAreaOctogono(double perímetro,double apotema)
        {
            return (perímetro * apotema) / 2;
        }
        public double calcularPerimetroOctogono(double lado)
        {
            return lado * 8;
        }
    }


    class Quadrado : Figura
    {

        public override double CalcularArea()
        {
            lado * lado;
        }
    }

    class Equilatero : Figura
    {

        public override double CalcularArea()
        {
           return lado * lado / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Figura f;
            Quadrado q;

            f.CalcularArea();
            q.CalcularArea();

           // Console.WriteLine()


        }
    }
}
