using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_8_da_revisão
{
    public class personagem
    {
        private int hp;
        private int forca;

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
        public int MostrarDados(int hp,int forca)
        {
            this.hp = hp;
            this.forca = forca;
        }
        public int atacar()
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {



        }
    }
}
