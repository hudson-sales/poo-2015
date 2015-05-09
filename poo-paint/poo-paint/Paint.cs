using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    public class Paint
    {
        public static void Main(String[] args)
        {
            Application.Run(new AreaDeDesenho());
            //AreaDeDesenho area = new AreaDeDesenho();
            //area.AdicionarFigura(new Retangulo(3, 4, 20, 50));
            //area.AdicionarFigura(new Circulo(150, 45, 20));
            //Application.Run(area);
        }
    }
}
