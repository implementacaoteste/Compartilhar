using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class AlocacaoDAL
    {
        public List<Alocacao> BuscarTodos()
        {

            List<Alocacao> alocacaoList = new List<Alocacao>();
            Alocacao alocacao = new Alocacao();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT id, area, automovel, concessionaria, quantidade FROM alocacao WHERE quantidade > 0";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        alocacao = new Alocacao();
                        alocacao.Id = (int)rd["id"];
                        alocacao.Area = (int)rd["area"];
                        alocacao.Automovel = (int)rd["automovel"];
                        alocacao.Concessionaria = (int)rd["concessionaria"];
                        alocacao.Quantidade = (int)rd["quantidade"];
                        alocacaoList.Add(alocacao);
                    }
                }
                return alocacaoList;
            }
            catch (Exception ex)
            {
                throw new Exception("ocorreu um erro ao tentar buscar registro no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
