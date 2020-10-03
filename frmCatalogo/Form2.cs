using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCatalogo
{
    public partial class frmAgregar : Form
    {
        private Anime animeOriginal = null;
        private List<Anime> listaOriginal { get; set; }
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Anime anime)
        {
            InitializeComponent();
            animeOriginal = anime;
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            GeneroNegocio auxGenero = new GeneroNegocio();
            TipoNegocio auxTipo = new TipoNegocio();

            cbGenero.DataSource = auxGenero.listar();
            cbTipo.DataSource = auxTipo.listar();
            
            cbTipo.ValueMember= "ID";
            cbTipo.DisplayMember = "nombre";
            cbGenero.ValueMember = "ID";
            cbGenero.DisplayMember = "nombre";
            cbGenero.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;

            if (animeOriginal != null)
            {
                txtCodigo.Text = animeOriginal.codigo;
                txtNombre.Text = animeOriginal.nombre;
                txtDescripcion.Text = animeOriginal.descripcion;
                txtURLImagen.Text = animeOriginal.URLImagen;
                txtCapitulos.Text = Convert.ToString(animeOriginal.cantidadCapitulos);
                cbConcluida.Checked = animeOriginal.enCurso;
                cbGenero.SelectedIndex = animeOriginal.genero.ID;
                cbTipo.SelectedIndex = animeOriginal.tipo.ID;
                nudDia.Value = animeOriginal.fechaEstreno.Day;
                nudMes.Value = animeOriginal.fechaEstreno.Month;
                nudAnio.Value = animeOriginal.fechaEstreno.Year;


                Text = "Modificar Anime";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            AnimeNegocio negocio = new AnimeNegocio();
            if (animeOriginal == null)
            {
                animeOriginal = new Anime();
                animeOriginal.tipo = new Tipo();
                animeOriginal.genero = new Genero();
            }
            
            animeOriginal.codigo = txtCodigo.Text;
            animeOriginal.nombre = txtNombre.Text;
            animeOriginal.genero = (Genero)cbGenero.SelectedItem;
            animeOriginal.tipo = (Tipo)cbTipo.SelectedItem;
            animeOriginal.descripcion = txtDescripcion.Text;
            animeOriginal.cantidadCapitulos = Convert.ToInt32(txtCapitulos.Text);
            animeOriginal.URLImagen = txtURLImagen.Text;
            animeOriginal.enCurso = cbConcluida.Checked;
            

            if (animeOriginal.ID != 0)
            {
                negocio.modificar(animeOriginal);
                MessageBox.Show("El Anime '" + animeOriginal.nombre + "' se ha modificado Correctamente");
            }
            else
            {
                negocio.agregar(animeOriginal);
                MessageBox.Show("El Anime '" + animeOriginal.nombre + "' se ha cargado Correctamente");
            }
            
            Close();
        }
    }
}
