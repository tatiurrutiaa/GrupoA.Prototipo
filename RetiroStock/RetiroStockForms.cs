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
            foreach (var mercaderiaARetirar in modelo.MercaderiaARetirar)
            {
                listBoxRetiroStock.Items.Add($"Posición: {mercaderiaARetirar.Posicion}," +
                                             $"Cantidad: {mercaderiaARetirar.Cantidad}," +
                                             $"Mercadería: {mercaderiaARetirar.Mercaderia}");
            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }

        private void botonDescontarStock_Click(object sender, EventArgs e)
        {

        }
    }
}
