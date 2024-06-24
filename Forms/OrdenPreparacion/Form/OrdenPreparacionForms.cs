using GrupoA.Prototipo.EmpaquetarMercaderia;
using GrupoA.Prototipo.Forms.OrdenPreparacion.Model;
using GrupoA.Prototipo.Forms.RetiroStock;
using System.Net;
using System.Windows.Forms;

namespace GrupoA.Prototipo
{
    public partial class OrdenPreparacionForms : Form
    {
        OrdenPreparacionModel modelo;
        public OrdenPreparacionForms()
        {
            InitializeComponent();
        }

        private void OrdenPreparaciónForms_Load(object sender, EventArgs e)
        {
            modelo = new();
        }

        private void groupBoxCliente_Enter(object sender, EventArgs e)
        {

        }

        #region Carga de CUIT
        private void textBoxCUITCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y guiones
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void textBoxCUITCliente_TextChanged(object sender, EventArgs e)
        {
            // Desactivar temporalmente el evento para evitar recursiones infinitas
            textBoxCUITCliente.TextChanged -= textBoxCUITCliente_TextChanged;

            string text = textBoxCUITCliente.Text.Replace("-", ""); // Eliminar guiones antes de procesar
            string formattedText = "";

            if (text.Length > 0)
            {
                formattedText += text.Substring(0, Math.Min(2, text.Length)); // Agregar los primeros 2 caracteres
            }

            if (text.Length > 2)
            {
                formattedText += "-" + text.Substring(2, Math.Min(8, text.Length - 2)); // Agregar los siguientes 8 caracteres
            }

            if (text.Length > 10)
            {
                formattedText += "-" + text.Substring(10, Math.Min(1, text.Length - 10)); // Agregar el último caracter
            }

            textBoxCUITCliente.Text = formattedText;
            textBoxCUITCliente.SelectionStart = textBoxCUITCliente.Text.Length; // Colocar el cursor al final del texto

            // Reactivar el evento
            textBoxCUITCliente.TextChanged += textBoxCUITCliente_TextChanged;
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            string cuit = this.textBoxCUITCliente.Text;
            var cliente = modelo.BuscarCliente(cuit);

            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }

            this.textBoxRazonSocialCliente.Text = cliente.RazonSocial;
            // oculto o deshabilito la busqueda... etc. 

            groupBoxCliente.Enabled = false;
            groupBoxOrdenPreparación.Enabled = true;

            textBoxCódigoOrden.Text = modelo.NuevoNroOrden().ToString();
            textBoxFechaOrden.Text = DateTime.Now.ToString("dd-MM-yyyy");
            CargarDepositosComboBox();
        }

        #endregion

        #region Muestra Depositos
        private void CargarDepositosComboBox()
        {
            string cuit = this.textBoxCUITCliente.Text;
            var listadepositos = modelo.ObtenerDepositosPorCliente(cuit);

            // Depuración: Verificar lista de depósitos
            if (listadepositos.Count == 0)
            {
                MessageBox.Show("No se encontraron depósitos para el cliente con CUIT: " + cuit);
            }
            //else
            //{
            //    MessageBox.Show("Se encontraron " + listadepositos.Count + " depósitos para el cliente con CUIT: " + cuit);
            //}

            comboBoxDeposito.Items.Clear();
            foreach (var deposito in listadepositos)
            {
                comboBoxDeposito.Items.Add(deposito);
            }
        }

        #endregion

        #region Validaciones Cantidad
        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir ingresar solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            string cantidadPreparacion = textBoxCantidad.Text;

        }

        #endregion

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (textBoxDNI.Text.Length > 8)
            {
                // If the length exceeds 8, truncate the text to 8 characters
                textBoxDNI.Text = textBoxDNI.Text.Substring(0, 8);

                // Move the cursor to the end of the text
                textBoxDNI.SelectionStart = textBoxDNI.Text.Length;
            }
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
        private void OrdenPreparacionForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BotonElegirDeposito_Click(object sender, EventArgs e)
        {
            string depositoSeleccionado = comboBoxDeposito.Text;
            string cuit = this.textBoxCUITCliente.Text;
            var listadepositos = modelo.ObtenerDepositosPorCliente(cuit);
            var deposito = listadepositos.FirstOrDefault(d => d.Equals(depositoSeleccionado, StringComparison.OrdinalIgnoreCase));

            if (depositoSeleccionado == null)
            {
                MessageBox.Show("Seleccione uno de los depósitos.");
                return;
            }
            else
            {
                //comboBoxMercaderiaSeleccionada.Items.Clear();
                ListaMercaderiaDeposito.Items.Clear();
                //var mercaderiasDelDeposito = Mercaderias.Where(m => m.NombreDeposito == depositoSeleccionado).ToList();
                var mercaderiasDelDeposito = modelo.ObtenerMercaderiaDelDeposito(textBoxCUITCliente.Text, depositoSeleccionado);

                foreach (var mercaderia in mercaderiasDelDeposito)
                {
                    string itemTexto = $"Unidades: {mercaderia.CantidadTotal} - Descripción: {mercaderia.Descripcion}";
                    ListaMercaderiaDeposito.Items.Add(itemTexto);
                }

                /* foreach (var mercaderia in mercaderiasDelDeposito)
                {
                    //comboBoxMercaderiaSeleccionada.Items.Add(mercaderia.Mercaderia);
                    ListaMercaderiaDeposito.Items.Add("Unidades: " + mercaderia.CantidadProducto + " - Descripción: " + mercaderia.DescProducto);
                }*/
            }
        }

        private int cantidadSeleccionada;

        private string descripcionSeleccionada;

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == null || ListaMercaderiaDeposito.SelectedItem == null)
            {
                MessageBox.Show("Ingrese Mercadería y cantidad.");
                return;
            }

            string mercaderiaSeleccionada = ListaMercaderiaDeposito.SelectedItem.ToString();
            string cantidadPrefix = "Unidades: ";
            int cantidadIndex = mercaderiaSeleccionada.IndexOf(cantidadPrefix);

            if (cantidadIndex != -1)
            {
                int separadorIndex = mercaderiaSeleccionada.IndexOf(" - ", cantidadIndex);
                string cantidadString = separadorIndex != -1 ?
                    mercaderiaSeleccionada.Substring(cantidadIndex + cantidadPrefix.Length, separadorIndex - (cantidadIndex + cantidadPrefix.Length)) :
                    mercaderiaSeleccionada.Substring(cantidadIndex + cantidadPrefix.Length);

                if (int.TryParse(cantidadString, out int cantidad))
                {
                    cantidadSeleccionada = cantidad;
                }

                string descripcionPrefix = "Descripción: ";
                int descripcionIndex = mercaderiaSeleccionada.IndexOf(descripcionPrefix);

                if (descripcionIndex != -1)
                {
                    descripcionSeleccionada = mercaderiaSeleccionada.Substring(descripcionIndex + descripcionPrefix.Length);
                }

                string cantidadPreparacion = textBoxCantidad.Text;
                string depositoSeleccionado = comboBoxDeposito.Text;

                var mercaderiasDelDeposito = modelo.ObtenerMercaderiaDelDeposito(textBoxCUITCliente.Text, depositoSeleccionado);

                int cantidadtotal = cantidadSeleccionada; //modelo.ObtenerCantidadPorDescripcion(mercaderiasDelDeposito, mercaderiaSeleccionada);

                if (int.TryParse(cantidadPreparacion, out int cantidadPreparacionInt))
                {
                    if (cantidadPreparacionInt > cantidadtotal)
                    {
                        MessageBox.Show($"Cantidad Insuficiente.");
                    }
                    else
                    {
                        ListaMercaderiaEnOrdenPreparacion.Items.Add(descripcionSeleccionada + " - " + cantidadPreparacion);
                        textBoxCantidad.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada no es válida.");
                }
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            ListaMercaderiaEnOrdenPreparacion.Items.Remove(ListaMercaderiaEnOrdenPreparacion.SelectedItem);
            ListaMercaderiaEnOrdenPreparacion.Refresh();
            textBoxCantidad.Clear();
        }

        private void botonCrearOrden_Click(object sender, EventArgs e)
        {
            if (comboBoxDeposito.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un deposito.");
                return;
            }
            if (ListaMercaderiaEnOrdenPreparacion.Items.Count == 0)
            {
                MessageBox.Show("Por favor, ingrese al menos un producto y cantidad a la orden.");
                return;
            }
            bool TorF = !int.TryParse(textBoxDNI.Text, out int dni);

            string depositoSeleccionado = comboBoxDeposito.Text;

            modelo.CrearOrdenYActualizarStock(textBoxCUITCliente.Text, dni, depositoSeleccionado, ListaMercaderiaEnOrdenPreparacion);

            textBoxCUITCliente.Clear();
            ListaMercaderiaEnOrdenPreparacion.Items.Clear();
            comboBoxDeposito.Items.Clear();
            comboBoxDeposito.ResetText();
            textBoxCantidad.Clear();
            textBoxRazonSocialCliente.Clear();
            textBoxFechaOrden.Clear();
            textBoxCódigoOrden.Clear();
            ListaMercaderiaDeposito.Items.Clear();
            groupBoxCliente.Enabled = true;
            groupBoxOrdenPreparación.Enabled = false;
        }

        private void botonEditarCliente_Click(object sender, EventArgs e)
        {
            textBoxCUITCliente.Clear();
            ListaMercaderiaEnOrdenPreparacion.Items.Clear();
            comboBoxDeposito.Items.Clear();
            comboBoxDeposito.ResetText();
            comboBoxDeposito.Items.Clear();
            textBoxCantidad.Clear();
            textBoxRazonSocialCliente.Clear();
            textBoxFechaOrden.Clear();
            textBoxCódigoOrden.Clear();
            ListaMercaderiaDeposito.Items.Clear();
            groupBoxCliente.Enabled = true;
            groupBoxOrdenPreparación.Enabled = false;
        }
    }
}
