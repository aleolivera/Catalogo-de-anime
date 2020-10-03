using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Genero
    {
        public int ID { get; set; }
        public string nombre { get; set; }
      
        public Genero() { }
        public Genero(int IDGen, string nom)
        {
            ID = IDGen;
            nombre = nom;    
        }
        public Genero(string nom)
        {
            nombre = nom;
        }
        public override string ToString()
        {
            return nombre;
        }

    }
}
