using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_17A
{
    public partial class frmVerArticulo : Form
    {
        private Articulo articulo = null;

        public frmVerArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmVerArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            cbMarca.DataSource = marcaNegocio.Listar();
            cbMarca.DisplayMember = "descripcion";
            cbMarca.ValueMember = "id";

            cbCategoria.DataSource = categoriaNegocio.Listar();
            cbCategoria.DisplayMember = "Descripcion";
            cbCategoria.ValueMember = "Id";

            txtCodigo.Text = articulo.Codigo;
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString();
            cbMarca.SelectedValue = articulo.Marca.id;
            cbCategoria.SelectedValue = articulo.Categoria.Id;
            txtImagen.Text = articulo.ImagenUrl;
            cargarImagen(articulo.ImagenUrl);

            // Controles para que sea sólo lectura:
            txtCodigo.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtImagen.ReadOnly = true;
            cbMarca.Enabled = false;
            cbCategoria.Enabled = false;
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
