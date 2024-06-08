using GrupoA.Prototipo.OrdenPreparacion;

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

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir ingresar solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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
    }
}
