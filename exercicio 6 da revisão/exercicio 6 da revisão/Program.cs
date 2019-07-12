using System;

namespace exercicio_6_da_revisão
{
    public class Calculadora
    {
        // não se usa atributos pq  não é necessario guardar valores e assim não é necessario usar get e set pq não tem q guardar valores
        //se usa o static pq não esta usando atributos
        static public double soma(double numA, double numB)
        {
            return numA + numB;
        }

        static public double subtracao(double numA, double numB)
        {
            return numA - numB;
        }

        static public double multiplicacao(double numA, double numB)
        {
            return numA * numB;
        }

        static public double divisao(double numA, double numB)
        {
            if (numB == 0)
            {
                Console.WriteLine("erro, divisao por zero");
            }

            return numA / numB;
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public static double raizquadrada(double numA)
        {
            return Math.Sqrt(numA);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            double numA;
            double numB;
            bool saida = false;
            int opcao = -1;
            bool calculadoraCientifica = false;

            while (saida != true)
            {
                Console.WriteLine("escolha uma das seguintes condições");
                Console.WriteLine("1-calculadora");
                Console.WriteLine("2-Calculadora cientifica");
                Console.WriteLine("3-sair do programa");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 3)
                {
                    saida = true;
                    break;
                }
                if (opcao == 1 || opcao == 2)
                {
                    Console.WriteLine("informe o tipo de operação");
                    Console.WriteLine("1-soma");
                    Console.WriteLine("2-subtração");
                    Console.WriteLine("3-multiplicação");
                    Console.WriteLine("4-divisão");

                    if (opcao == 2)
                    {
                        calculadoraCientifica = true;
                        Console.WriteLine("5-raiz quadrada");
                    }
                    else
                    {
                        calculadoraCientifica = false;
                    }

                    Console.WriteLine("0-voltar");

                    opcao = Convert.ToInt32(Console.ReadLine());


                    if (!calculadoraCientifica) //o ! no inicio significa que não é calculadoraCientifica
                    {

                        while (opcao < 0 || opcao > 5) //aqui entraria neste while se fosse menor q zero ou maior q 5, com a primeira condição ja entraria nest while pq não há numero menor q zero e maior q 5 
                        {
                           // while (opcao != 0 && opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4) //aqui o && é usado para checar cada uma das 5 opções
                        
                            Console.WriteLine("opção inválida, digite novamente");

                            opcao = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else
                    {
                        while (opcao != 0 && opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4 && opcao != 5)
                        {
                            Console.WriteLine("opção inválida, digite novamente");

                            opcao = Convert.ToInt32(Console.ReadLine());
                        }   
                    }
                }

                if (opcao != 0)
                {  

                    
                    

                    if (opcao == 5)
                    {
                        Console.WriteLine("informe o primeiro numero: ");
                        numA = Convert.ToDouble(Console.ReadLine());
                        numB = 1;

                    }
                    else
                    {
                        Console.WriteLine("informe o primeiro numero: ");
                        numA = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("informe o segundo numero: ");
                        numB = Convert.ToDouble(Console.ReadLine());
                    }
                    
                    switch(opcao)
                    {
                        case 1:
                            Console.WriteLine("resposta: " + Calculadora.soma(numA, numB));
                            break;

                        case 2:
                            Console.WriteLine("resposta: " + Calculadora.subtracao(numA, numB));
                            break;
                        case 3:
                            Console.WriteLine("resposta: " + Calculadora.multiplicacao(numA, numB));
                            break;
                        case 4:
                            Console.WriteLine("resposta: " + Calculadora.divisao(numA, numB));
                            break;
                        case 5:
                            Console.WriteLine("resposta: " + CalculadoraCientifica.raizquadrada(numA));
                            break;
                    }

                }
                Console.ReadKey();
            }
        }
    }
}