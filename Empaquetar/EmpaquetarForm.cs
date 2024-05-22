using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo.Empaquetado
{
    public partial class EmpaquetarForm : Form
    {
        EmpaquetarModel modelo;
        public EmpaquetarForm()
        {
            InitializeComponent();
        }



        private void EmpaquetarForm_Load(object sender, EventArgs e)
        {
            modelo = new();
            foreach (var Pedido in modelo.Empaquetar)
            {
                
            }

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarTicketButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForms menuForms = new MenuForms();
            // Mostrar el formulario de destino
            menuForms.Show();
            // Ocultar el formulario actual (opcional)
            this.Hide();
        }
    }
}
