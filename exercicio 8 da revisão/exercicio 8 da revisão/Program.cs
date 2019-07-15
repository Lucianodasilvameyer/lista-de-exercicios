using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_8_da_revisão
{
    public class Personagem
    {
        protected string nome;
        protected int hp;// o protected é pq os filhos do personagen tambem teram as mesmas variaveis e funçôes?
        protected int forca;
        
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }

        public void tomarDano(int dano)
        {
            hp -= dano;
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
            Console.WriteLine( this.GetType() +  " força: " + forca + "hp: " + hp);
            
        }
        public void atacar(Personagem alvo)
        {
            alvo.tomarDano(forca);//o forca em parenteses representa o parametro int dano?
        }


    }
    public class Guerreiro:Personagem
    {
        public void aumentarForca()
        {
            hp -= 5;
            forca += 5;
        }

      
        
    }
    public class Inimigo : Personagem
    {
        public void atacarHeroi(Personagem alvo)
        {
            alvo.tomarDano((int)(hp*0.3));//aqui o int é para passar o 0.3 para int
        }

        public void roubarVida(Personagem alvo)
        {
            alvo.tomarDano((int)(hp * 0.1));
            hp += (int)(hp * 0.1);
        }

      
    }


    class Program
    {
        static void Main(string[] args)
        {
            bool saida = true;
            int opcao;
            bool SairDoPrograma = true;
            //int forca;
            //int hp;

            Guerreiro guerreiro = new Guerreiro();
            Inimigo inimigo = new Inimigo();

            while(saida!=false)
            {
                Personagem p = new Personagem();

                Console.WriteLine("escolha uma das opções abaixo:");
                Console.WriteLine("1-criar guerreiro");
                Console.WriteLine("2-criar inimigo");
                Console.WriteLine("3-sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                
                    while(opcao<1||opcao>3)
                    {
                       Console.WriteLine("opção invalida, digite novamente");
                       opcao = Convert.ToInt32(Console.ReadLine());
                    }

                
                int hp = 0;
                int forca = 0;

                if(opcao==3)
                {
                    saida = false;
                    break;
                }
                if(opcao==1||opcao==2)
                {
                    

                    Console.WriteLine("informe o hp: ");
                    hp = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("informe a força: ");
                    forca = Convert.ToInt32(Console.ReadLine());
                    

                }

                if(opcao == 1)
                {
                    guerreiro.setForca(forca);
                    guerreiro.setHp(hp);
                }
                else
                {
                    inimigo.setForca(forca);
                    inimigo.setHp(hp);
                }

                guerreiro.MostrarDados();
                inimigo.MostrarDados();
       
                while(SairDoPrograma!=false)
                {
                    Console.WriteLine("digite uma das opções a seguir:");
                    Console.WriteLine("1 - Guerreiro Atacar o Inimigo");
                    Console.WriteLine("2 - Inimigo Atacar o Guerreiro");
                    Console.WriteLine("3 - Guerreiro usar AumentarForca");
                    Console.WriteLine("4 - Inimigo usar RoubarVida");
                    Console.WriteLine("5 - Mostrar os dados do Guerreiro e Inimigo");
                    Console.WriteLine("6 - Resetar os valores do Guerreiro para os seus Iniciais");
                    Console.WriteLine("7 - Resetar os valores do Inimigo para os seus Iniciais");
                    Console.WriteLine("0 - Sair do Programa");
                    opcao = Convert.ToInt32(Console.ReadLine());





                            if (opcao==0)
                            {
                              SairDoPrograma=false;
                              break;
                            }
                            if(opcao==1)
                            {
                              guerreiro.atacar(inimigo);
                              break; 

                            }
                            if(opcao==2)
                            {
                              inimigo.atacar(guerreiro);
                              break;

                            }
                            if (opcao == 3)
                            {
                                 guerreiro.aumentarForca();
                                 break;
                            }
                            if(opcao==4)
                            {
                                 inimigo.roubarVida(guerreiro);
                            }
                            if(opcao==5)
                            {
                                 guerreiro.MostrarDados();
                                 inimigo.MostrarDados();
                            }
                            if(opcao==6)
                            {
                                 forca = 0;
                                 hp = 0;
                            }
                            if(opcao==7)
                            {
                                forca = 0;
                                hp = 0; 
                            }
                            while (opcao < 0 || opcao > 7)
                            {
                              Console.WriteLine("numero inexistente, digite novamente");
                              opcao = Convert.ToInt32(Console.ReadLine());
                            }


                }
                Console.ReadKey();



            }  
        }
    }
}
