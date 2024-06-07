namespace GrupoA.Prototipo
{
    partial class OrdenesEntrega
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
            this.groupBoxOrdendeEntrega = new System.Windows.Forms.GroupBox();
            this.ListBoxOrdenesPrep = new System.Windows.Forms.CheckedListBox();
            this.botonMenu = new System.Windows.Forms.Button();
            this.botonGenerarOrdenDeEntrega = new System.Windows.Forms.Button();
            this.groupBoxOrdendeEntrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOrdendeEntrega
            // 
            this.groupBoxOrdendeEntrega.Controls.Add(this.ListBoxOrdenesPrep);
            this.groupBoxOrdendeEntrega.Controls.Add(this.botonMenu);
            this.groupBoxOrdendeEntrega.Controls.Add(this.botonGenerarOrdenDeEntrega);
            this.groupBoxOrdendeEntrega.Location = new System.Drawing.Point(11, 13);
            this.groupBoxOrdendeEntrega.Name = "groupBoxOrdendeEntrega";
            this.groupBoxOrdendeEntrega.Size = new System.Drawing.Size(496, 522);
            this.groupBoxOrdendeEntrega.TabIndex = 23;
            this.groupBoxOrdendeEntrega.TabStop = false;
            this.groupBoxOrdendeEntrega.Text = "Ordenes Preparadas";
            // 
            // ListBoxOrdenesPrep
            // 
            this.ListBoxOrdenesPrep.FormattingEnabled = true;
            this.ListBoxOrdenesPrep.Location = new System.Drawing.Point(2, 32);
            this.ListBoxOrdenesPrep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxOrdenesPrep.Name = "ListBoxOrdenesPrep";
            this.ListBoxOrdenesPrep.Size = new System.Drawing.Size(411, 340);
            this.ListBoxOrdenesPrep.TabIndex = 23;
            this.ListBoxOrdenesPrep.SelectedIndexChanged += new System.EventHandler(this.ListBoxOrdenesPrep_SelectedIndexChanged);
            // 
            // botonMenu
            // 
            this.botonMenu.Location = new System.Drawing.Point(0, 388);
            this.botonMenu.Name = "botonMenu";
            this.botonMenu.Size = new System.Drawing.Size(141, 38);
            this.botonMenu.TabIndex = 22;
            this.botonMenu.Text = "Volver al Menu";
            this.botonMenu.UseVisualStyleBackColor = true;
            this.botonMenu.Click += new System.EventHandler(this.BotonMenu_Click);
            // 
            // botonGenerarOrdenDeEntrega
            // 
            this.botonGenerarOrdenDeEntrega.Location = new System.Drawing.Point(147, 388);
            this.botonGenerarOrdenDeEntrega.Name = "botonGenerarOrdenDeEntrega";
            this.botonGenerarOrdenDeEntrega.Size = new System.Drawing.Size(266, 38);
            this.botonGenerarOrdenDeEntrega.TabIndex = 15;
            this.botonGenerarOrdenDeEntrega.Text = "Generar Orden de Entrega";
            this.botonGenerarOrdenDeEntrega.UseVisualStyleBackColor = true;
            this.botonGenerarOrdenDeEntrega.Click += new System.EventHandler(this.BotonGenerarOrdenDeEntrega_Click);
            // 
            // OrdenesEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 552);
            this.Controls.Add(this.groupBoxOrdendeEntrega);
            this.Name = "OrdenesEntrega";
            this.Text = "Orden de Entrega";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdenesEntrega_FormClosed);
            this.groupBoxOrdendeEntrega.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
