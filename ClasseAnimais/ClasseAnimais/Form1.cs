namespace ClasseAnimais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se o primeiro RadioButton (Oviparo) está selecionado
            if (radioButton1.Checked)
            {
                // Cria e mostra o formulário FormOviparo
                FormOviparo fOviparo = new FormOviparo();
                fOviparo.ShowDialog();
            }
            // Verifica se o segundo RadioButton (Mamifero) está selecionado
            else if (radioButton2.Checked)
            {
                // Cria e mostra o formulário FormMamifero
                FormMamifero fMamifero = new FormMamifero();
                fMamifero.ShowDialog();
            }
            else
            {
                // Caso nenhum RadioButton esteja selecionado
                MessageBox.Show("Selecione um tipo de animal.");
            }
        }
    }
}
