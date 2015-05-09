using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Figura
    {
        public int x, y;
        public double largura, altura, raio;

        public virtual string imprime()
        {
            return "";
        }

        public virtual void Desenhar(Graphics g)
        {

        }
    }
}
