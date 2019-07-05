using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Program
    {
        static void semArray()
        {
            int num; //como quer saber quantos são negativos pode usar a variavel num, se fosse quais numeros ai sim pode colocar num1,num1,nmu3... 
            int caixa=0;
            

            Console.WriteLine("digite 5 valores para saber quantos são negativos");
            

            for (int i = 0; i < 5; i++)
            {

                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0) caixa++;

                

               
            }
            Console.WriteLine("tem: " + caixa + "numeros negativos");


        }

        static void comArray()
        {
            int[] numeros = new int[5];
            int Sacola=0;

            Console.WriteLine("digite 5 numeros para saber quantos são negativos");
             
            for(int i=0; i <numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] < 0) Sacola++;
            }
            Console.WriteLine("existem " + Sacola + " numeros negativos. Os numeros negativos digitados são: ");

            for(int i=0; i < numeros.Length;i++)
            {
                if(numeros[i]<0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }    

            Console.ReadKey();
        }

        // fazer um programa que o usuario digite idade, sexo e peso de uma pessoa
        // enquanto  não digitar uma idade com valor 0, ficae lendo

        // mostrar quantos homens
        // quantas mulheres
        // quantos homens com idade > 18
        // quantas mulheres com > 30 e peso menor 70
        // mostrar media de peso geral
        // media de idade das mulheres

        static void Main(string[] args)
        {


            //semArray();
            comArray();

            Console.ReadKey();

        }
    }
}
