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
            listBoxOrdenesPrep = new ListBox();
            botonGenerarOrdenDeEntrega = new Button();
            botonMenu = new Button();
            groupBoxOrdendeEntrega.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOrdendeEntrega
            // 
            groupBoxOrdendeEntrega.Controls.Add(botonAtras);
            groupBoxOrdendeEntrega.Controls.Add(botonMenu);
            groupBoxOrdendeEntrega.Controls.Add(listBoxOrdenesPrep);
            groupBoxOrdendeEntrega.Controls.Add(botonGenerarOrdenDeEntrega);
            groupBoxOrdendeEntrega.Location = new Point(12, 14);
            groupBoxOrdendeEntrega.Name = "groupBoxOrdendeEntrega";
            groupBoxOrdendeEntrega.Size = new Size(496, 521);
            groupBoxOrdendeEntrega.TabIndex = 23;
            groupBoxOrdendeEntrega.TabStop = false;
            groupBoxOrdendeEntrega.Text = "Ordenes Preparadas";
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(1, 389);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(128, 38);
            botonAtras.TabIndex = 24;
            botonAtras.Text = "Atrás";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += BotonAtras_Click;
            // 
            // listBoxOrdenesPrep
            // 
            listBoxOrdenesPrep.FormattingEnabled = true;
            listBoxOrdenesPrep.ItemHeight = 25;
            listBoxOrdenesPrep.Location = new Point(1, 34);
            listBoxOrdenesPrep.Name = "listBoxOrdenesPrep";
            listBoxOrdenesPrep.Size = new Size(460, 329);
            listBoxOrdenesPrep.TabIndex = 17;
            // 
            // botonGenerarOrdenDeEntrega
            // 
            botonGenerarOrdenDeEntrega.Location = new Point(137, 389);
            botonGenerarOrdenDeEntrega.Name = "botonGenerarOrdenDeEntrega";
            botonGenerarOrdenDeEntrega.Size = new Size(314, 38);
            botonGenerarOrdenDeEntrega.TabIndex = 15;
            botonGenerarOrdenDeEntrega.Text = "Generar Orden de Entrega";
            botonGenerarOrdenDeEntrega.UseVisualStyleBackColor = true;
            botonGenerarOrdenDeEntrega.Click += BotonGenerarOrdenDeEntrega_Click;
            // 
            // botonMenu
            // 
            botonMenu.Location = new Point(1, 455);
            botonMenu.Name = "botonMenu";
            botonMenu.Size = new Size(142, 38);
            botonMenu.TabIndex = 22;
            botonMenu.Text = "Volver al Menú";
            botonMenu.UseVisualStyleBackColor = true;
            botonMenu.Click += BotonMenu_Click;
            // 
            // OrdendeEntrega
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 551);
            Controls.Add(groupBoxOrdendeEntrega);
            Name = "OrdendeEntrega";
            Text = "Orden de Entrega";
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
