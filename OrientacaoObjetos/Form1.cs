using System;
using System.Windows.Forms;

namespace OrientacaoObjetos
{
    public partial class Form1 : Form
    {
        private Empregado cadEmpregado;

        public Form1()
        {
            InitializeComponent();
            cadEmpregado = new Empregado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadEmpregado.Nome = textBox1.Text;
            label6.Text = cadEmpregado.Nome;
            label7.Text = cadEmpregado.Idade.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Tem Certeza que quer sair do programa?";
            string rotulo = "Sair do Programa";
            MessageBoxButtons sair = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mensagem, rotulo, sair);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Form1 aux = new Form1();
                aux.Show();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
            cadEmpregado.Idade = trackBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
