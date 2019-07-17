using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int HpInicial { set; get; }//se usar dessa forma não é necessaio nem declarar a variavel antes? 





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
            Console.WriteLine("nome: " + nome + "classe" + this.GetType().Name + "força: " + forca + "hp: " + hp + "mp: " + mp);
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


    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            int opcao = 0;
            string classe = "";

            Guerreiro guerreiro = new Guerreiro();
            Mago mago = new Mago();
            Inimigo inimigo = new Inimigo();
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
                    int numero = 0;

                    Console.WriteLine("escolha qual personagem quer que ataque: ");
                    Console.WriteLine("1-guerreiro");
                    Console.WriteLine("2-mago");
                    Console.WriteLine("3-inimigo");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero == 1)
                    {
                        char letra;

                        Console.WriteLine("escolha uma das seguintes ações: ");
                        Console.WriteLine("A-atacar");
                        Console.WriteLine("B-usar aumentar força");
                        letra = Convert.ToChar(Console.ReadLine());
                    }
                    if (numero == 2)
                    {
                        char letra2;

                        Console.WriteLine("escolha uma das seguintes ações: ");
                        Console.WriteLine("A-atacar");
                        Console.WriteLine("B-usar bola de fogo");
                        letra2 = Convert.ToChar(Console.ReadLine());
                    }
                    if (numero == 3)
                    {
                        char letra3;

                        Console.WriteLine("escolha uma das seguintes ações: ");
                        Console.WriteLine("A-atacar");
                        Console.WriteLine("B-usar roubar vida");
                        letra3 = Convert.ToChar(Console.ReadLine());
                    }

                }
                if (opcao == 8)
                {
                    string nome4;

                    Console.WriteLine("informe o nome do atacante: ");
                    nome4 = Console.ReadLine();

                    if (ListaDePersonagens.Any(x => x.getNome() == nome4))
                    {
                        atacante = ListaDePersonagens.Find(x => x.getNome() == nome4);

                        atacante.resetarValores();
                    }
                    else
                    {
                        Console.WriteLine(nome4 + "não encontrado");
                    }
                }
                if (opcao == 9)
                {
                    string nome5;

                    Console.WriteLine("informe o nome do alvo: ");
                    nome5 = Console.ReadLine();

                    if (ListaDePersonagens.Any(x => x.getNome() == nome5))
                    {
                        alvo = ListaDePersonagens.Find(x => x.getNome() == nome5);


                        alvo.resetarValores();
                    }
                    else
                    {
                        Console.WriteLine(nome5 + "não encontrado");
                    }

                }
                if (opcao == 10)
                {

                    String nomes;
                    Console.WriteLine("informe os nomes de todos os personagens que não sejam inimigos: ");
                    nomes = Console.ReadLine();

                    if (ListaDePersonagens.Any(x => x.getNome() == nomes))
                    {
                        PersonagemN = ListaDePersonagens.FindAll(x => x.getNome() == nomes);


                    }
                    else
                    {
                        Console.WriteLine(nomes + "não encontrados");
                    }
                }
                if (opcao == 11)
                {
                    string nomes2;
                    Console.WriteLine("informe os nomes de todos os inimigos: ");
                    nomes2 = Console.ReadLine();

                    if (ListaDePersonagens.Any(x => x.getNome() == nomes2))
                    {
                        inimigos = ListaDePersonagens.FindAll(x => x.getNome() == nomes2);

                        inimigos.resetarValores();
                    }
                    else
                    {
                        Console.WriteLine(nomes2 + "não encontrados");
                    }
                }
                if (opcao == 12)
                {
                    string nomes3;
                    Console.WriteLine("informe os nomes de todos os personagens cadastrado: ");
                    nomes3 = Console.ReadLine();

                    if (ListaDePersonagens.Any(x => x.getNome() == nomes3)
                        {
                        PersonagensCadastrados = ListaDePersonagens.FindAll(x => x.getNome() == nomes3);

                        PersonagensCadastrados.MostrarDados();
                    }
                    else
                    {
                        Console.WriteLine(nomes3 + "não encontrados");
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
