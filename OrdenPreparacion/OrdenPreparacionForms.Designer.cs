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
            botonAtras = new Button();
            botonSiguiente = new Button();
            textBoxRazonSocialCliente = new TextBox();
            labelRazonSocial = new Label();
            groupBoxOrdenPreparación = new GroupBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label5 = new Label();
            textBoxCantidad4 = new TextBox();
            comboBoxMercaderia4 = new ComboBox();
            textBoxCantidad3 = new TextBox();
            comboBoxMercaderia3 = new ComboBox();
            textBoxCantidad2 = new TextBox();
            comboBoxMercaderia2 = new ComboBox();
            textBoxCantidad1 = new TextBox();
            Cantid = new Label();
            comboBoxMercaderia1 = new ComboBox();
            label6 = new Label();
            textBoxFechaEntrega = new TextBox();
            label4 = new Label();
            comboBoxDepósito = new ComboBox();
            label3 = new Label();
            botonAceptar = new Button();
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
            groupBoxCliente.Controls.Add(botonAtras);
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
            // botonAtras
            // 
            botonAtras.Location = new Point(210, 72);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(75, 23);
            botonAtras.TabIndex = 24;
            botonAtras.Text = "Atrás";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += botonAtras_Click;
            // 
            // botonSiguiente
            // 
            botonSiguiente.Location = new Point(289, 72);
            botonSiguiente.Name = "botonSiguiente";
            botonSiguiente.Size = new Size(75, 23);
            botonSiguiente.TabIndex = 4;
            botonSiguiente.Text = "Siguiente";
            botonSiguiente.UseVisualStyleBackColor = true;
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
            // groupBoxOrdenPreparación
            // 
            groupBoxOrdenPreparación.Controls.Add(textBox2);
            groupBoxOrdenPreparación.Controls.Add(label8);
            groupBoxOrdenPreparación.Controls.Add(label5);
            groupBoxOrdenPreparación.Controls.Add(textBoxCantidad4);
            groupBoxOrdenPreparación.Controls.Add(comboBoxMercaderia4);
            groupBoxOrdenPreparación.Controls.Add(textBoxCantidad3);
            groupBoxOrdenPreparación.Controls.Add(comboBoxMercaderia3);
            groupBoxOrdenPreparación.Controls.Add(textBoxCantidad2);
            groupBoxOrdenPreparación.Controls.Add(comboBoxMercaderia2);
            groupBoxOrdenPreparación.Controls.Add(textBoxCantidad1);
            groupBoxOrdenPreparación.Controls.Add(Cantid);
            groupBoxOrdenPreparación.Controls.Add(comboBoxMercaderia1);
            groupBoxOrdenPreparación.Controls.Add(label6);
            groupBoxOrdenPreparación.Controls.Add(textBoxFechaEntrega);
            groupBoxOrdenPreparación.Controls.Add(label4);
            groupBoxOrdenPreparación.Controls.Add(comboBoxDepósito);
            groupBoxOrdenPreparación.Controls.Add(label3);
            groupBoxOrdenPreparación.Controls.Add(botonAceptar);
            groupBoxOrdenPreparación.Controls.Add(textBoxFechaOrden);
            groupBoxOrdenPreparación.Controls.Add(label1);
            groupBoxOrdenPreparación.Controls.Add(textBoxCódigoOrden);
            groupBoxOrdenPreparación.Controls.Add(label2);
            groupBoxOrdenPreparación.Enabled = false;
            groupBoxOrdenPreparación.Location = new Point(12, 130);
            groupBoxOrdenPreparación.Name = "groupBoxOrdenPreparación";
            groupBoxOrdenPreparación.Size = new Size(378, 334);
            groupBoxOrdenPreparación.TabIndex = 5;
            groupBoxOrdenPreparación.TabStop = false;
            groupBoxOrdenPreparación.Text = "Orden de preparación";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 300);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 282);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 22;
            label8.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 259);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 20;
            label5.Text = "Datos del transportista";
            // 
            // textBoxCantidad4
            // 
            textBoxCantidad4.Location = new Point(287, 221);
            textBoxCantidad4.Name = "textBoxCantidad4";
            textBoxCantidad4.Size = new Size(77, 23);
            textBoxCantidad4.TabIndex = 19;
            // 
            // comboBoxMercaderia4
            // 
            comboBoxMercaderia4.FormattingEnabled = true;
            comboBoxMercaderia4.Location = new Point(6, 221);
            comboBoxMercaderia4.Name = "comboBoxMercaderia4";
            comboBoxMercaderia4.Size = new Size(275, 23);
            comboBoxMercaderia4.TabIndex = 18;
            // 
            // textBoxCantidad3
            // 
            textBoxCantidad3.Location = new Point(287, 192);
            textBoxCantidad3.Name = "textBoxCantidad3";
            textBoxCantidad3.Size = new Size(77, 23);
            textBoxCantidad3.TabIndex = 17;
            // 
            // comboBoxMercaderia3
            // 
            comboBoxMercaderia3.FormattingEnabled = true;
            comboBoxMercaderia3.Location = new Point(6, 192);
            comboBoxMercaderia3.Name = "comboBoxMercaderia3";
            comboBoxMercaderia3.Size = new Size(275, 23);
            comboBoxMercaderia3.TabIndex = 16;
            // 
            // textBoxCantidad2
            // 
            textBoxCantidad2.Location = new Point(287, 163);
            textBoxCantidad2.Name = "textBoxCantidad2";
            textBoxCantidad2.Size = new Size(77, 23);
            textBoxCantidad2.TabIndex = 15;
            textBoxCantidad2.TextChanged += textBox1_TextChanged;
            // 
            // comboBoxMercaderia2
            // 
            comboBoxMercaderia2.FormattingEnabled = true;
            comboBoxMercaderia2.Location = new Point(6, 163);
            comboBoxMercaderia2.Name = "comboBoxMercaderia2";
            comboBoxMercaderia2.Size = new Size(275, 23);
            comboBoxMercaderia2.TabIndex = 14;
            // 
            // textBoxCantidad1
            // 
            textBoxCantidad1.Location = new Point(287, 134);
            textBoxCantidad1.Name = "textBoxCantidad1";
            textBoxCantidad1.Size = new Size(77, 23);
            textBoxCantidad1.TabIndex = 12;
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
            // comboBoxMercaderia1
            // 
            comboBoxMercaderia1.FormattingEnabled = true;
            comboBoxMercaderia1.Location = new Point(6, 134);
            comboBoxMercaderia1.Name = "comboBoxMercaderia1";
            comboBoxMercaderia1.Size = new Size(275, 23);
            comboBoxMercaderia1.TabIndex = 11;
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
            // textBoxFechaEntrega
            // 
            textBoxFechaEntrega.Location = new Point(188, 87);
            textBoxFechaEntrega.Name = "textBoxFechaEntrega";
            textBoxFechaEntrega.Size = new Size(176, 23);
            textBoxFechaEntrega.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 69);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 9;
            label4.Text = "Fecha de entrega";
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
            // botonAceptar
            // 
            botonAceptar.Location = new Point(289, 300);
            botonAceptar.Name = "botonAceptar";
            botonAceptar.Size = new Size(75, 23);
            botonAceptar.TabIndex = 4;
            botonAceptar.Text = "Aceptar";
            botonAceptar.UseVisualStyleBackColor = true;
            // 
            // textBoxFechaOrden
            // 
            textBoxFechaOrden.Location = new Point(188, 43);
            textBoxFechaOrden.Name = "textBoxFechaOrden";
            textBoxFechaOrden.Size = new Size(176, 23);
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
            ClientSize = new Size(396, 472);
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
        private Button botonAceptar;
        private TextBox textBoxFechaOrden;
        private Label label1;
        private TextBox textBoxCódigoOrden;
        private Label label2;
        private TextBox textBoxCantidad4;
        private ComboBox comboBoxMercaderia4;
        private TextBox textBoxCantidad3;
        private ComboBox comboBoxMercaderia3;
        private TextBox textBoxCantidad2;
        private ComboBox comboBoxMercaderia2;
        private TextBox textBoxCantidad1;
        private Label Cantid;
        private ComboBox comboBoxMercaderia1;
        private Label label6;
        private TextBox textBoxFechaEntrega;
        private Label label4;
        private TextBox textBox2;
        private Label label8;
        private Label label5;
        private Button botonAtras;
    }
}