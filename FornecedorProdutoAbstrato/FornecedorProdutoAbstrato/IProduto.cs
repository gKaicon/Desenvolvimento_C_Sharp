using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrata
{
    public interface IProduto
    {
        bool Eperecivel { get; }
        Fornecedor RecuperarFornecedor();
        void RegistrarVenda(Cliente cliente);

        void CadastrarFornecedor(Fornecedor fornecedor);
        void CadastrarCliente(Cliente cliente);
    }
}
