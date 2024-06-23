namespace GrupoA.Prototipo
{
    partial class OrdenPreparacionForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCUITCliente = new TextBox();
            labelCUITCliente = new Label();
            groupBoxCliente = new GroupBox();
            botonSiguiente = new Button();
            textBoxRazonSocialCliente = new TextBox();
            labelRazonSocial = new Label();
            botonMenu = new Button();
            groupBoxOrdenPreparación = new GroupBox();
            label7 = new Label();
            ListaMercaderiaEnOrdenPreparacion = new ListBox();
            label4 = new Label();
            BotonElegirDeposito = new Button();
            botonEditarCliente = new Button();
            botonEliminar = new Button();
            botonAgregar = new Button();
            ListaMercaderiaDeposito = new ListBox();
            textBoxDNI = new TextBox();
            label8 = new Label();
            label5 = new Label();
            textBoxCantidad = new TextBox();
            Cantid = new Label();
            comboBoxDeposito = new ComboBox();
            label3 = new Label();
            botonCrearOrden = new Button();
            textBoxFechaOrden = new TextBox();
            label1 = new Label();
            textBoxCódigoOrden = new TextBox();
            label2 = new Label();
            groupBoxCliente.SuspendLayout();
            groupBoxOrdenPreparación.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCUITCliente
            // 
            textBoxCUITCliente.Location = new Point(6, 43);
            textBoxCUITCliente.Name = "textBoxCUITCliente";
            textBoxCUITCliente.Size = new Size(176, 23);
            textBoxCUITCliente.TabIndex = 0;
            textBoxCUITCliente.TextChanged += textBoxCUITCliente_TextChanged;
            textBoxCUITCliente.KeyPress += textBoxCUITCliente_KeyPress;
            // 
            // labelCUITCliente
            // 
            labelCUITCliente.AutoSize = true;
            labelCUITCliente.Location = new Point(6, 25);
            labelCUITCliente.Name = "labelCUITCliente";
            labelCUITCliente.Size = new Size(32, 15);
            labelCUITCliente.TabIndex = 1;
            labelCUITCliente.Text = "CUIT";
            // 
            // groupBoxCliente
            // 
            groupBoxCliente.Controls.Add(botonSiguiente);
            groupBoxCliente.Controls.Add(textBoxRazonSocialCliente);
            groupBoxCliente.Controls.Add(labelRazonSocial);
            groupBoxCliente.Controls.Add(textBoxCUITCliente);
            groupBoxCliente.Controls.Add(labelCUITCliente);
            groupBoxCliente.Location = new Point(12, 12);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Size = new Size(378, 104);
            groupBoxCliente.TabIndex = 2;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = "Cliente";
            groupBoxCliente.Enter += groupBoxCliente_Enter;
            // 
            // botonSiguiente
            // 
            botonSiguiente.Location = new Point(295, 72);
            botonSiguiente.Name = "botonSiguiente";
            botonSiguiente.Size = new Size(75, 23);
            botonSiguiente.TabIndex = 4;
            botonSiguiente.Text = "Siguiente";
            botonSiguiente.UseVisualStyleBackColor = true;
            botonSiguiente.Click += botonSiguiente_Click;
            // 
            // textBoxRazonSocialCliente
            // 
            textBoxRazonSocialCliente.Enabled = false;
            textBoxRazonSocialCliente.Location = new Point(194, 43);
            textBoxRazonSocialCliente.Name = "textBoxRazonSocialCliente";
            textBoxRazonSocialCliente.Size = new Size(176, 23);
            textBoxRazonSocialCliente.TabIndex = 2;
            // 
            // labelRazonSocial
            // 
            labelRazonSocial.AutoSize = true;
            labelRazonSocial.Location = new Point(188, 25);
            labelRazonSocial.Name = "labelRazonSocial";
            labelRazonSocial.Size = new Size(73, 15);
            labelRazonSocial.TabIndex = 3;
            labelRazonSocial.Text = "Razón Social";
            // 
            // botonMenu
            // 
            botonMenu.Location = new Point(18, 622);
            botonMenu.Name = "botonMenu";
            botonMenu.Size = new Size(106, 23);
            botonMenu.TabIndex = 24;
            botonMenu.Text = "Volver al Menu";
            botonMenu.UseVisualStyleBackColor = true;
            botonMenu.Click += botonMenu_Click;
            // 
            // groupBoxOrdenPreparación
            // 
            groupBoxOrdenPreparación.Controls.Add(label7);
            groupBoxOrdenPreparación.Controls.Add(ListaMercaderiaEnOrdenPreparacion);
            groupBoxOrdenPreparación.Controls.Add(label4);
            groupBoxOrdenPreparación.Controls.Add(BotonElegirDeposito);
            groupBoxOrdenPreparación.Controls.Add(botonEditarCliente);
            groupBoxOrdenPreparación.Controls.Add(botonEliminar);
            groupBoxOrdenPreparación.Controls.Add(botonAgregar);
            groupBoxOrdenPreparación.Controls.Add(ListaMercaderiaDeposito);
            groupBoxOrdenPreparación.Controls.Add(textBoxDNI);
            groupBoxOrdenPreparación.Controls.Add(label8);
            groupBoxOrdenPreparación.Controls.Add(label5);
            groupBoxOrdenPreparación.Controls.Add(textBoxCantidad);
            groupBoxOrdenPreparación.Controls.Add(Cantid);
            groupBoxOrdenPreparación.Controls.Add(comboBoxDeposito);
            groupBoxOrdenPreparación.Controls.Add(label3);
            groupBoxOrdenPreparación.Controls.Add(botonCrearOrden);
            groupBoxOrdenPreparación.Controls.Add(textBoxFechaOrden);
            groupBoxOrdenPreparación.Controls.Add(label1);
            groupBoxOrdenPreparación.Controls.Add(textBoxCódigoOrden);
            groupBoxOrdenPreparación.Controls.Add(label2);
            groupBoxOrdenPreparación.Enabled = false;
            groupBoxOrdenPreparación.Location = new Point(12, 130);
            groupBoxOrdenPreparación.Name = "groupBoxOrdenPreparación";
            groupBoxOrdenPreparación.Size = new Size(577, 486);
            groupBoxOrdenPreparación.TabIndex = 5;
            groupBoxOrdenPreparación.TabStop = false;
            groupBoxOrdenPreparación.Text = "Orden de preparación";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 239);
            label7.Name = "label7";
            label7.Size = new Size(150, 15);
            label7.TabIndex = 30;
            label7.Text = "Mercaderías seleccionadas:";
            // 
            // ListaMercaderiaEnOrdenPreparacion
            // 
            ListaMercaderiaEnOrdenPreparacion.FormattingEnabled = true;
            ListaMercaderiaEnOrdenPreparacion.ItemHeight = 15;
            ListaMercaderiaEnOrdenPreparacion.Location = new Point(6, 258);
            ListaMercaderiaEnOrdenPreparacion.Name = "ListaMercaderiaEnOrdenPreparacion";
            ListaMercaderiaEnOrdenPreparacion.Size = new Size(364, 94);
            ListaMercaderiaEnOrdenPreparacion.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 94);
            label4.Name = "label4";
            label4.Size = new Size(265, 15);
            label4.TabIndex = 28;
            label4.Text = "Mercadería disponible en Depósito seleccionado:";
            // 
            // BotonElegirDeposito
            // 
            BotonElegirDeposito.Location = new Point(483, 72);
            BotonElegirDeposito.Name = "BotonElegirDeposito";
            BotonElegirDeposito.Size = new Size(83, 23);
            BotonElegirDeposito.TabIndex = 27;
            BotonElegirDeposito.Text = "Seleccionar";
            BotonElegirDeposito.UseVisualStyleBackColor = true;
            BotonElegirDeposito.Click += BotonElegirDeposito_Click;
            // 
            // botonEditarCliente
            // 
            botonEditarCliente.Location = new Point(11, 425);
            botonEditarCliente.Name = "botonEditarCliente";
            botonEditarCliente.Size = new Size(106, 35);
            botonEditarCliente.TabIndex = 26;
            botonEditarCliente.Text = "Editar Cliente";
            botonEditarCliente.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(378, 284);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(188, 29);
            botonEliminar.TabIndex = 25;
            botonEliminar.Text = "Eliminar de Orden";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(378, 168);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(188, 30);
            botonAgregar.TabIndex = 24;
            botonAgregar.Text = "Agregar a Orden";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // ListaMercaderiaDeposito
            // 
            ListaMercaderiaDeposito.FormattingEnabled = true;
            ListaMercaderiaDeposito.ItemHeight = 15;
            ListaMercaderiaDeposito.Location = new Point(6, 112);
            ListaMercaderiaDeposito.Name = "ListaMercaderiaDeposito";
            ListaMercaderiaDeposito.Size = new Size(364, 124);
            ListaMercaderiaDeposito.TabIndex = 23;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(50, 393);
            textBoxDNI.MaxLength = 8;
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(176, 23);
            textBoxDNI.TabIndex = 21;
            textBoxDNI.KeyPress += textBoxDNI_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 396);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 22;
            label8.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 370);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 20;
            label5.Text = "Datos del transportista";
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(378, 130);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(83, 23);
            textBoxCantidad.TabIndex = 12;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            textBoxCantidad.KeyPress += textBoxCantidad_KeyPress;
            // 
            // Cantid
            // 
            Cantid.AutoSize = true;
            Cantid.Location = new Point(378, 112);
            Cantid.Name = "Cantid";
            Cantid.Size = new Size(97, 15);
            Cantid.TabIndex = 13;
            Cantid.Text = "Ingrese cantidad:";
            // 
            // comboBoxDeposito
            // 
            comboBoxDeposito.FormattingEnabled = true;
            comboBoxDeposito.Items.AddRange(new object[] { "1", "2" });
            comboBoxDeposito.Location = new Point(376, 43);
            comboBoxDeposito.Name = "comboBoxDeposito";
            comboBoxDeposito.Size = new Size(190, 23);
            comboBoxDeposito.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 25);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Elija un Depósito:";
            // 
            // botonCrearOrden
            // 
            botonCrearOrden.Location = new Point(207, 425);
            botonCrearOrden.Name = "botonCrearOrden";
            botonCrearOrden.Size = new Size(364, 35);
            botonCrearOrden.TabIndex = 4;
            botonCrearOrden.Text = "Crear Orden";
            botonCrearOrden.UseVisualStyleBackColor = true;
            botonCrearOrden.Click += botonCrearOrden_Click;
            // 
            // textBoxFechaOrden
            // 
            textBoxFechaOrden.Enabled = false;
            textBoxFechaOrden.Location = new Point(188, 43);
            textBoxFechaOrden.Name = "textBoxFechaOrden";
            textBoxFechaOrden.Size = new Size(182, 23);
            textBoxFechaOrden.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Fecha";
            // 
            // textBoxCódigoOrden
            // 
            textBoxCódigoOrden.Enabled = false;
            textBoxCódigoOrden.Location = new Point(6, 43);
            textBoxCódigoOrden.Name = "textBoxCódigoOrden";
            textBoxCódigoOrden.Size = new Size(176, 23);
            textBoxCódigoOrden.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Código de Orden";
            // 
            // OrdenPreparacionForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 655);
            Controls.Add(botonMenu);
            Controls.Add(groupBoxOrdenPreparación);
            Controls.Add(groupBoxCliente);
            Name = "OrdenPreparacionForms";
            Text = "Orden de Preparación";
            FormClosed += OrdenPreparacionForms_FormClosed;
            Load += OrdenPreparaciónForms_Load;
            groupBoxCliente.ResumeLayout(false);
            groupBoxCliente.PerformLayout();
            groupBoxOrdenPreparación.ResumeLayout(false);
            groupBoxOrdenPreparación.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxCUITCliente;
        private Label labelCUITCliente;
        private GroupBox groupBoxCliente;
        private TextBox textBoxRazonSocialCliente;
        private Label labelRazonSocial;
        private Button botonSiguiente;
        private GroupBox groupBoxOrdenPreparación;
        private ComboBox comboBoxDeposito;
        private Label label3;
        private Button botonCrearOrden;
        private TextBox textBoxFechaOrden;
        private Label label1;
        private TextBox textBoxCódigoOrden;
        private Label label2;
        private TextBox textBoxCantidad;
        private Label Cantid;
        private TextBox textBoxDNI;
        private Label label8;
        private Label label5;
        private Button botonMenu;
        private Button botonEliminar;
        private Button botonAgregar;
        private ListBox ListaMercaderiaDeposito;
        private Button botonEditarCliente;
        private Button BotonElegirDeposito;
        private Label label4;
        private Label label7;
        private ListBox ListaMercaderiaEnOrdenPreparacion;
    }
}