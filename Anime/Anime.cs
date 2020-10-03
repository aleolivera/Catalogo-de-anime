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
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string URLImagen { get; set; }

        public Anime(int ID, string nom, string desc, string URLImg) {
            this.ID = ID;
            nombre = nom;
            descripcion = desc;
            URLImagen = URLImg;
        }
        public Anime() { }


    }
}
