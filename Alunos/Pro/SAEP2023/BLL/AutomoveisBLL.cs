using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class AutomoveisBLL
    {
        public List<Automoveis> BuscarPorArea(int _area)
        {
            return new AutomoveisDAL().BuscarPorArea(_area);
        }
    }
}
