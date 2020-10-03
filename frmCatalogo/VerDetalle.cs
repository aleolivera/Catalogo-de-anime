using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace frmCatalogo
{
    public partial class frmVerDetalle : Form
    {
        private Anime anime { get; }
        public frmVerDetalle()
        {
            InitializeComponent();
        }
        public frmVerDetalle(Anime anime)
        {
            InitializeComponent();
            this.anime = anime;
        }

        private void VerDetalle_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            pbImagen.Load(anime.URLImagen);
            txtCodigo.Text = anime.codigo;
            txtNombre.Text = anime.nombre;
            txtDescripcion.Text = anime.descripcion;
            txtGenero.Text = anime.genero.nombre;
            txtTipo.Text = anime.tipo.nombre;
            txtCantCap.Text = Convert.ToString(anime.cantidadCapitulos);
            if (anime.fechaEstreno.Year != 1000) 
            { 
                txtfechaEstreno.Text = Convert.ToString(anime.fechaEstreno);
            }
            else
            {
                txtfechaEstreno.Text = "Sin especificar";
            }

            if (anime.enCurso)
            {
                txtEstado.Text = "En curso";
            }
            else
            {
                txtEstado.Text = "Concluida";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
