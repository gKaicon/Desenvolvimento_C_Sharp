namespace OrientacaoObjetos
{
    public class Empregado
    {
        private string nomeEmp;
        private int idadeEmp;

        public int Idade
        {
            get { return idadeEmp; }
            set { idadeEmp = value; }
        }

        public string Nome
        {
            get { return nomeEmp; }
            set { nomeEmp = value; }
        }
    }
}
