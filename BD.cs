using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ChessMaster
{
    public static class BD
    {
        private static string _connectionString = "Server=.;Database=db_Ajedrez;Trusted_Connection=True;";

        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }

        private static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al conectar a la Base de Datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void Desconectar(SqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        public static bool ValidarCodigo(string codigo)
        {
            bool valido = false;
            string cod = "";
            List<Point> lista = new List<Point>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SP_ValidarCodigo";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@pCodigo", codigo);
            SqlDataReader dr = consulta.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cod = dr["Codigo"].ToString();

                }
            }
            if(cod != codigo)
            {
                valido = true;
            }
            return valido;
        }
        
        public static void CrearLobby(string codigo, char Jug1Color, char Jug2Color)
        {
            List<Point> lista = new List<Point>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SP_CrearLobby";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;

            consulta.Parameters.AddWithValue("@pIdLobby", codigo);
            consulta.Parameters.AddWithValue("@pJug1Color", Jug1Color);
            consulta.Parameters.AddWithValue("@pJug2Color", Jug2Color);
            SqlDataReader dr = consulta.ExecuteReader();
         
            Desconectar(conn);

        }
        public static Lobby UnirseAlLobby(string codigo)
        {
            List<Point> lista = new List<Point>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SP_UnirseALobby";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@pCodigo", codigo);
            Lobby miLobby = new Lobby();
            SqlDataReader dr = consulta.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                   string cod = dr["Codigo"].ToString();
                    char ColorJug1 = Convert.ToChar(dr["Color1"]);
                    char ColorJug2 = Convert.ToChar(dr["Color2"]);
                     miLobby = new Lobby(cod, ColorJug1, ColorJug2);
                }
            }
            Desconectar(conn);
            return miLobby;

        }
        /*
        public static void CrearJuego(string miCliente)
        {
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SP_IngresarCliente";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@Nombre", miCliente.Nombre);
            consulta.Parameters.AddWithValue("@Apellido", miCliente.Apellido);
            consulta.Parameters.AddWithValue("@FechaNacimiento", Convert.ToDateTime(miCliente.Nac));
            if (miCliente.NombreFoto != "")
            {
                consulta.Parameters.AddWithValue("@NombreFoto", miCliente.NombreFoto);
            }

            consulta.ExecuteNonQuery();
            Desconectar(conn);
        }*/

    }
}
