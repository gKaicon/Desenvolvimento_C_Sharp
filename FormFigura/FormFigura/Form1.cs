using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormFigura
{
    public partial class Form1 : Form
    {
        int itemSelecionado = 0;
        string messagemA = "";
        string messagemP = "";

        Retangulo r = new Retangulo();
        Circulo c = new Circulo();
        Triangulo t = new Triangulo();

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = itemSelecionado;
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            groupBox1.Text = comboBox1.SelectedItem.ToString();
            itemSelecionado = comboBox1.SelectedIndex;
            if (itemSelecionado == 0)
            {
                //retângulo
                label1.Text = "Base: ";
                label2.Text = "Altura: ";
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            else if (itemSelecionado == 1)
            {
                //circulo
                label1.Text = "Raio: ";
                label2.Visible = false;
                textBox2.Visible = false;
            }
            else if (itemSelecionado == 2)
            {
                //triângulo
                label1.Text = "Base: ";
                label2.Text = "Altura: ";
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
        }

        public void getDados()
        {
            if (itemSelecionado == 0)
            {
                //retangulo
                r.BaseR = Convert.ToDouble(textBox1.Text);
                r.Altura = Convert.ToDouble(textBox2.Text);
            }
            else if (itemSelecionado == 1)
            {
                //circulo
                c.R = Convert.ToDouble(textBox1.Text);
            }

            else if (itemSelecionado == 2)
            {
                //triangulo
                t.BaseT = Convert.ToDouble(textBox1.Text);
                t.Altura = Convert.ToDouble(textBox2.Text);
            }
        }

        private void buttonCalcP_Click(object sender, EventArgs e)
        {
            getDados();
            
            if (itemSelecionado == 0)
            {
                //retangulo
                messagemP = r.calcPerimetro();
            }
            else if (itemSelecionado == 1)
            {
                //circulo
                messagemP = c.calcPerimetro();
            }

            else if (itemSelecionado == 2)
            {
                //triangulo
                messagemP = t.calcPerimetro();
            }
            MessageBox.Show(messagemP);
        }
        private void buttonCalcA_Click(object sender, EventArgs e)
        {
            getDados();
            if (itemSelecionado == 0)
            {
                //retangulo
                messagemA = r.calcArea();
            }
            else if (itemSelecionado == 1)
            {
                //circulo
                messagemA = c.calcArea();
            }

            else if (itemSelecionado == 2)
            {
                //triangulo
                messagemA = t.calcArea();
            }
            MessageBox.Show(messagemA);
        }
    }
}
