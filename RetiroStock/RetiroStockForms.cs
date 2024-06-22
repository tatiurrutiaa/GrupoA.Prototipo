using GrupoA.Prototipo.IniciarSesion;
using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            listViewRetiroStock.Items.Clear();

            listViewRetiroStock.View = View.Details;
            listViewRetiroStock.Columns.Add("Posición", 60, HorizontalAlignment.Left);
            listViewRetiroStock.Columns.Add("Cantidad", 60, HorizontalAlignment.Left);
            listViewRetiroStock.Columns.Add("Cod. Producto", 90, HorizontalAlignment.Left);
            listViewRetiroStock.Columns.Add("Descripción", 140, HorizontalAlignment.Left);
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
            var orden = new RetiroStock.OrdenSeleccion();

            orden.NroOrdenSelec = (int)comboBoxOrdenSelec.SelectedItem;

            var listaPosiciones = modelo.MercaderiaARetirar(orden.NroOrdenSelec);

            listViewRetiroStock.Items.Clear(); // Limpiar el ListView antes de agregar nuevos elementos

            foreach (var pos in listaPosiciones)
            {
                var listViewItem = new ListViewItem(pos.Posicion);
                listViewItem.SubItems.Add(pos.Cantidad.ToString());
                listViewItem.SubItems.Add(pos.CodProducto.ToString());
                listViewItem.SubItems.Add(pos.DescProducto);
                listViewRetiroStock.Items.Add(listViewItem);
            }
        }

        private void botonRetirarStock_Click(object sender, EventArgs e)
        {
            var orden = new RetiroStock.OrdenSeleccion();
            orden.NroOrdenSelec = (int)comboBoxOrdenSelec.SelectedItem;
            modelo.ActualizarStockYOrden(orden.NroOrdenSelec);

            listViewRetiroStock.Items.Clear();
            groupBoxRetirarMercaderia.Enabled = false;

            groupBoxOrdenSelec.Enabled = true;
            comboBoxOrdenSelec.SelectedIndex = -1;
            comboBoxOrdenSelec.Items.Clear();
            CargarOrdenesSeleccion();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            listViewRetiroStock.Items.Clear();
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
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = this.Location;
            menu.Show();
        }

        // Cierra el proceso al cerrar la aplicación
        private void RetiroStockForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
