using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4_da_revisão
{
    public class atributos
    {
        private int hp;
        private int forca;
        private int defesa;

        public void setHp(int hp)
        {
            this.hp = hp;
        }
        public int getHp()
        {
            return hp;
        }
        public void setForca(int forca)
        {
            this.forca = forca;
        }
        public int getForca()
        {
            return forca;
        }
        public void setDefesa(int defesa)
        {
            this.defesa = defesa;
        }
        public int getDefesa()
        {
            return defesa;
        }
        public atributos(int hp, int forca,int defesa)
        {
            this.hp = hp;
            this.forca = forca;
            this.defesa = defesa;

        }


        static void Main(string[] args)
        {
            int hp = 1, listaInimigoMulher=0;

            List<atributos> listaPersonagem = new List<atributos>();

            List<atributos> listaInimigoMulher = new List<atributos>();

            List<atributos> ListaInimigoHomen = new List<atributos>();


            while (hp > 0)
            {
                atributos s = new atributos;

                Console.WriteLine("digite o hp: ");
                s.setHp(Convert.ToInt32(Console.ReadLine()));

                listaPersonagem.Add(s);

                Console.WriteLine("digite a forca: ");
                s.setForca(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("digite a defesa: ");
                s.setDefesa(Convert.ToInt32(Console.ReadLine()));

                listaInimigoMulher.Add(s);

                ListaInimigoHomen.Add(s);


            }
            List<int> hps = listaPersonagem.Select(x => x.getHp()).ToList();
            List<int> mulheres = listaInimigoMulher.FindAll(x => x.getForca() <= 50);
            List<int> homens = ListaInimigoHomen.FindAll(x => x.getForca() > 35 && getDefesa() > 35);

            Console.WriteLine("o media de hp do grupo é: " + hps.Average());
            Console.WriteLine("o maior hp do grupo é: " + hps.Last());
            Console.WriteLine("o menor hp do grupo é: " + hps.First());
            Console.WriteLine("a quantidade de mulheres com força menor ou igual a 50 é: " + mulheres);
            Console.WriteLine("a quantidade de homens com força e defesa maiores que 35 é: " + homens);

            Console.ReadKey();
        }
    }
}
