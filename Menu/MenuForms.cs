//using GrupoA.Prototipo.Empaquetar;
using GrupoA.Prototipo.EmpaquetarMercaderia;
using GrupoA.Prototipo.OrdenEntrega;
using GrupoA.Prototipo.OrdenSeleccion;
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
            ordenpreparacion.StartPosition = FormStartPosition.Manual;
            ordenpreparacion.Location = this.Location;
            ordenpreparacion.Show();
        }

        private void botonOrdenSeleccion_Click(object sender, EventArgs e)
        {
            OrdenSeleccionForm ordenseleccion = new OrdenSeleccionForm();
            this.Hide();
            ordenseleccion.StartPosition = FormStartPosition.Manual;
            ordenseleccion.Location = this.Location;
            ordenseleccion.Show();
        }


        private void botonGenerarOrdenEntrega_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.OrdenEntregaForms ordenentrega = new OrdenEntregaForms();
            this.Hide();
            ordenentrega.StartPosition = FormStartPosition.Manual;
            ordenentrega.Location = this.Location;
            ordenentrega.Show();
        }

        private void botonRetiroStock_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.RetiroStockForms retirostock = new RetiroStockForms();
            this.Hide();
            retirostock.StartPosition = FormStartPosition.Manual;
            retirostock.Location = this.Location;
            retirostock.Show();
        }


        private void botonOrdenEntrega_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.OrdenEntregaForms ordenentrega = new();
            this.Hide();
            ordenentrega.StartPosition = FormStartPosition.Manual;
            ordenentrega.Location = this.Location;
            ordenentrega.Show();
        }

        private void botonDespachoConTransportista_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.DespachoConTransportista.DespachoConTransportistaForms despachocontransportista = new();
            this.Hide();
            despachocontransportista.StartPosition = FormStartPosition.Manual;
            despachocontransportista.Location = this.Location;
            despachocontransportista.Show();
        }

        private void botonDespachoSintranportista_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.DespachoSinTransportista.DespachoSinTransportistaForms despachosintransportista = new();

            this.Hide();
            despachosintransportista.StartPosition = FormStartPosition.Manual;
            despachosintransportista.Location = this.Location;
            despachosintransportista.Show();

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.IniciarSesionForms iniciarsesion = new();
            this.Hide();
            iniciarsesion.StartPosition = FormStartPosition.Manual;
            iniciarsesion.Location = this.Location;
            iniciarsesion.Show();
        }



        private void MenuForms_Load(object sender, EventArgs e)
        {

        }

        private void EmpaquetarMButton_Click(object sender, EventArgs e)
        {
            EmpaquetarMercaderiaForms empaquetarForm = new EmpaquetarMercaderiaForms();
            this.Hide();
            empaquetarForm.StartPosition = FormStartPosition.Manual;
            empaquetarForm.Location = this.Location;
            // Mostrar el formulario EmpaquetarMercaderiaForms
            empaquetarForm.Show();
        }
        private void MenuForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }

}
