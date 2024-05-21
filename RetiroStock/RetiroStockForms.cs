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
            listBoxRetiroStock.DataSource = null;
            CargarMercaderiaEnListBox();
        }

        private void CargarMercaderiaEnListBox()
        {
            var listaPosiciones = modelo.MercaderiaARetirar();
            foreach (var pos in listaPosiciones)
            {
                listBoxRetiroStock.Items.Add($"Posición: {pos.Posicion}, Cantidad: {pos.Cantidad}, Mercadería: {pos.Mercaderia}");
            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }

        private void botonRetirarStock_Click(object sender, EventArgs e)
        {
            modelo.ActualizarStockYOrden();
            MessageBox.Show("La mercadería se descontó del almacén con éxito." +
            Environment.NewLine +
            "Por favor, entregar la mercadería al area de preparación.");
            listBoxRetiroStock.Items.Clear();
            CargarMercaderiaEnListBox();
        }
    }
}
