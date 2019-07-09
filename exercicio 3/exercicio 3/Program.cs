using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    internal class Personagem
    {
        private int gold;
        private int montaria;
        

        public void setGold(int gold)
        {
            this.gold = gold;
        }

        public int getGold()
        {
            return gold;
        }

        public void TesteVoid()
        {
            Console.WriteLine("A soma do gold e da montaria são:" + (gold + montaria));
        }
        public void setMontaria(int montaria)
        {
            this.montaria = montaria;
        }

        public void setGoldEMontaria(int gold, int montaria)
        {
            this.gold = gold;//o this.gold se refere ao gold da classe e gold depois do sinal de igual é o valor do parametro
            this.montaria = montaria;
        }

        public int getMontaria()
        {
            return montaria;
        }

        public bool Tem100Recursos()
        {
            return (gold >= 100 && montaria >= 100);
        }

        public int mediaDosRecursos()
        {
            return (gold + montaria) / 2;
        }


        public Personagem()
        {
            gold = 0;
            montaria = 0;
        }

        public Personagem(int gold, int montaria)
        {
            this.gold = gold;
            this.montaria = montaria;
        }

    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            float mediaGoldPersonagens=0, maiorValorDeGold, percentualDeJogadoresComGoldAté100, gold=1;
            int mediaDoNúmeroDeMontarias;


            List<Personagem> listaDePersonagem = new List<Personagem>();

            // Personagem p = new Personagem(20, 0);//aqui é passado 20 e 0 como parametros

            while (gold > 0)
            {
                Personagem p = new Personagem();

                Console.WriteLine("Digite o valor de gold: ");
                p.setGold(Convert.ToInt32(Console.ReadLine()));
                gold = p.getGold();

                int teste = p.getGold();
                p.setGold(50);

                if (gold < 0) break;

                Console.WriteLine("Digite a quantidade de montarias: ");
                p.setMontaria(Convert.ToInt32(Console.ReadLine()));

                p.TesteVoid();
                listaDePersonagem.Add(p);

                
            }


            List<int> golds = listaDePersonagem.Select(x => x.getGold()).ToList();//ToList converte para lista e faz uma copia para não mecher na lista de personagens
            List<int> montarias = listaDePersonagem.Select(x => x.getMontaria()).ToList();// o Select é para selecionar só os getMontaria

            golds.Sort();

            
            Console.WriteLine("a media de gold dos personagens é: " + golds.Average());
            Console.WriteLine("a media do numero de montarias é: " + montarias.Average());
            Console.WriteLine("o maior valor do gold é: " + golds.Last());
            Console.WriteLine("o percentual de personagens com gold até 100 é: " + (double)listaDePersonagem.FindAll(x => x.getGold() <= 100).Count / (double)listaDePersonagem.Count * 100 + "%"); 
            Console.ReadKey();
        }
    }
}
//percentualDePersonagensComGoldAte100 / listaDePersonagem.Count* 100 + "%"); //aqui para achar o percentual de jogadores com gold até 100 se usa percentualDePersonagensComGoldAte100 / quantidadeDePersonagens *100