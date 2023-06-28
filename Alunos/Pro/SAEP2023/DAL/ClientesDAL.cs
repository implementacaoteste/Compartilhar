using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class ClientesDAL
    {
        public List<Clientes>BuscarTodos()
        {

            List<Clientes> clienteList = new List<Clientes>();
            Clientes cliente = new Clientes();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT id, nome FROM clientes";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Clientes();
                        cliente.Id = (int)rd["id"];
                        cliente.Nome = rd["nome"].ToString();
                        clienteList.Add(cliente);
                    }
                }
                return clienteList;
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
