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
            try
            {
                var listaPosiciones = modelo.ObtenerListaParaOrdenSeleccion();
                foreach (var pos in listaPosiciones)
                {
                    listBoxRetiroStock.Items.Add($"Posición: {pos.Posicion}, Cantidad: {pos.Cantidad}, Mercadería: {pos.Mercaderia}");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*foreach (var mercaderiaARetirar in modelo.MercaderiaARetirar)
            {
                listBoxRetiroStock.Items.Add($"Posición: {mercaderiaARetirar.Posicion}," +
                                             $"Cantidad: {mercaderiaARetirar.Cantidad}," +
                                             $"Mercadería: {mercaderiaARetirar.Mercaderia}");
            }*/
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }

        private void botonDescontarStock_Click(object sender, EventArgs e)
        {
            listBoxRetiroStock.Items.Clear();
            try
            {
                modelo.DescontarStockYActualizarOrden();
                MessageBox.Show("Stock descontado y orden actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMercaderiaEnListBox();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
