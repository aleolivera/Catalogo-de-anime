using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace Negocio
{
    public class TipoNegocio
    {
        public List<Tipo> listar()
        {
            
            AccesoDatos datos = new AccesoDatos();
            List<Tipo> lista = new List<Tipo>();
            datos.setearQuery("select * from Tipo");
            datos.ejecutarReader();

            while (datos.reader.Read())
            {
                Tipo aux = new Tipo();
                aux.ID =Convert.ToInt32(datos.reader[0]);
                aux.nombre = (string)datos.reader[1];
                lista.Add(aux);
            }
            datos.cerrarConexion();
            return lista;
        }
    }
}
