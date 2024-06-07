using System;
using System.Windows.Forms;
using GrupoA.Prototipo.OrdenesdeEntrega;

namespace GrupoA.Prototipo
{
    public partial class OrdenesEntrega : Form
    {
        private OrdendeEntregaModel _model;

        public OrdenesEntrega()
        {
            InitializeComponent();
            _model = new OrdendeEntregaModel();
            _model.AgregarOrdenesAlListBox(ListBoxOrdenesPrep);
        }

        private void BotonGenerarOrdenDeEntrega_Click(object sender, EventArgs e)
        {
            _model.GenerarOrdenDeEntrega(ListBoxOrdenesPrep);
        }

        private void BotonMenu_Click(object sender, EventArgs e)
        {
            MenuForms menu = new MenuForms();
            this.Hide();
            menu.Show();
        }

        private void ListBoxOrdenesPrep_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Manejar el evento si es necesario
        }

        private void OrdenesEntrega_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
