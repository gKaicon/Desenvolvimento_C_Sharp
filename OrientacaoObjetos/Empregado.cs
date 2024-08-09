namespace OrientacaoObjetos
{
    public class Empregado
    {
        private string nomeEmp;
        private int idadeEmp;

        public Empregado()
        {
        }

        public Empregado(string nomeEmp, int idadeEmp)
        {
            this.nomeEmp = nomeEmp;
            this.idadeEmp = idadeEmp;
        }

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
