using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tipo
    {
        public int ID { get; set; }
        public string nombre { get; set; }

        public Tipo() { }
        public Tipo(int IDTipo, string nom)
        {
            ID = IDTipo;
            nombre = nom;
        }
        public Tipo(string nom)
        {
            nombre = nom;
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
