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
            botonEditarCliente = new Button();
            botonEliminar = new Button();
            botonAgregar = new Button();
            listBox1 = new ListBox();
            textBoxDNI = new TextBox();
            label8 = new Label();
            label5 = new Label();
            textBoxCantidad = new TextBox();
            Cantid = new Label();
            comboBoxMercaderia = new ComboBox();
            label6 = new Label();
            comboBoxDepósito = new ComboBox();
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
            groupBoxOrdenPreparación.Controls.Add(botonEditarCliente);
            groupBoxOrdenPreparación.Controls.Add(botonEliminar);
            groupBoxOrdenPreparación.Controls.Add(botonAgregar);
            groupBoxOrdenPreparación.Controls.Add(listBox1);
            groupBoxOrdenPreparación.Controls.Add(textBoxDNI);
            groupBoxOrdenPreparación.Controls.Add(label8);
            groupBoxOrdenPreparación.Controls.Add(label5);
            groupBoxOrdenPreparación.Controls.Add(textBoxCantidad);
            groupBoxOrdenPreparación.Controls.Add(Cantid);
            groupBoxOrdenPreparación.Controls.Add(comboBoxMercaderia);
            groupBoxOrdenPreparación.Controls.Add(label6);
            groupBoxOrdenPreparación.Controls.Add(comboBoxDepósito);
            groupBoxOrdenPreparación.Controls.Add(label3);
            groupBoxOrdenPreparación.Controls.Add(botonCrearOrden);
            groupBoxOrdenPreparación.Controls.Add(textBoxFechaOrden);
            groupBoxOrdenPreparación.Controls.Add(label1);
            groupBoxOrdenPreparación.Controls.Add(textBoxCódigoOrden);
            groupBoxOrdenPreparación.Controls.Add(label2);
            groupBoxOrdenPreparación.Enabled = false;
            groupBoxOrdenPreparación.Location = new Point(12, 130);
            groupBoxOrdenPreparación.Name = "groupBoxOrdenPreparación";
            groupBoxOrdenPreparación.Size = new Size(378, 486);
            groupBoxOrdenPreparación.TabIndex = 5;
            groupBoxOrdenPreparación.TabStop = false;
            groupBoxOrdenPreparación.Text = "Orden de preparación";
            // 
            // botonEditarCliente
            // 
            botonEditarCliente.Location = new Point(6, 455);
            botonEditarCliente.Name = "botonEditarCliente";
            botonEditarCliente.Size = new Size(106, 23);
            botonEditarCliente.TabIndex = 26;
            botonEditarCliente.Text = "Editar Cliente";
            botonEditarCliente.UseVisualStyleBackColor = true;
            //botonEditarCliente.Click += botonEditarCliente_Click;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(6, 163);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(75, 23);
            botonEliminar.TabIndex = 25;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(287, 163);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(83, 23);
            botonAgregar.TabIndex = 24;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 198);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(364, 154);
            listBox1.TabIndex = 23;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(6, 396);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(176, 23);
            textBoxDNI.TabIndex = 21;
            textBoxDNI.KeyPress += textBoxDNI_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 378);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 22;
            label8.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 355);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 20;
            label5.Text = "Datos del transportista";
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(287, 134);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(83, 23);
            textBoxCantidad.TabIndex = 12;
            textBoxCantidad.KeyPress += textBoxCantidad_KeyPress;
            // 
            // Cantid
            // 
            Cantid.AutoSize = true;
            Cantid.Location = new Point(287, 113);
            Cantid.Name = "Cantid";
            Cantid.Size = new Size(55, 15);
            Cantid.TabIndex = 13;
            Cantid.Text = "Cantidad";
            // 
            // comboBoxMercaderia
            // 
            comboBoxMercaderia.FormattingEnabled = true;
            comboBoxMercaderia.Location = new Point(6, 134);
            comboBoxMercaderia.Name = "comboBoxMercaderia";
            comboBoxMercaderia.Size = new Size(275, 23);
            comboBoxMercaderia.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 116);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 10;
            label6.Text = "Mercadería";
            // 
            // comboBoxDepósito
            // 
            comboBoxDepósito.FormattingEnabled = true;
            comboBoxDepósito.Location = new Point(6, 87);
            comboBoxDepósito.Name = "comboBoxDepósito";
            comboBoxDepósito.Size = new Size(176, 23);
            comboBoxDepósito.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 69);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Depósito";
            // 
            // botonCrearOrden
            // 
            botonCrearOrden.Location = new Point(6, 426);
            botonCrearOrden.Name = "botonCrearOrden";
            botonCrearOrden.Size = new Size(364, 23);
            botonCrearOrden.TabIndex = 4;
            botonCrearOrden.Text = "Crear Orden";
            botonCrearOrden.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(398, 655);
            Controls.Add(botonMenu);
            Controls.Add(groupBoxOrdenPreparación);
            Controls.Add(groupBoxCliente);
            Name = "OrdenPreparacionForms";
            Text = "Orden de Preparación";
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
        private ComboBox comboBoxDepósito;
        private Label label3;
        private Button botonCrearOrden;
        private TextBox textBoxFechaOrden;
        private Label label1;
        private TextBox textBoxCódigoOrden;
        private Label label2;
        private TextBox textBoxCantidad;
        private Label Cantid;
        private ComboBox comboBoxMercaderia;
        private Label label6;
        private TextBox textBoxDNI;
        private Label label8;
        private Label label5;
        private Button botonMenu;
        private Button botonEliminar;
        private Button botonAgregar;
        private ListBox listBox1;
        private Button botonEditarCliente;
    }
}