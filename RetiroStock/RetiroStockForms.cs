using GrupoA.Prototipo.Empaquetar;
using GrupoA.Prototipo.IniciarSesion;
using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoA.Prototipo
{
    public partial class RetiroStockForms : Form
    {
        RetiroStockModelo modelo;

        public RetiroStockForms()
        {
            InitializeComponent();
        }
        private void RetiroStockForms_Load(object sender, EventArgs e)
        {
            modelo = new();

            CargarOrdenesSeleccion();

            listBoxRetiroStock.DataSource = null;
        }

        private void CargarOrdenesSeleccion()
        {
            var listaOrdenes = modelo.OrdenesSelecPendientes();

            if (listaOrdenes == null)
            {
                return;
            }

            foreach (var orden in listaOrdenes)
            {
                comboBoxOrdenSelec.Items.Add(orden);
            }

            if (comboBoxOrdenSelec.Items.Count == 0)
            {
                MessageBox.Show("No hay Ordenes de Selección pendientes para retirar."
                    + Environment.NewLine
                    + "Por favor, intente nuevamente en unos minutos");
                return;
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxOrdenSelec.Items.Count == 0)
            {
                MessageBox.Show("No hay Ordenes de Selección pendientes para retirar."
                    + Environment.NewLine
                    + "Por favor, intente nuevamente en unos minutos");
                return;
            }

            if (comboBoxOrdenSelec.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una Orden de Selección.");
                return;
            }

            groupBoxOrdenSelec.Enabled = false;
            groupBoxRetirarMercaderia.Enabled = true;
            var orden = new OrdenesSeleccion();

            orden.NroOrdenSelec = (int)comboBoxOrdenSelec.SelectedItem;

            var listaPosiciones = modelo.MercaderiaARetirar(orden.NroOrdenSelec);

            foreach (var pos in listaPosiciones)
            {
                listBoxRetiroStock.Items.Add($"Posición: {pos.Posicion}, Cantidad: {pos.Cantidad}, Mercadería: {pos.Mercaderia}");
            }
        }

        private void botonRetirarStock_Click(object sender, EventArgs e)
        {
            var orden = new OrdenesSeleccion();
            orden.NroOrdenSelec = (int)comboBoxOrdenSelec.SelectedItem;
            modelo.ActualizarStockYOrden(orden.NroOrdenSelec);

            listBoxRetiroStock.Items.Clear();
            groupBoxRetirarMercaderia.Enabled = false;

            groupBoxOrdenSelec.Enabled = true;
            comboBoxOrdenSelec.SelectedIndex = -1;
            comboBoxOrdenSelec.Items.Clear();
            CargarOrdenesSeleccion();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            listBoxRetiroStock.Items.Clear();
            groupBoxRetirarMercaderia.Enabled = false;

            groupBoxOrdenSelec.Enabled = true;
            comboBoxOrdenSelec.SelectedIndex = -1;
            comboBoxOrdenSelec.Items.Clear();
            CargarOrdenesSeleccion();
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }
    }
}
