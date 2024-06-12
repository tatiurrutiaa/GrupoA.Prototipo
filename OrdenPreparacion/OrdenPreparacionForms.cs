using GrupoA.Prototipo.EmpaquetarMercaderia;
using GrupoA.Prototipo.OrdenPreparacion;
using GrupoA.Prototipo.RetiroStock;
using System.Windows.Forms;

namespace GrupoA.Prototipo
{
    public partial class OrdenPreparacionForms : Form
    {
        OrdenPreparacionModel modelo;
        public OrdenPreparacionForms()
        {
            InitializeComponent();
            CargarDepositosComboBox();
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
            string text = textBoxCUITCliente.Text;
            int length = text.Length;

            // Evitar recursión infinita
            textBoxCUITCliente.TextChanged -= textBoxCUITCliente_TextChanged;

            // Aplicar el formato 00-00000000-0
            if (length == 2 && !text.Contains("-"))
            {
                textBoxCUITCliente.Text = text.Insert(2, "-");
                textBoxCUITCliente.SelectionStart = textBoxCUITCliente.Text.Length;
            }
            else if (length == 11 && text[10] != '-')
            {
                textBoxCUITCliente.Text = text.Insert(10, "-");
                textBoxCUITCliente.SelectionStart = textBoxCUITCliente.Text.Length;
            }
            else if (length > 13)
            {
                textBoxCUITCliente.Text = text.Substring(0, 13);
                textBoxCUITCliente.SelectionStart = textBoxCUITCliente.Text.Length;
            }

            // Reasociar el evento
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

            textBoxFechaOrden.Text = DateTime.Now.ToString("dd-MM-yyyy");

            //cargar depositos y mercadería
        }

        #endregion

        #region Listas  

        public List<MercaderiasDetalle> Mercaderias = new()
        {
            new MercaderiasDetalle { IdProducto = 1 , Mercaderia = "bolsas de cemento", CantidadProducto = 700,   NombreDeposito = "Almacén Central"},
            new MercaderiasDetalle { IdProducto = 2 , Mercaderia = "ladrillos",         CantidadProducto = 500,   NombreDeposito = "Almacén Central"},
            new MercaderiasDetalle { IdProducto = 3 , Mercaderia = "cemento cola",      CantidadProducto = 300,   NombreDeposito = "Almacén Central"},
            new MercaderiasDetalle { IdProducto = 5 , Mercaderia = "bolsas de arena",   CantidadProducto = 1000,  NombreDeposito = "Depósito Norte"},
            new MercaderiasDetalle { IdProducto = 6 , Mercaderia = "bolsas de cal",     CantidadProducto = 800,   NombreDeposito = "Depósito Norte"},
            new MercaderiasDetalle { IdProducto = 7 , Mercaderia = "vigas de madera",   CantidadProducto = 200,   NombreDeposito = "Depósito Norte"},
            new MercaderiasDetalle { IdProducto = 8 , Mercaderia = "tejas",             CantidadProducto = 400,   NombreDeposito = "Centro de Distribución Sur"},
            new MercaderiasDetalle { IdProducto = 9 , Mercaderia = "cable eléctrico",   CantidadProducto = 600,   NombreDeposito = "Centro de Distribución Sur"},
            new MercaderiasDetalle { IdProducto = 10 , Mercaderia = "tubos de PVC",      CantidadProducto = 300,   NombreDeposito = "Centro de Distribución Sur"}
        };
        public List<Deposito> Depositos = new()
        {
            new Deposito { NumDeposito = 1 , NombreDeposito = "Almacén Central"},
            new Deposito { NumDeposito = 2 , NombreDeposito = "Depósito Norte"},
            new Deposito { NumDeposito = 3 , NombreDeposito = "Centro de Distribución Sur"},

        };

        #endregion

        #region Muestra Depositos
        private void CargarDepositosComboBox()
        {
            comboBoxDeposito.Items.Clear();
            foreach (var deposito in Depositos)
            {
                comboBoxDeposito.Items.Add(deposito.NombreDeposito);// + "-" + deposito.NombreDeposito);
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
            var deposito = Depositos.FirstOrDefault(d => d.NombreDeposito.Equals(depositoSeleccionado, StringComparison.OrdinalIgnoreCase));

            if (depositoSeleccionado == null)
            {
                MessageBox.Show("Seleccione uno de los depósitos.");
                return;
            }
            else
            {
                //comboBoxMercaderiaSeleccionada.Items.Clear();
                ListaMercaderiaDeposito.Items.Clear();
                var mercaderiasDelDeposito = Mercaderias.Where(m => m.NombreDeposito == depositoSeleccionado).ToList();

                foreach (var mercaderia in mercaderiasDelDeposito)
                {
                    //comboBoxMercaderiaSeleccionada.Items.Add(mercaderia.Mercaderia);
                    ListaMercaderiaDeposito.Items.Add("Unidades: " + mercaderia.CantidadProducto + " - Descripción: " + mercaderia.Mercaderia);
                }

            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            string mercaderiaSeleccionada = ListaMercaderiaDeposito.ToString();
            string cantidadPreparacion = textBoxCantidad.Text;

            if ((string.IsNullOrEmpty(cantidadPreparacion)) || string.IsNullOrEmpty(mercaderiaSeleccionada))
            {
                MessageBox.Show("Ingrese Mercadería y cantidad.");
            }
            else
            {
                mercaderiaSeleccionada = ListaMercaderiaDeposito.SelectedItem.ToString();
                if (int.Parse(cantidadPreparacion) >= 200)
                {
                    MessageBox.Show("Cantidad Insuficiente.");
                }
                else
                {
                    //actualizar mercaderia a estado Comprometido
                    ListaMercaderiaEnOrdenPreparacion.Items.Add(mercaderiaSeleccionada + " - " + cantidadPreparacion);
                    textBoxCantidad.Clear();
                }
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            ListaMercaderiaEnOrdenPreparacion.Items.Remove(ListaMercaderiaEnOrdenPreparacion.SelectedItem);
            ListaMercaderiaEnOrdenPreparacion.Refresh();
            textBoxCantidad.Clear();
        }
    }
}