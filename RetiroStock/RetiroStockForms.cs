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
        private readonly RetiroStockModelo modelo = new();
        public RetiroStockForms()
        {
            InitializeComponent();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }

        private void RetiroStockForms_Load(object sender, EventArgs e)
        {
        
        }

        private void botonDescontarStock_Click(object sender, EventArgs e)
        {

        }
    }
}
