using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Net.Configuration;

namespace Negocio
{
    public class AnimeNegocio
    {
        public List<Anime> listar()
        {
            List<Anime> lista = new List<Anime>();
            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("select a.ID, a.Codigo, a.Nombre, a.Descripcion, A.URLImagen,G.ID as IDGenero, G.Nombre as Genero,T.ID as IDTipo ,T.Nombre as Tipo, A.CantidadCapitulos as Cant,EnCurso as enCurso, isnull(A.FechaEstreno,'1-1-1000') as FechaEstreno from Anime A inner join Tipo T on t.ID=A.IDTipo inner join Generos G on G.ID=A.IDGenero");
            datos.ejecutarReader();
            while (datos.reader.Read())
            {
                Anime aux = new Anime();
                aux.ID = Convert.ToInt32(datos.reader[0]);
                aux.codigo = (string)datos.reader[1];
                aux.nombre = (string)datos.reader[2];
                aux.descripcion = (string)datos.reader[3];
                aux.URLImagen = (string)datos.reader[4];
                aux.genero = new Genero();
                aux.genero.ID = Convert.ToInt32(datos.reader[5]);
                aux.genero.nombre=(string)datos.reader[6];
                aux.tipo = new Tipo();
                aux.tipo.ID = Convert.ToInt32(datos.reader[7]);
                aux.tipo.nombre = (string)datos.reader[8];
                aux.cantidadCapitulos = Convert.ToInt32(datos.reader[9]);
                aux.enCurso = datos.reader.GetBoolean(10);
                aux.fechaEstreno = Convert.ToDateTime(datos.reader[11]);
                lista.Add(aux);
            }
            datos.cerrarConexion();
            return lista;
            
        }
        public bool buscar(string codigo)
        {
            bool estado = true;
            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("select a.Codigo, a.Nombre, a.Descripcion, A.URLImagen, G.Nombre as Genero, T.Nombre as Tipo from Anime A inner join Tipo T on t.ID=A.IDTipo inner join Generos G on G.ID=A.IDGenero where a.Codigo='@codigo'");
            datos.agregarParametro("@codigo", codigo);
            datos.ejecutarReader();

            if (datos.reader.Read())
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            datos.cerrarConexion();
            return estado;

        }

        public Anime cargar(string codigo)
        {
            Anime aux = new Anime();
            AccesoDatos datos = new AccesoDatos();

            datos.setearQuery("select a.Codigo, a.Nombre, a.Descripcion, A.URLImagen,G.ID as IDGenero, G.Nombre as Genero,T.ID as IDTipo ,T.Nombre as Tipo, CantidadCapitulos as Cant,EnCurso as enCurso from Anime A inner join Tipo T on t.ID=A.IDTipo inner join Generos G on G.ID=A.IDGenero where a.Codigo='@codigo'");
            datos.agregarParametro("@codigo", codigo);
            datos.ejecutarReader();

            if (datos.reader.Read())
            {
                aux.codigo = (string)datos.reader[0];
                aux.nombre = (string)datos.reader[1];
                aux.descripcion = (string)datos.reader[2];
                aux.URLImagen = (string)datos.reader[3];
                aux.genero = new Genero();
                aux.genero.ID = Convert.ToInt32(datos.reader[4]);
                aux.genero.nombre = (string)datos.reader[5];
                aux.tipo = new Tipo();
                aux.tipo.ID = Convert.ToInt32(datos.reader[6]);
                aux.tipo.nombre = (string)datos.reader[7];
                aux.cantidadCapitulos = Convert.ToInt32(datos.reader[8]);
                aux.enCurso = datos.reader.GetBoolean(9); 
            }
            
            datos.cerrarConexion();
            return aux;

        }
        public void agregar(Anime aux)
        {
            
            AccesoDatos datos = new AccesoDatos();
            datos.setearQuery("insert into Anime(Codigo, Nombre, Descripcion, IDGenero, IDTipo, URLImagen, CantidadCapitulos, enCurso) values(@Codigo, @Nombre, @Descripcion, @IDGenero, @IDTipo, @URLImagen, @CantidadCapitulos, @enCurso)");
            datos.agregarParametro("@Codigo", aux.codigo);
            datos.agregarParametro("@Nombre", aux.nombre);
            datos.agregarParametro("@Descripcion", aux.descripcion);
            datos.agregarParametro("@IDGenero", aux.genero.ID);
            datos.agregarParametro("@IDTipo", aux.tipo.ID);
            datos.agregarParametro("@URLImagen", aux.URLImagen);
            datos.agregarParametro("@CantidadCapitulos", aux.cantidadCapitulos);
            datos.agregarParametro("@enCurso", aux.enCurso);

            datos.ejecutarAccion();
            datos.cerrarConexion();

        }
        public void eliminar(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            try{
                datos.setearQuery("delete from Anime where ID = @ID");
                datos.agregarParametro("@ID", ID);
                datos.ejecutarAccion();
                datos.cerrarConexion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void modificar(Anime anime)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("update Anime set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IDGenero = @IDGenero, IDTipo = @IDTipo, URLImagen = @URLImagen, CantidadCapitulos = @CantidadCapitulos, EnCurso = @EnCurso where id =  @ID");
                datos.agregarParametro("@Codigo", anime.codigo);
                datos.agregarParametro("@Nombre", anime.nombre);
                datos.agregarParametro("@Descripcion", anime.descripcion);
                datos.agregarParametro("@IDGenero", anime.genero.ID);
                datos.agregarParametro("@IDTipo", anime.tipo.ID);
                datos.agregarParametro("@URLImagen", anime.URLImagen);
                datos.agregarParametro("@CantidadCapitulos", anime.cantidadCapitulos);
                datos.agregarParametro("@EnCurso", anime.enCurso);
                datos.agregarParametro("@ID", anime.ID);
                datos.ejecutarAccion();
                datos.cerrarConexion();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
