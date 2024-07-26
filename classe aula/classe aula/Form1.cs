using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classe_aula
{
    public partial class Form1 : Form
    {
        Pessoa p;
        Cliente cL = new Cliente();
        public Form1()
        {
            InitializeComponent();
            labelListaProd.Text = cL.listaProduto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            p = new Pessoa(textBox1.Text, textBox2.Text, x);
            String messagem = p.Dados();

            MessageBox.Show(messagem, "Dados da pessoa");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            int id = Convert.ToInt32(textBox4.Text);
            int qnt = Convert.ToInt32(textBox5.Text);
            String s = cliente.compra(id-1, qnt);
            MessageBox.Show(s, "Dados da compra");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            Cliente p = new Cliente(textBox1.Text, textBox2.Text, x);
            String messagem = p.Dados();

            MessageBox.Show(messagem, "Dados da cliente");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            p = new Diretor(textBox1.Text, textBox2.Text, x);
            String messagem = p.Dados();

            MessageBox.Show(messagem, "Dados da cliente");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String s = p.viajar();
            MessageBox.Show(s, "Viagem");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            p = new Vendedor(textBox1.Text, textBox2.Text, x);
            String messagem = p.Dados();

            MessageBox.Show(messagem, "Dados da cliente");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vendedor p = new Vendedor();
            string v = p.vendas();
            MessageBox.Show(v);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            p = new Funcionado(textBox1.Text, textBox2.Text, x);
            String messagem = p.Dados();

            MessageBox.Show(messagem, "Dados da cliente");
        }
    }
}
