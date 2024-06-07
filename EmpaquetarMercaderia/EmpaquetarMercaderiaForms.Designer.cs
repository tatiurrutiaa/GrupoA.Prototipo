namespace GrupoA.Prototipo.EmpaquetarMercaderia
{
    partial class EmpaquetarMercaderiaForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpaquetarMercaderiaForms));
            empaquetarmercaderiaListview = new ListView();
            idproductoColumn = new ColumnHeader();
            nombreproductoColumn = new ColumnHeader();
            CantidadColumn = new ColumnHeader();
            nroordenLabel = new Label();
            empaquetarButton = new Button();
            botonMenu = new Button();
            buscarCombobox = new ComboBox();
            buscarButton = new Button();
            SuspendLayout();
            // 
            // empaquetarmercaderiaListview
            // 
            empaquetarmercaderiaListview.Columns.AddRange(new ColumnHeader[] { idproductoColumn, nombreproductoColumn, CantidadColumn });
            empaquetarmercaderiaListview.ForeColor = SystemColors.WindowText;
            empaquetarmercaderiaListview.GridLines = true;
            empaquetarmercaderiaListview.Location = new Point(12, 56);
            empaquetarmercaderiaListview.Name = "empaquetarmercaderiaListview";
            empaquetarmercaderiaListview.Size = new Size(320, 256);
            empaquetarmercaderiaListview.TabIndex = 0;
            empaquetarmercaderiaListview.UseCompatibleStateImageBehavior = false;
            empaquetarmercaderiaListview.View = View.Details;
            // 
            // idproductoColumn
            // 
            idproductoColumn.Text = "Id Producto";
            idproductoColumn.Width = 105;
            // 
            // nombreproductoColumn
            // 
            nombreproductoColumn.Text = "Nombre Producto";
            nombreproductoColumn.Width = 110;
            // 
            // CantidadColumn
            // 
            CantidadColumn.Text = "Cantidad";
            CantidadColumn.Width = 100;
            // 
            // nroordenLabel
            // 
            nroordenLabel.AutoSize = true;
            nroordenLabel.Location = new Point(12, 22);
            nroordenLabel.Name = "nroordenLabel";
            nroordenLabel.Size = new Size(85, 15);
            nroordenLabel.TabIndex = 1;
            nroordenLabel.Text = "Nro de Orden: ";
            // 
            // empaquetarButton
            // 
            empaquetarButton.Location = new Point(220, 318);
            empaquetarButton.Name = "empaquetarButton";
            empaquetarButton.Size = new Size(109, 26);
            empaquetarButton.TabIndex = 2;
            empaquetarButton.Text = "Empaquetar";
            empaquetarButton.UseVisualStyleBackColor = true;
            empaquetarButton.Click += empaquetarButton_Click;
            // 
            // botonMenu
            // 
            botonMenu.Location = new Point(220, 350);
            botonMenu.Name = "botonMenu";
            botonMenu.Size = new Size(109, 26);
            botonMenu.TabIndex = 17;
            botonMenu.Text = "Volver al Menu";
            botonMenu.UseVisualStyleBackColor = true;
            botonMenu.Click += botonMenu_Click;
            // 
            // buscarCombobox
            // 
            buscarCombobox.FormattingEnabled = true;
            buscarCombobox.Location = new Point(92, 18);
            buscarCombobox.Name = "buscarCombobox";
            buscarCombobox.Size = new Size(156, 23);
            buscarCombobox.TabIndex = 18;
            // 
            // buscarButton
            // 
            buscarButton.Location = new Point(254, 18);
            buscarButton.Name = "buscarButton";
            buscarButton.Size = new Size(75, 23);
            buscarButton.TabIndex = 19;
            buscarButton.Text = "Buscar";
            buscarButton.UseVisualStyleBackColor = true;
            buscarButton.Click += buscarButton_Click;
            // 
            // EmpaquetarMercaderiaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 382);
            Controls.Add(buscarButton);
            Controls.Add(buscarCombobox);
            Controls.Add(botonMenu);
            Controls.Add(empaquetarButton);
            Controls.Add(nroordenLabel);
            Controls.Add(empaquetarmercaderiaListview);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmpaquetarMercaderiaForms";
            Text = "EmpaquetarMercaderiaForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView empaquetarmercaderiaListview;
        private Label nroordenLabel;
        private ColumnHeader idproductoColumn;
        private ColumnHeader nombreproductoColumn;
        private ColumnHeader CantidadColumn;
        private Button empaquetarButton;
        private Button botonMenu;
        private ComboBox buscarCombobox;
        private Button buscarButton;
    }
}