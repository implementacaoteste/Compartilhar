using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class ConcessionariasDAL
    {
        public List<Concessionarias> BuscarPorCarroEArea(int _idAutomovel, int _idArea)
        {
            List<Concessionarias> concessionariasList = new List<Concessionarias>();
            Concessionarias concessionarias = new Concessionarias();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT concessionarias.id, concessionarias.concessionaria, ALOCACAO.id AS idAlocacao FROM concessionarias
                                    INNER JOIN alocacao ON concessionarias.id = alocacao.concessionaria
                                    INNER JOIN automoveis ON automoveis.id = alocacao.automovel
                                    where alocacao.automovel = @IdAutomovel and alocacao.area = @IdArea and alocacao.quantidade > 0";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdAutomovel", _idAutomovel);
                cmd.Parameters.AddWithValue("@IdArea", _idArea);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        concessionarias = new Concessionarias();
                        concessionarias.Id = (int)rd["id"];
                        concessionarias.Concessionaria = rd["Concessionaria"].ToString();
                        concessionarias.Alocacao = (int)rd["idAlocacao"];
                        concessionariasList.Add(concessionarias);
                    }
                }
                return concessionariasList;
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

        public List<Concessionarias> BuscarTodos()
        {
            List<Concessionarias> concessionariasList = new List<Concessionarias>();
            Concessionarias concessionarias = new Concessionarias();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT id, concessionaria FROM concessionarias";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        concessionarias = new Concessionarias();
                        concessionarias.Id = (int)rd["id"];
                        concessionarias.Concessionaria = rd["Concessionaria"].ToString();
                        concessionariasList.Add(concessionarias);
                    }
                }
                return concessionariasList;
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
