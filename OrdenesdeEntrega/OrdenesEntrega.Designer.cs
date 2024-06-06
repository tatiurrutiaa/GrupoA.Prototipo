namespace GrupoA.Prototipo
{
    partial class OrdenesEntrega
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxOrdendeEntrega = new GroupBox();
            botonAtras = new Button();
            botonMenu = new Button();
            listBoxOrdenesPrep = new ListBox();
            botonGenerarOrdenDeEntrega = new Button();
            groupBoxOrdendeEntrega.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOrdendeEntrega
            // 
            groupBoxOrdendeEntrega.Controls.Add(botonAtras);
            groupBoxOrdendeEntrega.Controls.Add(botonMenu);
            groupBoxOrdendeEntrega.Controls.Add(listBoxOrdenesPrep);
            groupBoxOrdendeEntrega.Controls.Add(botonGenerarOrdenDeEntrega);
            groupBoxOrdendeEntrega.Location = new Point(8, 8);
            groupBoxOrdendeEntrega.Margin = new Padding(2);
            groupBoxOrdendeEntrega.Name = "groupBoxOrdendeEntrega";
            groupBoxOrdendeEntrega.Padding = new Padding(2);
            groupBoxOrdendeEntrega.Size = new Size(347, 313);
            groupBoxOrdendeEntrega.TabIndex = 23;
            groupBoxOrdendeEntrega.TabStop = false;
            groupBoxOrdendeEntrega.Text = "Ordenes Preparadas";
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(1, 233);
            botonAtras.Margin = new Padding(2);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(90, 23);
            botonAtras.TabIndex = 24;
            botonAtras.Text = "Atrás";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += BotonAtras_Click;
            // 
            // botonMenu
            // 
            botonMenu.Location = new Point(1, 273);
            botonMenu.Margin = new Padding(2);
            botonMenu.Name = "botonMenu";
            botonMenu.Size = new Size(99, 23);
            botonMenu.TabIndex = 22;
            botonMenu.Text = "Volver al Menu";
            botonMenu.UseVisualStyleBackColor = true;
            botonMenu.Click += BotonMenu_Click;
            // 
            // listBoxOrdenesPrep
            // 
            listBoxOrdenesPrep.FormattingEnabled = true;
            listBoxOrdenesPrep.ItemHeight = 15;
            listBoxOrdenesPrep.Location = new Point(1, 20);
            listBoxOrdenesPrep.Margin = new Padding(2);
            listBoxOrdenesPrep.Name = "listBoxOrdenesPrep";
            listBoxOrdenesPrep.Size = new Size(323, 199);
            listBoxOrdenesPrep.TabIndex = 17;
            // 
            // botonGenerarOrdenDeEntrega
            // 
            botonGenerarOrdenDeEntrega.Location = new Point(96, 233);
            botonGenerarOrdenDeEntrega.Margin = new Padding(2);
            botonGenerarOrdenDeEntrega.Name = "botonGenerarOrdenDeEntrega";
            botonGenerarOrdenDeEntrega.Size = new Size(220, 23);
            botonGenerarOrdenDeEntrega.TabIndex = 15;
            botonGenerarOrdenDeEntrega.Text = "Generar Orden de Entrega";
            botonGenerarOrdenDeEntrega.UseVisualStyleBackColor = true;
            botonGenerarOrdenDeEntrega.Click += BotonGenerarOrdenDeEntrega_Click;
            // 
            // OrdenesEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 331);
            Controls.Add(groupBoxOrdendeEntrega);
            Margin = new Padding(2);
            Name = "OrdenesEntrega";
            Text = "Orden de Entrega";
            FormClosed += OrdenesEntrega_FormClosed;
            groupBoxOrdendeEntrega.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxOrdendeEntrega;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.ListBox listBoxOrdenesPrep;
        private System.Windows.Forms.Button botonGenerarOrdenDeEntrega;
        private System.Windows.Forms.Button botonMenu;
    }
}
