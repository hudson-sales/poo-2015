using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Circulo : Figura
    {
    
        public Circulo(int x, int y, double raio)
        {
            this.x = x;
            this.y = y;
            this.raio = raio;

        }
        public override string imprime()
        {
            return "circulo[x"+this.x+",y:"+this+y+",raio:"+this.raio+"]";
        }

        //public override void Desenhar(Figura x, Figura y, Figura raio)
        //{

        //}

    }
}
