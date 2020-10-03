using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Anime
    {
        public int ID { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string URLImagen { get; set; }
        public int cantidadCapitulos { get; set; }
        public Genero genero { get; set; }
        public Tipo tipo { get; set; }
        public DateTime fechaEstreno { get; set; }
        public bool enCurso { get; set; }
        public Anime() { }
        public Anime(string cod,string nom,string desc,string URLImg, int cant) 
        {
            codigo = cod;
            nombre = nom;
            descripcion = desc;
            URLImagen = URLImg;
            cantidadCapitulos = cant;
        }
    }
}
