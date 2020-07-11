using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormasGeomatricas_FocoNoUsoDoPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.Altura = 50;
            retangulo.Largura = 100;
            retangulo.Desenhar();
            retangulo.Apresentar();
            retangulo.desenharOutro();

            Triangulo triangulo = new Triangulo();
            triangulo.Altura = 150;
            triangulo.Largura = 200;
            triangulo.Desenhar();
            triangulo.Apresentar();
            triangulo.desenharOutro();

            Circunferencia circunferencia = new Circunferencia();
            circunferencia.Altura = 250;
            circunferencia.Largura = 400;
            circunferencia.Desenhar();
            circunferencia.Apresentar();
            circunferencia.desenharOutro();
        }
    }
}

