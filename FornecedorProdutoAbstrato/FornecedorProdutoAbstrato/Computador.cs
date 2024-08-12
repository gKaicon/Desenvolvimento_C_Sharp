using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrata
{
    public class Computador : IProduto
    {
        public bool Eperecivel => false;

        public void CadastrarCliente(Cliente cliente)
        {
            MessageBox.Show($"Cliente {cliente.nome} cadastrado com sucesso.", "Sucesso");
        }

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            MessageBox.Show($"Fornecedor {fornecedor.nome} cadastrado com sucesso.", "Sucesso");
        }


        //so faz o return e o new fornecedor
        public Fornecedor RecuperarFornecedor()
        {
            return new Fornecedor();
        }

        public void RegistrarVenda(Cliente cliente)
        {
            // Exibe uma mensagem confirmando a venda
            MessageBox.Show($"Venda para o cliente {cliente.nome} efetuada com sucesso!", "Sucesso");
        }
    }
}
