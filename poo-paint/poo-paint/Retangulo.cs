using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Retangulo : Figura
    {
        
        
        static int contador;

        
        public Retangulo(int x, int y, double largura, double altura)
        {
            this.x = x;
            this.y = y;
            this.largura=largura;
            this.altura = altura;
            contador = contador++;

        }

        public override string imprime()
        {
            return "retangulo[x" + this.x + ",y:" + this.y + ",l:" + this.largura + ",a:" + this.altura + "]";
        }

          public static void ZeraContador() {
            contador = 0;
        }

        public static int LeContador()
        {
            return contador;
        }

        //public override void Desenhar(Figura x, Figura y, Figura largura, Figura altura)
        //{

        //}
    }
}
