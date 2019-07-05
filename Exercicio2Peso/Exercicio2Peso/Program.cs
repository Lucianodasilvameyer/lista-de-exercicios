using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Peso
{
    class Program
    {
        static void Main(string[] args)
        {


            double peso = -1 ;
            int idade = 0;
            int quantidadeHonmens = 0, quantidadeMulheres = 0, homens18=0;
            string sexo = "";

            while( peso != 0)
            {
                Console.WriteLine("Digite peso:");
                peso = Convert.ToDouble(Console.ReadLine());

                if (peso == 0) break;

                Console.WriteLine("Digite Idade:");
                idade = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Digite Sexo (M/F):");

                sexo = Console.ReadLine(); 
                sexo = sexo.ToLower();//o ToLower serve para converter para minusculo


                if(sexo == "m" || sexo == "masculino" )
                {
                    quantidadeHonmens++;

                    if(idade>18)
                    {
                        homens18++;
                        
                    }
                }
                if(sexo=="f"||sexo=="feminino")
                {
                    quantidadeMulheres++;
                }

                
                

                

            }
            

            Console.WriteLine();
            Console.WriteLine("Quantidade de Homens: " + quantidadeHonmens);

            Console.WriteLine("o numero de homens com mais de 18 anos é: " + homens18);

            Console.WriteLine("Quantidade de mulheres: " + quantidadeMulheres);

            Console.ReadKey();
        }
    }
}
