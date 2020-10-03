using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class GeneroNegocio
    {
        public List<Genero> listar()
        {
            List<Genero> lista = new List<Genero>();
            SqlCommand comando = new SqlCommand();
            SqlDataReader reader;
            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = "data source= ALE\\SQLEXPRESS; initial catalog= CatalogoAnime; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Generos";
            comando.Connection = conexion;

            conexion.Open();
            reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                Genero aux = new Genero();
                aux.ID =Convert.ToInt32(reader[0]);
                aux.nombre = (string)reader[1];
                lista.Add(aux);
            }
            conexion.Close();
            return lista;
        }
    }
}
