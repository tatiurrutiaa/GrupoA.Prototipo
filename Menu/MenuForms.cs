using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo
{
    public partial class MenuForms : Form
    {
        public MenuForms()
        {
            InitializeComponent();
        }

        private void buttonCargarOrdenPreparacion_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.OrdenPreparacionForms ordenpreparacion = new OrdenPreparacionForms();
            this.Hide();
            ordenpreparacion.Show();
        }

        private void botonGenerarOrdenSeleccion_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.OrdenSeleccionForms ordenseleccion = new OrdenSeleccionForms();
            this.Hide();
            ordenseleccion.Show();
        }

        private void botonGenerarOrdenEntrega_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.OrdenDeEntregaForms ordenentrega = new OrdenDeEntregaForms();
            this.Hide();
            ordenentrega.Show();
        }

        private void botonRetiroStock_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.RetiroStockForms retirostock = new RetiroStockForms();
            this.Hide();
            retirostock.Show();
        }

        private void botonVerificarTransportista_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.VerificarTransportistaForms verificartransportista = new VerificarTransportistaForms();
            this.Hide();
            verificartransportista.Show();
        }

        private void botonCrearRemito_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.RemitoForms remito = new();
            this.Hide();
            remito.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.IniciarSesionForms iniciarsesion = new();
            this.Hide();
            iniciarsesion.Show();
        }

        private void MenuForms_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxAlmacen_Enter(object sender, EventArgs e)
        {

        }
    }
}
