using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    public partial class AreaDeDesenho : Form
    {
        //Figura[] figuras; 
        

        public AreaDeDesenho()
        {
            InitializeComponent();
        }

        private void Desenhar(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.DrawRectangle(Pens.Black, 4, 4, 100, 40);
            //for (int i = 0; i < this.figuras.Length; i++)
            //{
            //    Figura f = this.figuras[i];
            //    f.Desenhar(g);
            //}
        }

        //public void AdicionarFigura (Figura f)
        //{
        //    figuras = new Figura[10];   
         
        //}
    }
}
