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

        public void setMontaria(int montaria)
        {
            this.montaria = montaria;
        }

        public int getMontaria()
        {
            return montaria;
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
            float mediaGoldPersonagens, maiorValorDeGold, percentualDeJogadoresComGoldAté100;
            int mediaDoNúmeroDeMontarias;



            Personagem p = new Personagem(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            //p.setGold(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("valor de gold do personagem: " + p.getMontaria()); //aqui não deveria ser console.writeLine("informe a media de gold: "+p.getgold ou p.setgold)?


            Console.ReadKey();
        }
    }
}
