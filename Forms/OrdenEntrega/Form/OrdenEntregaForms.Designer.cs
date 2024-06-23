namespace GrupoA.Prototipo
{
    partial class OrdenEntregaForms
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxOrdendeEntrega;
        private System.Windows.Forms.CheckedListBox ListBoxOrdenesPrep;
        private System.Windows.Forms.Button botonMenu;
        private System.Windows.Forms.Button botonGenerarOrdenDeEntrega;

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
            ListBoxOrdenesPrep = new CheckedListBox();
            botonGenerarOrdenDeEntrega = new Button();
            botonMenu = new Button();
            groupBoxOrdendeEntrega.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOrdendeEntrega
            // 
            groupBoxOrdendeEntrega.Controls.Add(ListBoxOrdenesPrep);
            groupBoxOrdendeEntrega.Controls.Add(botonGenerarOrdenDeEntrega);
            groupBoxOrdendeEntrega.Location = new Point(11, 11);
            groupBoxOrdendeEntrega.Margin = new Padding(2);
            groupBoxOrdendeEntrega.Name = "groupBoxOrdendeEntrega";
            groupBoxOrdendeEntrega.Padding = new Padding(2);
            groupBoxOrdendeEntrega.Size = new Size(243, 312);
            groupBoxOrdendeEntrega.TabIndex = 23;
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
            ListBoxOrdenesPrep.SelectedIndexChanged += ListBoxOrdenesPrep_SelectedIndexChanged;
            // 
            // botonGenerarOrdenDeEntrega
            // 
            botonGenerarOrdenDeEntrega.Enabled = false;
            botonGenerarOrdenDeEntrega.Location = new Point(5, 285);
            botonGenerarOrdenDeEntrega.Margin = new Padding(2);
            botonGenerarOrdenDeEntrega.Name = "botonGenerarOrdenDeEntrega";
            botonGenerarOrdenDeEntrega.Size = new Size(231, 23);
            botonGenerarOrdenDeEntrega.TabIndex = 15;
            botonGenerarOrdenDeEntrega.Text = "Generar Orden de Entrega";
            botonGenerarOrdenDeEntrega.UseVisualStyleBackColor = true;
            botonGenerarOrdenDeEntrega.Click += BotonGenerarOrdenDeEntrega_Click;
            // 
            // botonMenu
            // 
            botonMenu.Location = new Point(16, 327);
            botonMenu.Margin = new Padding(2);
            botonMenu.Name = "botonMenu";
            botonMenu.Size = new Size(99, 23);
            botonMenu.TabIndex = 22;
            botonMenu.Text = "Volver al Menu";
            botonMenu.UseVisualStyleBackColor = true;
            botonMenu.Click += BotonMenu_Click;
            // 
            // OrdenEntregaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 357);
            Controls.Add(groupBoxOrdendeEntrega);
            Controls.Add(botonMenu);
            Margin = new Padding(2);
            Name = "OrdenEntregaForms";
            Text = "Orden de Entrega";
            FormClosed += OrdenesEntrega_FormClosed;
            groupBoxOrdendeEntrega.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
