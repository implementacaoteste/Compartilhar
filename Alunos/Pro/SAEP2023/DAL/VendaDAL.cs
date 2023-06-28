using System;
using System.Data.SqlClient;

namespace DAL
{
    public class VendaDAL
    {
        public void Vender(int  _idAlocacao, int _idAutomovel, int _idCliente, int _idConcessionaria, int _idArea, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO venda(automovel, cliente, concessionaria, area, alocacao)
                                                         VALUES(@automovel, @cliente, @concessionaria, @area, @idAlocacao)
                                                            
                                                        UPDATE alocacao SET quantidade -= 1 WHERE id = @idAlocacao", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@automovel", _idAutomovel);
                        cmd.Parameters.AddWithValue("@cliente", _idCliente);
                        cmd.Parameters.AddWithValue("@concessionaria", _idConcessionaria);
                        cmd.Parameters.AddWithValue("@area", _idArea);
                        cmd.Parameters.AddWithValue("@idAlocacao", _idAlocacao);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar ação no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
    }
}