//using GrupoA.Prototipo.Empaquetar;
using GrupoA.Prototipo.EmpaquetarMercaderia;
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

        //private void botonGenerarOrdenSeleccion_Click(object sender, EventArgs e)


        private void botonGenerarOrdenEntrega_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.OrdenesEntrega ordenentrega = new OrdenesEntrega();
            this.Hide();
            ordenentrega.Show();
        }

        private void botonRetiroStock_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.RetiroStockForms retirostock = new RetiroStockForms();
            this.Hide();
            retirostock.Show();
        }


        private void botonOrdenEntrega_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.OrdenesEntrega ordenentrega = new();
            this.Hide();
            ordenentrega.Show();
        }

        private void botonDespachoConTransportista_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.DespachoConTransportista.DespachoConTransportistaForms salida = new();
            this.Hide();
            salida.Show();
        }

        private void botonDespachoSintranportista_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.DespachoSinTransportista.DespachoSinTransportistaForms salida = new();
            this.Hide();
            salida.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.IniciarSesionForms iniciarsesion = new();
            this.Hide();
            iniciarsesion.Show();
        }
        private void MenuForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void MenuForms_Load(object sender, EventArgs e)
        {

        }

        private void EmpaquetarMButton_Click(object sender, EventArgs e)
        {
            EmpaquetarMercaderiaForms empaquetarForm = new EmpaquetarMercaderiaForms();

            // Mostrar el formulario EmpaquetarMercaderiaForms
            empaquetarForm.Show();
        }
    }

}
