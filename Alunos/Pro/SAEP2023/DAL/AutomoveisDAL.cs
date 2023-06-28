using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class AutomoveisDAL
    {
        public List<Automoveis> BuscarPorTodos()
        {

            List<Automoveis> automoveisList = new List<Automoveis>();
            Automoveis automoveis = new Automoveis();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT id, modelo, preco FROM automoveis";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        automoveis = new Automoveis();
                        automoveis.Id = Convert.ToInt32(rd["id"]);
                        automoveis.Modelo = rd["modelo"].ToString();
                        automoveis.Preco = Convert.ToDouble(rd["Preco"]);
                        automoveisList.Add(automoveis);
                    }
                }
                return automoveisList;
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
        public List<Automoveis> BuscarPorArea(int _area)
        {

            List<Automoveis> automoveisList = new List<Automoveis>();
            Automoveis automoveis = new Automoveis();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT automoveis.id, automoveis.modelo, automoveis.preco, alocacao.id AS alocacao FROM automoveis 
                                    INNER JOIN alocacao on automoveis.id = alocacao.automovel 
                                    and alocacao.area = @area and alocacao.quantidade > 0";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@area", _area);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        automoveis = new Automoveis();
                        automoveis.Id = Convert.ToInt32(rd["id"]);
                        automoveis.Modelo = rd["modelo"].ToString();
                        automoveis.Preco = Convert.ToDouble(rd["Preco"]);
                        automoveis.Alocacao = (int)rd["alocacao"];
                        automoveisList.Add(automoveis);
                    }
                }
                return automoveisList;
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
