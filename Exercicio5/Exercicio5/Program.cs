using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Personagem
    {
        private int level;
        private string corDosolhos;
        private string sexo;
        private string corDocabelo;

        public void setLevel(int level)
        {
            this.level = level;
        }
        public int getLevel()
        {
            return level;
        }
        public void setCordosolhos(string corDosolhos)
        {
            this.corDosolhos = corDosolhos;
        }
        public string getCordosolhos()
        {
            return corDosolhos;
        }
        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public string getSexo()
        {
            return sexo;
        }
        public void setCordocabelo(string corDocabelo)
        {
            this.corDocabelo = corDocabelo;
        }
        public string getCordocabelo()
        {
            return corDocabelo;
        }
        public Personagem(int level, string corDosolhos, string sexo, string corDocabelo)
        {
            this.level = level;
            this.corDosolhos = corDosolhos;
            this.sexo = sexo;
            this.corDocabelo = corDocabelo;
        }
        public Personagem()
        {

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int levelmain = 0;




            List<Personagem> listadepersonagens = new List<Personagem>();

            while (levelmain != -1)
            {
                Personagem p = new Personagem();

                Console.WriteLine("digite o level: ");
                p.setLevel(Convert.ToInt32(Console.ReadLine()));
                levelmain = p.getLevel();
                if (levelmain == -1) break;

                Console.WriteLine("digite o sexo: ");
                p.setSexo(Console.ReadLine());

                Console.WriteLine("digite a cor dos olhos do personagem: ");
                p.setCordosolhos(Console.ReadLine());

                Console.WriteLine("digite a cor do cabelo do personagem: ");
                p.setCordocabelo(Console.ReadLine());

                

                listadepersonagens.Add(p);

            }
            List<int> maiorLevel = listadepersonagens.Select(x => x.getLevel()).ToList();//como quer checar só uma coisa se usa o Select?


            List<Personagem> personagensFemininos = listadepersonagens.FindAll(x => x.getLevel() <= 35 && x.getLevel() >= 18 && x.getCordosolhos() == "verde" && x.getCordocabelo() == "louros");


            List<Personagem> personagensEmGeral = listadepersonagens.FindAll(x => x.getCordosolhos() != "azuis" && x.getCordocabelo() != "loiros");

            maiorLevel.Sort();

            if(maiorLevel.Any())
            Console.WriteLine("o maior level é: " + maiorLevel.Last());
            Console.WriteLine("o percentual de personagens que não possuem olhos Azuis e nem cabelos Loiros é: " + (personagensEmGeral.Count) / (listadepersonagens.Count) * 100);

            Console.ReadKey();

        }
    }
}
