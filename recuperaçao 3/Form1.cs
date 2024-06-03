using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recuperaçao_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcularCirculo_Click(object sender, EventArgs e)
        {
           double diametro = Convert.ToDouble(txtDiametro.Text);
            double raio = diametro / 2;
            double area = 3.14 * (raio * raio);
            
            if (rbCirculo.Checked)
            {
                MessageBox.Show("a area do circulo é de: " + area);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnCalcularTriangulo_Click(object sender, EventArgs e)
        {
            double lado1 = Convert.ToDouble(txtLado1.Text);
            double lado2 = Convert.ToDouble(txtLado2.Text); 
            double lado3 = Convert.ToDouble(txtLado3.Text);
            double resultado = lado1 + lado2 + lado3;

            if (rbTriangulo.Checked)
            {
                MessageBox.Show("o perimetro é: " + resultado);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnCalcularQuadrilatero_Click(object sender, EventArgs e)
        {
            double lado1 = Convert.ToDouble(txtLado1Quadri.Text);
            double lado2 = Convert.ToDouble(txtLado2Quadri.Text);
            double lado3 = Convert.ToDouble(txtLado3Quadri.Text);
            double lado4 = Convert.ToDouble(txtLado4Quadri.Text);
            double resultado = lado1 + lado2 + lado3 + lado4;

            if (rbQuadrilatero.Checked && lado1 < 1 || lado2 < 1 || lado3 < 1 || lado4 < 1)
            {
                MessageBox.Show("insiria um valor valido");
            }
            else if (rbQuadrilatero.Checked)
            {
                MessageBox.Show("o resultado é: " + resultado);
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (rbQuadrilatero.Checked)
            {
                
            }
            
        }
    }
}
