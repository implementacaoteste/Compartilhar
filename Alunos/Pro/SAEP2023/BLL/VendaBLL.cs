using DAL;

namespace BLL
{
    public class VendaBLL
    {
        public void Vender(int _idAlocacao, int _idAutomovel, int _idCliente, int _idConcessionaria, int _idArea)
        {
            new VendaDAL().Vender(_idAlocacao, _idAutomovel, _idCliente, _idConcessionaria, _idArea);
        }
    }
}