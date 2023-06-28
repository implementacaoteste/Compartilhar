using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class ConcessionariasBLL
    {
        public List<Concessionarias> BuscarPorCarroEArea(int _idAutomovel, int _idArea)
        {
            return new ConcessionariasDAL().BuscarPorCarroEArea(_idAutomovel, _idArea);
        }

        public List<Concessionarias> BuscarTodos()
        {
            return new ConcessionariasDAL().BuscarTodos();
        }
    }
}
