using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Modelo.Entidades;

namespace WindowsFormsApp1.Modelo.DAO
{
    public class ClienteDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarCliente(Cliente client)
        {
            bool inserto = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO CLIENTES ");
                sql.Append(" VALUES (@Nombre, @Correo, @TipoTicket, @Servicio); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = client.Nombre;
                comando.Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value = client.Correo;
                comando.Parameters.Add("@TipoTicket", SqlDbType.NVarChar, 50).Value = client.TipoTicket;
                comando.Parameters.Add("@Servicio", SqlDbType.NVarChar, 50).Value = client.Servicio;

                comando.ExecuteNonQuery();
                MiConexion.Close();
                inserto = true;
            }
            catch (Exception)
            {
                return inserto;
            }

            return inserto;
        }

        public bool ActualizarTicket(Cliente client)
        {
            bool modifico = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE CLIENTES ");
                sql.Append(" SET TIPOTICKET = @TipoTicket ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@TipoTicket", SqlDbType.NVarChar, 50).Value = client.TipoTicket;

                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                return modifico;
            }
            return modifico;
        }

        public DataTable GetClientes()
        {
            DataTable clientesDT = new DataTable();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM CLIENTES ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();

                SqlDataReader dr = comando.ExecuteReader();
                clientesDT.Load(dr);

                MiConexion.Close();
            }
            catch (Exception)
            {

            }

            return clientesDT;
        }

    }
}
