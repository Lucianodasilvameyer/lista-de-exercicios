using System;
using System.Collections.Generic;
using System.Linq;

namespace treino_no_exercicio_9_da_revisão
{
    public class Personagem
    {
        //protected string nome="";
        protected int hp = 0;

        protected int forca = 0;
        protected int id = 0;
        //protected int mpInicial = 0;

        public string nome { get; set; }
        public int mpInicial { get; set; }
        public int ForcaInicial { get; set; }
        public int HpInicial { set; get; }//se usar dessa forma não é necessario  declarar a variavel antes? sim

        //public string nome { set; get; }??

        //public int hp { get; set; }??

        //public string forca()
        //{
        //  get
        //{
        //  return forca;
        //}
        // set
        //{
        //if(forca>=10)
        //{
        //  }

        //    else

        //  }

        //}

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

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

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public virtual void resetarValores()
        {
            hp = HpInicial;
            forca = ForcaInicial;
        }

        public void tomarDanoDeBolaDeFogo()
        {
            hp -= 20;
        }

        public void TomarDano(int dano)
        {
            hp -= dano;
        }

        public virtual void MostrarDados()
        {
            Console.WriteLine("nome: " + nome + "classe" + this.GetType().Name + "força: " + forca + "hp: " + hp);
        }

        public void atacar(Personagem alvo)
        {
            alvo.TomarDano(forca);
        }
    }

    public class Guerreiro : Personagem
    {
        public void aumentarForca()
        {
            hp -= 5;
            forca += 5;
        }
    }

    public class Mago : Personagem
    {
        private int mp;

        // public int mp { get; set; } ?

        public override void MostrarDados()
        {
            Console.WriteLine("nome: " + nome + " classe" + this.GetType().Name + " | força: " + forca + "hp: " + hp + "mp: " + mp);
        }

        public void setMp(int mp)
        {
            this.mp = mp;
        }

        public int getMp()
        {
            return mp;
        }

        public void BolaDeFogo(Personagem alvo)
        {
            alvo.tomarDanoDeBolaDeFogo();
            mp -= 5;
        }

        public override void resetarValores()
        {
            base.resetarValores();
            mp = mpInicial;
        }
    }

    public class Inimigo : Personagem
    {
        public void atacarheroi(Personagem alvo)
        {
            alvo.TomarDano((int)(hp * 0.3));
        }

        public void roubarVida(Personagem alvo)
        {
            alvo.TomarDano((int)(hp * 0.1));
            hp += (int)(hp * 0.1);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            bool sair = false;
            int opcao = 0;
            string classe = "";

            Personagem atacante = new Personagem();
            Personagem alvo = new Personagem();
            Personagem PersonagemN = new Personagem();
            Personagem inimigos = new Personagem();
            Personagem PersonagensCadastrados = new Personagem();

            List<Personagem> ListaDePersonagens = new List<Personagem>();

            while (sair != true)
            {
                Console.WriteLine("escolha uma das seguintes opções: ");
                Console.WriteLine("1 - Cadastrar Personagem");
                Console.WriteLine("2 - Escolher Atacante por Nome");
                Console.WriteLine("3 - Escolher Atacante por ID");
                Console.WriteLine("4 - Escolher Alvo por Nome");
                Console.WriteLine("5 - Escolher Alvo por ID");
                Console.WriteLine("6 - Mostrar os dados do Alvo e Atacante Escolhidos no momento");
                Console.WriteLine("7 - Mostrar submenu com opções de Ações do Atacante (Atacar, BolaDeFogo, RoubarVida, etc)");
                Console.WriteLine("8 - Resetar os valores do Atacante para os seus Iniciais");
                Console.WriteLine("9 - Resetar os valores do Alvo para os seus Iniciais");
                Console.WriteLine("10 - Resetar os valores de todos os personagens não-Inimigos para o seu valor inicial");
                Console.WriteLine("11 - Resetar os valores de todos os personagens Inimigos para o seu valor inicial");
                Console.WriteLine("12 - Mostrar os dados de todos os Personagens Cadastrados");
                Console.WriteLine("13 - Sair do Programa");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao < 1 || opcao > 13)
                {
                    Console.WriteLine("opção não encontrada, digite novamente");
                    opcao = Convert.ToInt32(Console.ReadLine());
                }

                string nome = "";
                int hp = 0;
                int forca = 0;
                int HpInicial = 0;
                int ForcaInicial = 0; //é preciso declarar hp inicial,força inicial e mp inicial aqui e no começo do exercicio?
                int mp = 0;
                int mpInicial = 0;
                int id = 0;

                if (opcao == 1)
                {
                    Console.WriteLine("escolha a classe: ");
                    Console.WriteLine("a-guerreiro");
                    Console.WriteLine("b-mago");
                    Console.WriteLine("c-inimigo");
                    classe = Console.ReadLine();

                    if (classe == "a" || classe == "b" || classe == "c")
                    {
                        Console.WriteLine("informe o nome do personagem: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("informe o hp do personagem: ");
                        hp = Convert.ToInt32(Console.ReadLine());
                        HpInicial = hp;

                        Console.WriteLine("informe a força do personagem: ");
                        forca = Convert.ToInt32(Console.ReadLine());
                        ForcaInicial = forca;

                        if (classe == "a")
                        {
                            Guerreiro guerreiro = new Guerreiro();
                            guerreiro.setNome(nome);
                            guerreiro.setHp(hp);
                            guerreiro.setForca(forca);
                            guerreiro.HpInicial = HpInicial;
                            guerreiro.ForcaInicial = ForcaInicial;

                            ListaDePersonagens.Add(guerreiro);

                            id++;// posso colocar o id q se modfica a a cada cadastro aqui?
                        }
                        if (classe == "b")
                        {
                            Console.WriteLine("informe o mp do personagem: ");
                            mp = Convert.ToInt32(Console.ReadLine());
                            mpInicial = mp;

                            Mago mago = new Mago();
                            mago.setNome(nome);
                            mago.setHp(hp);
                            mago.setForca(forca);
                            mago.HpInicial = HpInicial;
                            mago.ForcaInicial = ForcaInicial;
                            mago.mpInicial = mpInicial;

                            ListaDePersonagens.Add(mago);

                            id++;
                        }
                        if (classe == "c")
                        {
                            Inimigo inimigo = new Inimigo();
                            inimigo.setNome(nome);
                            inimigo.setHp(hp);
                            inimigo.setForca(forca);
                            inimigo.HpInicial = HpInicial;
                            inimigo.ForcaInicial = ForcaInicial;

                            ListaDePersonagens.Add(inimigo);

                            id++;
                        }
                    }
                }
                if (opcao == 2)
                {
                    string nome1;
                    Console.WriteLine("informe o nome do atacante: ");
                    nome1 = Console.ReadLine();

                    if (ListaDePersonagens.Any(x => x.getNome() == nome1))
                    {
                        atacante = ListaDePersonagens.Find(x => x.getNome() == nome1);
                    }
                    else
                    {
                        Console.WriteLine(nome1 + "não encontrado");
                    }
                }
                if (opcao == 3)
                {
                    int id1 = 0;
                    Console.WriteLine("informe o id do atacante: ");
                    id1 = Convert.ToInt32(Console.ReadLine());

                    if (ListaDePersonagens.Any(x => x.getId() == id1))
                    {
                        atacante = ListaDePersonagens.Find(x => x.getId() == id1);
                    }
                    else
                    {
                        Console.WriteLine(id1 + "não encontrado");
                    }
                }
                if (opcao == 4)
                {
                    string nome2;
                    Console.WriteLine("informe o nome do alvo: ");
                    nome2 = Console.ReadLine();

                    if (ListaDePersonagens.Any(x => x.getNome() == nome2))
                    {
                        alvo = ListaDePersonagens.Find(x => x.getNome() == nome2);
                    }
                    else
                    {
                        Console.WriteLine(nome2 + "não encontrado");
                    }
                }
                if (opcao == 5)
                {
                    int id2 = 0;
                    Console.WriteLine("informe o id do alvo: ");
                    id = Convert.ToInt32(Console.ReadLine());

                    if (ListaDePersonagens.Any(x => x.getId() == id))
                    {
                        alvo = ListaDePersonagens.Find(x => x.getId() == id);
                    }
                    else
                    {
                        Console.WriteLine(id2 + "não encontrado");
                    }
                }
                if (opcao == 6)
                {
                    alvo.MostrarDados();
                    atacante.MostrarDados();
                }
                if (opcao == 7)
                {
                    

                  

                    if (atacante.GetType() == typeof(Guerreiro))
                    {
                        char letra;

                        Console.WriteLine("escolha uma das seguintes ações: ");
                        Console.WriteLine("A-atacar");
                        Console.WriteLine("B-usar aumentar força");
                        letra = Convert.ToChar(Console.ReadLine());

                        if(letra == 'A' || letra == 'a')
                        {
                            atacante.atacar(alvo);
                        }
                        else if(letra == 'B' || letra == 'b')
                        {

                            Guerreiro g = (Guerreiro)atacante;
                            g.aumentarForca();

                        }
                    }
                    if (atacante.GetType() == typeof(Mago))
                    {
                        char letra2;

                        Console.WriteLine("escolha uma das seguintes ações: ");
                        Console.WriteLine("A-atacar");
                        Console.WriteLine("B-usar bola de fogo");
                        letra2 = Convert.ToChar(Console.ReadLine());

                        if (letra2 == 'A' || letra2 == 'a')
                        {
                            atacante.atacar(alvo);
                        }
                        else if (letra2 == 'B' || letra2 == 'b')
                        {

                            Mago g = (Mago)atacante;//aqui passa a variavel atacante do tipo personagem para o tipo mago? 
                            g.BolaDeFogo(alvo);

                        }
                    }
                    if (atacante.GetType() == typeof(Inimigo))
                    {
                        char letra3;

                        Console.WriteLine("escolha uma das seguintes ações: ");
                        Console.WriteLine("A-atacar");
                        Console.WriteLine("B-usar roubar vida");
                        letra3 = Convert.ToChar(Console.ReadLine());

                        if (letra3 == 'A' || letra3 == 'a')
                        {
                            atacante.atacar(alvo);
                        }
                        else if (letra3 == 'B' || letra3 == 'b')
                        {

                            Inimigo g = (Inimigo)atacante;
                            g.roubarVida(alvo);

                        }
                    }

                    Console.WriteLine("-----------------------");
                    alvo.MostrarDados();
                    atacante.MostrarDados();
                    Console.WriteLine("-----------------------");
                }
                if (opcao == 8)
                {
                    atacante.resetarValores();
                }
                if (opcao == 9)
                {
                    alvo.resetarValores();
                }
                if (opcao == 10)
                {
                    if (ListaDePersonagens.Any(x => x.GetType() != typeof(Inimigo)))
                    {
                        List<Personagem> naoInimigos = ListaDePersonagens.FindAll(x => x.GetType() != typeof(Inimigo));
                        for (int i = 0; i < naoInimigos.Count; i++)
                        {
                            naoInimigos[i].resetarValores();
                        }
                    }
                    else
                    {
                        Console.WriteLine("não-inimigos não encontrados");
                    }
                }
                if (opcao == 11)
                {
                    if(ListaDePersonagens.Any(x=>x.GetType()==typeof(Inimigo)))
                    {
                        List<Personagem> inimigosN = ListaDePersonagens.FindAll(x => x.GetType() == typeof(Inimigo));

                        for(int i=0; i< inimigosN.Count;i++)
                        {
                            inimigosN[i].resetarValores();
                        }
                    }                       
                    
                    else
                    {
                        Console.WriteLine("inimigos não encontrados");
                    }
                }
                if (opcao == 12)
                {
                    if(ListaDePersonagens.Any())
                    {
                        for(int i=0; i<ListaDePersonagens.Count; i++)
                        {
                            ListaDePersonagens[i].MostrarDados();
                        }
                    }
                    else
                    {
                        Console.WriteLine("personagens não encontrados");
                    }


                }
                if (opcao == 13)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}