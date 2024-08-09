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
            if (radioButton1.Checked)
            {
                FormOviparo fOviparo = new FormOviparo();
                fOviparo.ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                FormMamifero fMamifero = new FormMamifero();
                fMamifero.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um tipo de animal.");
            }
        }
    }
}
