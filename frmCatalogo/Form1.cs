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
    public partial class frmCatalogo : Form
    {
        
        public List<Anime> listaOriginal = new List<Anime>();
        public frmCatalogo()
        {
            InitializeComponent();
            
        }

        private void cargar()
        {
            AnimeNegocio aux = new AnimeNegocio();
            listaOriginal = aux.listar();
            dgvCatalogo.DataSource = listaOriginal;
            dgvCatalogo.Columns[1].Visible = false;
            dgvCatalogo.Columns[3].Visible = false;
            dgvCatalogo.Columns[4].Visible = false;
            dgvCatalogo.Columns[5].Visible = false;
            dgvCatalogo.Columns[8].Visible = false;
            dgvCatalogo.Columns[9].Visible = false;
            dgvCatalogo.Columns[0].Visible = false;
        }
        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Anime aux = (Anime)dgvCatalogo.CurrentRow.DataBoundItem;
                pbCatalogo.Load(aux.URLImagen);

            }
            catch (Exception)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar aux = new frmAgregar();
            aux.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AnimeNegocio aux = new AnimeNegocio();
            aux.eliminar(((Anime)dgvCatalogo.CurrentRow.DataBoundItem).ID);
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Anime anime = new Anime();
            anime = (Anime)dgvCatalogo.CurrentRow.DataBoundItem;
            frmAgregar aux = new frmAgregar(anime);
            aux.ShowDialog();
            cargar();
            
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            AnimeNegocio negocio = new AnimeNegocio();
            Anime aux = new Anime();
            aux = (Anime)dgvCatalogo.CurrentRow.DataBoundItem;
            frmVerDetalle detalle= new frmVerDetalle(aux);
            detalle.ShowDialog();
            cargar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Anime> listaFiltrada = new List<Anime>();
            listaFiltrada = listaOriginal.FindAll(x => x.nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()) || x.codigo.ToUpper().Contains(txtBuscar.Text.ToUpper()));
            dgvCatalogo.DataSource = listaFiltrada;
            
        }
    }
}
