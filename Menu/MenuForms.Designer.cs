namespace GrupoA.Prototipo
{
    partial class MenuForms
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
            groupBoxAreaPreparacion = new GroupBox();
            botonGenerarOrdenEntrega = new Button();
            botonGenerarOrdenSeleccion = new Button();
            buttonCargarOrdenPreparacion = new Button();
            label1 = new Label();
            groupBoxAlmacen = new GroupBox();
            botonRetiroStock = new Button();
            groupBoxDespacho = new GroupBox();
            botonDespachoSintranportista = new Button();
            botonCrearRemito = new Button();
            botonVerificarTransportista = new Button();
            groupBoxGestiónDepósitos = new GroupBox();
            botonSalir = new Button();
            EmpaquetarButton = new Button();
            groupBoxAreaPreparacion.SuspendLayout();
            groupBoxAlmacen.SuspendLayout();
            groupBoxDespacho.SuspendLayout();
            groupBoxGestiónDepósitos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAreaPreparacion
            // 
            groupBoxAreaPreparacion.Controls.Add(EmpaquetarButton);
            groupBoxAreaPreparacion.Controls.Add(botonGenerarOrdenEntrega);
            groupBoxAreaPreparacion.Controls.Add(botonGenerarOrdenSeleccion);
            groupBoxAreaPreparacion.Location = new Point(27, 110);
            groupBoxAreaPreparacion.Name = "groupBoxAreaPreparacion";
            groupBoxAreaPreparacion.Size = new Size(188, 123);
            groupBoxAreaPreparacion.TabIndex = 0;
            groupBoxAreaPreparacion.TabStop = false;
            groupBoxAreaPreparacion.Text = "Área de Preparación";
            // 
            // botonGenerarOrdenEntrega
            // 
            botonGenerarOrdenEntrega.Location = new Point(6, 54);
            botonGenerarOrdenEntrega.Name = "botonGenerarOrdenEntrega";
            botonGenerarOrdenEntrega.Size = new Size(173, 26);
            botonGenerarOrdenEntrega.TabIndex = 3;
            botonGenerarOrdenEntrega.Text = "Generar Orden de Entrega";
            botonGenerarOrdenEntrega.UseVisualStyleBackColor = true;
            botonGenerarOrdenEntrega.Click += botonGenerarOrdenEntrega_Click;
            // 
            // botonGenerarOrdenSeleccion
            // 
            botonGenerarOrdenSeleccion.Location = new Point(6, 22);
            botonGenerarOrdenSeleccion.Name = "botonGenerarOrdenSeleccion";
            botonGenerarOrdenSeleccion.Size = new Size(173, 26);
            botonGenerarOrdenSeleccion.TabIndex = 2;
            botonGenerarOrdenSeleccion.Text = "Generar Orden de Selección";
            botonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            botonGenerarOrdenSeleccion.Click += botonGenerarOrdenSeleccion_Click;
            // 
            // buttonCargarOrdenPreparacion
            // 
            buttonCargarOrdenPreparacion.Location = new Point(6, 22);
            buttonCargarOrdenPreparacion.Name = "buttonCargarOrdenPreparacion";
            buttonCargarOrdenPreparacion.Size = new Size(172, 26);
            buttonCargarOrdenPreparacion.TabIndex = 1;
            buttonCargarOrdenPreparacion.Text = "Cargar Orden de Preparación";
            buttonCargarOrdenPreparacion.UseVisualStyleBackColor = true;
            buttonCargarOrdenPreparacion.Click += buttonCargarOrdenPreparacion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 11);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 2;
            label1.Text = "Por favor, seleccione una opción";
            // 
            // groupBoxAlmacen
            // 
            groupBoxAlmacen.Controls.Add(botonRetiroStock);
            groupBoxAlmacen.Location = new Point(27, 239);
            groupBoxAlmacen.Name = "groupBoxAlmacen";
            groupBoxAlmacen.Size = new Size(188, 58);
            groupBoxAlmacen.TabIndex = 4;
            groupBoxAlmacen.TabStop = false;
            groupBoxAlmacen.Text = "Almacén";
            // 
            // botonRetiroStock
            // 
            botonRetiroStock.Location = new Point(6, 22);
            botonRetiroStock.Name = "botonRetiroStock";
            botonRetiroStock.Size = new Size(173, 26);
            botonRetiroStock.TabIndex = 2;
            botonRetiroStock.Text = "Retiro de stock";
            botonRetiroStock.UseVisualStyleBackColor = true;
            botonRetiroStock.Click += botonRetiroStock_Click;
            // 
            // groupBoxDespacho
            // 
            groupBoxDespacho.Controls.Add(botonDespachoSintranportista);
            groupBoxDespacho.Controls.Add(botonCrearRemito);
            groupBoxDespacho.Controls.Add(botonVerificarTransportista);
            groupBoxDespacho.Location = new Point(27, 303);
            groupBoxDespacho.Name = "groupBoxDespacho";
            groupBoxDespacho.Size = new Size(189, 120);
            groupBoxDespacho.TabIndex = 5;
            groupBoxDespacho.TabStop = false;
            groupBoxDespacho.Text = "Despacho";
            // 
            // botonDespachoSintranportista
            // 
            botonDespachoSintranportista.Location = new Point(7, 54);
            botonDespachoSintranportista.Name = "botonDespachoSintranportista";
            botonDespachoSintranportista.Size = new Size(173, 26);
            botonDespachoSintranportista.TabIndex = 6;
            botonDespachoSintranportista.Text = "Despacho Sin Trasportista";
            botonDespachoSintranportista.UseVisualStyleBackColor = true;
            botonDespachoSintranportista.Click += botonDespachoSintranportista_Click;
            // 
            // botonCrearRemito
            // 
            botonCrearRemito.Location = new Point(7, 86);
            botonCrearRemito.Name = "botonCrearRemito";
            botonCrearRemito.Size = new Size(173, 26);
            botonCrearRemito.TabIndex = 5;
            botonCrearRemito.Text = "Crear Remito";
            botonCrearRemito.UseVisualStyleBackColor = true;
            botonCrearRemito.Click += botonCrearRemito_Click;
            // 
            // botonVerificarTransportista
            // 
            botonVerificarTransportista.Location = new Point(6, 22);
            botonVerificarTransportista.Name = "botonVerificarTransportista";
            botonVerificarTransportista.Size = new Size(173, 26);
            botonVerificarTransportista.TabIndex = 4;
            botonVerificarTransportista.Text = "Verificar Transportista";
            botonVerificarTransportista.UseVisualStyleBackColor = true;
            botonVerificarTransportista.Click += botonVerificarTransportista_Click;
            // 
            // groupBoxGestiónDepósitos
            // 
            groupBoxGestiónDepósitos.Controls.Add(buttonCargarOrdenPreparacion);
            groupBoxGestiónDepósitos.Location = new Point(27, 37);
            groupBoxGestiónDepósitos.Name = "groupBoxGestiónDepósitos";
            groupBoxGestiónDepósitos.Size = new Size(188, 56);
            groupBoxGestiónDepósitos.TabIndex = 6;
            groupBoxGestiónDepósitos.TabStop = false;
            groupBoxGestiónDepósitos.Text = "Gestión de depósitos";
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(33, 440);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(173, 26);
            botonSalir.TabIndex = 6;
            botonSalir.Text = "Salir";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += botonSalir_Click;
            // 
            // EmpaquetarButton
            // 
            EmpaquetarButton.Location = new Point(5, 86);
            EmpaquetarButton.Name = "EmpaquetarButton";
            EmpaquetarButton.Size = new Size(173, 26);
            EmpaquetarButton.TabIndex = 4;
            EmpaquetarButton.Text = "Empaquetar";
            EmpaquetarButton.UseVisualStyleBackColor = true;
            // 
            // MenuForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 438);
            Controls.Add(botonSalir);
            Controls.Add(groupBoxGestiónDepósitos);
            Controls.Add(groupBoxDespacho);
            Controls.Add(groupBoxAlmacen);
            Controls.Add(label1);
            Controls.Add(groupBoxAreaPreparacion);
            Name = "MenuForms";
            Text = "MenuForms";
            groupBoxAreaPreparacion.ResumeLayout(false);
            groupBoxAlmacen.ResumeLayout(false);
            groupBoxDespacho.ResumeLayout(false);
            groupBoxGestiónDepósitos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxAreaPreparacion;
        private Button botonGenerarOrdenEntrega;
        private Button botonGenerarOrdenSeleccion;
        private Button buttonCargarOrdenPreparacion;
        private Label label1;
        private GroupBox groupBoxAlmacen;
        private Button botonRetiroStock;
        private GroupBox groupBoxDespacho;
        private Button botonCrearRemito;
        private Button botonVerificarTransportista;
        private GroupBox groupBoxGestiónDepósitos;
        private Button botonSalir;
        private Button botonDespachoSintranportista;
        private Button EmpaquetarButton;
    }
}