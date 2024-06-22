namespace GrupoA.Prototipo.OrdenSeleccion
{
    partial class OrdenSeleccionForm
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
            groupBoxOrdendeEntrega = new GroupBox();
            ListBoxOrdenesPrep = new CheckedListBox();
            botonGenerarOrdenSeleccion = new Button();
            botonMenu = new Button();
            groupBoxOrdendeEntrega.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOrdendeEntrega
            // 
            groupBoxOrdendeEntrega.Controls.Add(ListBoxOrdenesPrep);
            groupBoxOrdendeEntrega.Controls.Add(botonGenerarOrdenSeleccion);
            groupBoxOrdendeEntrega.Location = new Point(11, 11);
            groupBoxOrdendeEntrega.Margin = new Padding(2);
            groupBoxOrdendeEntrega.Name = "groupBoxOrdendeEntrega";
            groupBoxOrdendeEntrega.Padding = new Padding(2);
            groupBoxOrdendeEntrega.Size = new Size(243, 312);
            groupBoxOrdendeEntrega.TabIndex = 25;
            groupBoxOrdendeEntrega.TabStop = false;
            groupBoxOrdendeEntrega.Text = "Seleccionar Ordenes de Preparación:";
            // 
            // ListBoxOrdenesPrep
            // 
            ListBoxOrdenesPrep.FormattingEnabled = true;
            ListBoxOrdenesPrep.Location = new Point(5, 21);
            ListBoxOrdenesPrep.Name = "ListBoxOrdenesPrep";
            ListBoxOrdenesPrep.Size = new Size(231, 256);
            ListBoxOrdenesPrep.TabIndex = 23;
            ListBoxOrdenesPrep.ItemCheck += ListBoxOrdenesPrep_ItemCheck;
            // 
            // botonGenerarOrdenSeleccion
            // 
            botonGenerarOrdenSeleccion.Enabled = false;
            botonGenerarOrdenSeleccion.Location = new Point(5, 285);
            botonGenerarOrdenSeleccion.Margin = new Padding(2);
            botonGenerarOrdenSeleccion.Name = "botonGenerarOrdenSeleccion";
            botonGenerarOrdenSeleccion.Size = new Size(231, 23);
            botonGenerarOrdenSeleccion.TabIndex = 15;
            botonGenerarOrdenSeleccion.Text = "Generar Orden de Selección";
            botonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            botonGenerarOrdenSeleccion.Click += botonGenerarOrdenSeleccion_Click;
            // 
            // botonMenu
            // 
            botonMenu.Location = new Point(16, 327);
            botonMenu.Margin = new Padding(2);
            botonMenu.Name = "botonMenu";
            botonMenu.Size = new Size(99, 23);
            botonMenu.TabIndex = 24;
            botonMenu.Text = "Volver al Menu";
            botonMenu.UseVisualStyleBackColor = true;
            botonMenu.Click += botonMenu_Click;
            // 
            // OrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 358);
            Controls.Add(groupBoxOrdendeEntrega);
            Controls.Add(botonMenu);
            Name = "OrdenSeleccionForm";
            Text = "Orden de Selección";
            FormClosed += OrdenSeleccionForm_FormClosed;
            Load += OrdenSeleccionForm_Load;
            groupBoxOrdendeEntrega.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOrdendeEntrega;
        private CheckedListBox ListBoxOrdenesPrep;
        private Button botonGenerarOrdenSeleccion;
        private Button botonMenu;
    }
}