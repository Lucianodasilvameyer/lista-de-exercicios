using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio_9_da_revisão
{
    public class Personagem
    {
        protected string nome = "";
        protected int id = 0;
        protected int hp = 0;
        protected int forca = 0;

        public void tomarDanoDaBolaDeFogo()
        {
            hp -= 20;
        }

        public void tomarDano(int dano)
        {
            hp -= dano;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
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

        public void MostrarDados()
        {
            Console.WriteLine( "Nome: " + nome + "Classe" + this.GetType().Name + " força: " + forca + "hp: " + hp);
        }

        public void atacar(Personagem alvo)
        {
            alvo.tomarDano(forca);//o forca em parenteses representa o parametro int dano?
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

            public void setMp(int mp)
            {
                this.mp = mp;
            }

            public int getMp()
            {
                return mp;
            }

            public void bolaDefogo(Personagem alvo)
            {
                alvo.tomarDanoDaBolaDeFogo();
                mp -= 5;
            }
        }

        public class Inimigo : Personagem
        {
            public void atacarHeroi(Personagem alvo)
            {
                alvo.tomarDano((int)(hp * 0.3));//aqui o int é para passar o 0.3 para int
            }

            public void roubarVida(Personagem alvo)
            {
                alvo.tomarDano((int)(hp * 0.1));
                hp += (int)(hp * 0.1);
            }
        }

        private class Program
        {
            private static void Main(string[] args)
            {
                bool saida = true;
                int opcao;
                string classe = "";

                //int forca;
                //int hp;

                Guerreiro guerreiro = new Guerreiro(); //o Guerreiro com G maiusculo é da classe Guerreiro? e esta passando as informações da classe Guerreiro para a instancia guerreiro?
                Inimigo inimigo = new Inimigo();
                Mago mago = new Mago();

                Personagem atacante = new Personagem(), alvo = new Personagem();
                List<Personagem> listaDePersonagens = new List<Personagem>();

                while (saida != false)
                {
                    Personagem p = new Personagem();

                    Console.WriteLine("escolha uma das opções abaxo:");

                    Console.WriteLine("1-cadastrar personagem");

                    Console.WriteLine("2-Escolher Atacante por Nome");
                    Console.WriteLine("3-Escolher Atacante por ID");
                    Console.WriteLine("4-Escolher Alvo por Nome");
                    Console.WriteLine("5 -Escolher Alvo por ID");
                    Console.WriteLine("6 - Mostrar os dados do Alvo e Atacante Escolhidos no momento");
                    Console.WriteLine("7 - Mostrar submenu com opções de Ações do Atacante (Atacar, BolaDeFogo, RoubarVida, etc");
                    Console.WriteLine("8 - Resetar os valores do Atacante para os seus Iniciais");
                    Console.WriteLine("9 - Resetar os valores do Alvo para os seus Iniciais");
                    Console.WriteLine("10- Resetar os valores de todos os personagens não-Inimigos para o seu valor inicial");
                    Console.WriteLine("11-Resetar os valores de todos os personagens Inimigos para o seu valor inicial");
                    Console.WriteLine("12-Mostrar os dados de todos os Personagens Cadastrados");
                    Console.WriteLine("13-Sair do Programa");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    while (opcao < 1 || opcao > 13)
                    {
                        Console.WriteLine("opção invalida, digite novamente");
                        opcao = Convert.ToInt32(Console.ReadLine());
                    }

                    int hp = 0;
                    int forca = 0;
                    int mp = 0;
                    string nome ="";
                    int id = 0;

                    if (opcao == 13)
                    {
                        saida = false;
                        break;
                    }

                    if (opcao == 1)
                    {
                        Console.WriteLine("a-guerreiro");
                        Console.WriteLine("b-mago");
                        Console.WriteLine("c-inimigo");
                        classe = Console.ReadLine();
                        if (classe == "a" || classe == "b" || classe == "c")
                        {
                            Console.WriteLine("informe o nome do personagem: ");
                            nome = Console.ReadLine();

                            Console.WriteLine("informe o hp: ");
                            hp = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("informe a força: ");
                            forca = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("informe o id: ");
                            id = Convert.ToInt32(Console.ReadLine());
                        }

                        if (classe == "a")
                        {
                            guerreiro.setForca(forca); //aqui é onde se passa os atributos para a instancia q tem todas as informações da classe?
                            guerreiro.setHp(hp);
                            guerreiro.setNome(nome);
                            guerreiro.setId(id);

                            listaDePersonagens.Add(guerreiro);
                        }
                        if (classe == "c")
                        {
                            inimigo.setForca(forca);
                            inimigo.setHp(hp);
                            inimigo.setNome(nome);
                            inimigo.setId(id);


                            listaDePersonagens.Add(inimigo);
                        }
                        if (classe == "b")
                        {
                            Console.WriteLine("informe o mp: ");
                            mp = Convert.ToInt32(Console.ReadLine());

                            

                            mago.setForca(forca);
                            mago.setHp(hp);
                            mago.setMp(mp);
                            mago.setNome(nome);
                            mago.setId(id);


                            listaDePersonagens.Add(mago);
                        }
                    }
                    if (opcao == 2)
                    {
                        string nome1;
                        Console.WriteLine("informe o nome do atacante: ");
                        nome1 = Console.ReadLine();
                        
                        if (listaDePersonagens.Any(x=> x.getNome() == nome1))
                        {
                            atacante = listaDePersonagens.Find(x => x.getNome() == nome1);
                        }
                        else
                        {
                            Console.WriteLine(nome1 + " não encontrado!");
                        }


                    }

                    if (opcao == 4)
                    {
                        string nome1;
                        Console.WriteLine("informe o nome do alvo: ");
                        nome1 = Console.ReadLine();

                        if (listaDePersonagens.Any(x => x.getNome() == nome1))
                        {
                            alvo = listaDePersonagens.Find(x => x.getNome() == nome1);
                        }
                        else
                        {
                            Console.WriteLine(nome1 + " não encontrado!");
                        }



                    }


                    if (opcao == 6)
                    {
                        atacante.MostrarDados();
                        alvo.MostrarDados();



                    }


                }


                Console.ReadKey();
            }
            

        }
    }
}