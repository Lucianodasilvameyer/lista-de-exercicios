using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    public class Inimigo
    {
        private int hp;
        private int forca;
        private int defesa;
        private bool homem;

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
        public void setHomem(bool homem)
        {
            this.homem = homem;
        }
        public bool getHomem()
        {
            return homem;
        }
        
        public Inimigo(int hp, int forca, int defesa)
        {
            this.hp = hp;
            this.forca = forca;
            this.defesa = defesa;

        }
        public Inimigo()
        {


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 1;

            List<Inimigo> listaPersonagem = new List<Inimigo>();



            while (hp > 0)
            {
                Inimigo s = new Inimigo();


                Console.WriteLine("digite o hp: ");
                s.setHp(Convert.ToInt32(Console.ReadLine()));

                hp = s.getHp();
                if (hp < 0) break;

                Console.WriteLine("digite o sexo(M/F): ");

                s.setHomem((Console.ReadLine() == "M"));

                /* EXEMPLO
                bool teste = hp == 50;

                if (hp == 50)
                {
                    teste = true;
                }
                else teste = false;
                */

                Console.WriteLine("digite a forca: ");
                s.setForca(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("digite a defesa: ");
                s.setDefesa(Convert.ToInt32(Console.ReadLine()));

                listaPersonagem.Add(s);


            }
            List<int> hps = listaPersonagem.Select(x => x.getHp()).ToList();
            List<Inimigo> mulheres = listaPersonagem.FindAll(x => x.getForca() <= 50 && x.getHomem() == false);
            List<Inimigo> homens = listaPersonagem.FindAll(x => x.getForca() > 35 && x.getDefesa() > 35 && x.getHomem() == true);

            Console.WriteLine("o media de hp do grupo é: " + hps.Average());

            hps.Sort();// aqui é uma função q ordena do menor ao maior
            Console.WriteLine("o maior hp do grupo é: " + hps.Last());
            Console.WriteLine("o menor hp do grupo é: " + hps.First());
            Console.WriteLine("a quantidade de mulheres com força menor ou igual a 50 é: " + mulheres.Count);
            Console.WriteLine("a quantidade de homens com força e defesa maiores que 35 é: " + homens.Count);

            Console.ReadKey();
        }
    }
}

