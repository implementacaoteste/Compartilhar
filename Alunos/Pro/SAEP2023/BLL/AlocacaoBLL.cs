using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class AlocacaoBLL
    {
        public List<Alocacao> BuscarTodos()
        {
            return new AlocacaoDAL().BuscarTodos();
        }
    }
}
