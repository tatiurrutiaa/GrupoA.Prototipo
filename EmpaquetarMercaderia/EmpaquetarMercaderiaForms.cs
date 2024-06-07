using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo.EmpaquetarMercaderia
{
    public partial class EmpaquetarMercaderiaForms : Form
    {
        public EmpaquetarMercaderiaForms()
        {
            InitializeComponent();
        }
      
        private void EmpaquetarMercaderiaForms_Load(object sender, EventArgs e)
        {
            MostrarMercaderias();
        }
        private int numeroOrdenActual = 0;

        private void MostrarMercaderias()
        {
            var modelo = new EmpaquetarMercaderiaModel();
            var ordenesConMercaderias = modelo.ObtenerOrdenesConMercaderias();

            // Ordenar las órdenes de menor a mayor
            var ordenesOrdenadas = ordenesConMercaderias.OrderBy(orden => orden.NroOrdenPrep);

            // Obtener la primera orden en la lista ordenada
            var ordenActual = ordenesOrdenadas.FirstOrDefault(orden => orden.NroOrdenPrep > numeroOrdenActual);

            if (ordenActual != null)
            {
                // Limpiar el ListView
                empaquetarmercaderiaListview.Items.Clear();

                // Filtrar las mercaderías asociadas al número de orden actual
                var mercaderiasOrdenActual = ordenesConMercaderias
                    .Where(orden => orden.NroOrdenPrep == ordenActual.NroOrdenPrep);

                // Agregar las mercaderías al ListView
                foreach (var mercaderia in mercaderiasOrdenActual)
                {
                    var item = new ListViewItem(new[]
                    {
                mercaderia.IdProducto,
                mercaderia.Mercaderia,
                mercaderia.Cantidad.ToString()
            });

                    empaquetarmercaderiaListview.Items.Add(item);
                }

                // Mostrar el número de orden actual en el Label
                nroordenLabel.Text = ordenActual.NroOrdenPrep.ToString();

                // Actualizar el número de orden actual
                numeroOrdenActual = ordenActual.NroOrdenPrep;
            }
            else
            {
                // No hay órdenes disponibles, limpiar el ListView y el Label
                empaquetarmercaderiaListview.Items.Clear();
                nroordenLabel.Text = string.Empty;
            }
        }
        private void EmpaquetarMercaderias()
        {
            // Cambiar el estado de las mercaderías asociadas al número de orden actual a "Preparado"
            var modelo = new EmpaquetarMercaderiaModel();
            var ordenesConMercaderias = modelo.ObtenerOrdenesConMercaderias();

            // Obtener las mercaderías asociadas al número de orden actual
            var mercaderiasOrdenActual = ordenesConMercaderias.Where(orden => orden.NroOrdenPrep == numeroOrdenActual).ToList();

            foreach (var orden in mercaderiasOrdenActual)
            {
                orden.Estado = "Preparado";
            }

            // Mostrar un MessageBox con los productos y su nuevo estado
            var mensaje = "Productos Empaquetados:\n\n";
            foreach (var mercaderia in mercaderiasOrdenActual)
            {
                mensaje += $"{mercaderia.Mercaderia} - Estado: {mercaderia.Estado}\n";
            }

            MessageBox.Show(mensaje, "Empaquetar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mostrar las mercaderías asociadas al siguiente número de orden
            MostrarMercaderias();
        }


        private void empaquetarButton_Click(object sender, EventArgs e)
        {
            EmpaquetarMercaderias();
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }


        

        private void empaquetarmercaderiaListview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nroordenLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
