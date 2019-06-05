using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Strider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Botão analisa a imagem e conta quantos pixels vermelhos existem na mesma.
        private void Button1_Click(object sender, EventArgs e)
        {
            var contaPixels = 0;
            Bitmap imagem = new Bitmap(pictureBox1.Image);

            for (var x = 0; x < imagem.Width; x++)
            {
                for (var y = 0; y < imagem.Height; y++)
                {
                    Color corPixel = imagem.GetPixel(x, y);
                    var vermelho = corPixel.R == 255 && corPixel.G == 0 && corPixel.B == 0;

                    if (vermelho)
                    {
                        contaPixels++;
                    }

                }


            }

            //TextBox criado para exibir a quantidade dos pixels vermelhos encontrados na imagem.
            textBox1.Text = String.Format("Pixels vermelhos = {0}", contaPixels);

        }

    }
}
