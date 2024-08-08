using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace AtividadeAtleta
{
    public partial class Form1 : Form
    {
        Ciclista ciclista = new Ciclista();
        Corredor corredor = new Corredor();
        Nadador nadador = new Nadador();
        Triatleta triatleta = new Triatleta();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um item do ComboBox.");
                return;
            }

            try
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                switch (selectedItem)
                {
                    case "Ciclista":
                        ciclista.Pedalar();
                        break;
                    case "Corredor":
                        corredor.Correr();
                        break;
                    case "Nadador":
                        nadador.Nadar();
                        break;
                    case "Triatleta":
                        triatleta.Triatlo();
                        break;
                    default:
                        MessageBox.Show("Tipo de atleta desconhecido.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                string messagem = "";
                switch (selectedItem)
                {
                    case "Ciclista":
                        messagem += ciclista.VerHabilidades();
                        break;
                    case "Corredor":
                        messagem += corredor.VerHabilidades();
                        break;
                    case "Nadador":
                        messagem += nadador.VerHabilidades();
                        break;
                    case "Triatleta":
                        messagem += triatleta.VerHabilidades();
                        break;
                    default:
                        MessageBox.Show("Tipo de atleta desconhecido.");
                        break;
                }
                MessageBox.Show(messagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
