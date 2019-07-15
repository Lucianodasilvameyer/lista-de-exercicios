using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7darevisão
{
    public class Figura
    {
        protected double lado;
        protected double raio;
        protected double apotema;
        protected double perimetro;

        public void setPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }
        public double getPerimetro()
        {
            return perimetro;
        }  

        public void setApotema(double apotema)
        {
            this.apotema = apotema;
        }
        public double getApotema()
        {
            return apotema;
        }

        public void setRaio(double raio)
        {
            this.raio = raio;
        }
        public double getRaio()
        {
            return raio;
        }



        public void setLado(double x) //não deveria ser private em vez do public?
        {
            this.lado = x; //aqui é this.lado = x pq o x tambem é o lado?
        }
        public double getLado() //não deveria ser private em vez do public?
        {
            return lado; //aqui não deveria retornar x?
        }


        public virtual double CalcularArea()
        {
            return lado;
        }

        public virtual double CalcularPerimetro()
        {
            return lado;
        }


    }


    class Quadrado : Figura
    {


        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return lado * 4;
        }
    }

    class Equilatero : Figura
    {



        public override double CalcularArea()
        {
            return lado * lado / 2;
        }

        public override double CalcularPerimetro()
        {
            return lado * 3;
        }
    }
    class Circulo : Figura
    {


        public override double CalcularArea()
        {
            return Math.PI * (raio * raio);
        }

        public override double CalcularPerimetro()
        {
            return (2 * Math.PI) * raio;
        }
    }
    class Pentagono : Figura
    {
        public override double CalcularArea()
        {
            return (perimetro * apotema) / 2;
        }

        public override double CalcularPerimetro()
        {
            return lado * 5;
        }
    }
    class Hexagono : Figura
    {
        public override double CalcularArea()
        {
            return (perimetro * apotema) / 2;
        }

        public override double CalcularPerimetro()
        {
            return lado * 6;
        }
    }
    class Heptagono : Figura
    {
        public override double CalcularArea()
        {
            return (perimetro * apotema) / 2;
        }

        public override double CalcularPerimetro()
        {
            return lado * 7;
        }

    }
    class Octogono : Figura
    {
        public override double CalcularArea()
        {
            return (perimetro * apotema) / 2;
        }

        public override double CalcularPerimetro()
        {
            return lado * 8;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("informe o tamanho do lado");
            int lado = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("informe a figura");
            Console.WriteLine("1 - quadrado");
            Console.WriteLine("2 - triangulo equilatero");
            Console.WriteLine("3- Circulo");
            Console.WriteLine("4- Pentagono");
            Console.WriteLine("5- Hexagono");
            Console.WriteLine("6- Heptagono");
            Console.WriteLine("7- Octogono");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {

                case 1:
                    Quadrado q = new Quadrado();
                    q.setLado(lado);

                    Console.WriteLine("AREA: " + q.CalcularArea());
                    Console.WriteLine("PERIMETRO: " + q.CalcularPerimetro());

                    break;

                case 2:
                    Equilatero e = new Equilatero();
                    e.setLado(lado);

                    Console.WriteLine("AREA: " + e.CalcularArea());
                    Console.WriteLine("PERIMETRO: " + e.CalcularPerimetro());
                    break;

                case 3:
                    Circulo c = new Circulo();
                    c.setRaio(raio);

                    Console.WriteLine("AREA: " + c.CalcularArea());
                    Console.WriteLine("PERIMETRO: " + c.CalcularPerimetro());
                    break;
                case 4:
                    Pentagono p = new Pentagono();
                    p.setLado(lado);

                    Console.WriteLine("AREA: " + p.CalcularArea());
                    Console.WriteLine("PERIMETRO: " + p.CalcularPerimetro());
                    break;
                case 5:
                    Hexagono h = new Hexagono();
                    h.setLado(lado);

                    Console.WriteLine("AREA: " + h.CalcularArea());
                    Console.WriteLine("PERIMETRO: " + h.CalcularPerimetro());
                    break;
                case 6:
                    Heptagono h2 = new Heptagono();
                    h2.setLado(lado);

                    Console.WriteLine("AREA: " + h2.CalcularArea());
                    Console.WriteLine("PERIMETRO: " + h2.CalcularPerimetro());
                    break;
                case 7:
                    Octogono h3 = new Octogono();
                    h3.setLado(lado);

                    Console.WriteLine("AREA: " + h3.CalcularArea());
                    Console.WriteLine("PERIMETRO: " + h3.CalcularPerimetro());
                    break;



            }



            Console.ReadKey();
        }
    }


}
