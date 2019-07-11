using System;

namespace exercicio_7_da_revisão
{
    public class Figura
    {
        private double x;
    
        private void setX(double x)
        {
            this.x = x;
        } 
        private double getX()
        {
            return x;
        }
        public Figura(double x)
        {
            this.x = x;
        }
        public double calcularAreaTrianguloEquilatero(double base, double altura)
        {
            return (base * altura) / 2;
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


    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
