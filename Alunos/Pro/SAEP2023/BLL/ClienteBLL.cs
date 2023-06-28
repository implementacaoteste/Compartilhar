using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class ClienteBLL
    {
        public List<Clientes> BuscarTodos()
        {
            return new ClientesDAL().BuscarTodos();
        }
    }
}
