namespace GrupoA.Prototipo.Empaquetar
{
    partial class EmpaquetadoForms
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView EmpaquetarListView;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderCantidad;
        private System.Windows.Forms.Button EmpaquetarButton;
        private System.Windows.Forms.Button AtrasButton;
        private System.Windows.Forms.Label NroOrdenLabel;

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
            EmpaquetarListView = new ListView();
            columnHeaderID = new ColumnHeader();
            columnHeaderNombre = new ColumnHeader();
            columnHeaderCantidad = new ColumnHeader();
            EmpaquetarButton = new Button();
            AtrasButton = new Button();
            NroOrdenLabel = new Label();
            anteriorButton = new Button();
            SiguienteButton = new Button();
            SuspendLayout();
            // 
            // EmpaquetarListView
            // 
            EmpaquetarListView.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderNombre, columnHeaderCantidad });
            EmpaquetarListView.Location = new Point(12, 33);
            EmpaquetarListView.Name = "EmpaquetarListView";
            EmpaquetarListView.Size = new Size(395, 207);
            EmpaquetarListView.TabIndex = 0;
            EmpaquetarListView.UseCompatibleStateImageBehavior = false;
            EmpaquetarListView.View = View.Details;
            // 
            // columnHeaderID
            // 
            columnHeaderID.Text = "ID";
            columnHeaderID.Width = 70;
            // 
            // columnHeaderNombre
            // 
            columnHeaderNombre.Text = "Producto";
            columnHeaderNombre.Width = 220;
            // 
            // columnHeaderCantidad
            // 
            columnHeaderCantidad.Text = "Cantidad";
            columnHeaderCantidad.Width = 100;
            // 
            // EmpaquetarButton
            // 
            EmpaquetarButton.Location = new Point(307, 246);
            EmpaquetarButton.Name = "EmpaquetarButton";
            EmpaquetarButton.Size = new Size(100, 25);
            EmpaquetarButton.TabIndex = 1;
            EmpaquetarButton.Text = "Empaquetar";
            EmpaquetarButton.UseVisualStyleBackColor = true;
            EmpaquetarButton.Click += EmpaquetarButton_Click;
            // 
            // AtrasButton
            // 
            AtrasButton.Location = new Point(307, 312);
            AtrasButton.Name = "AtrasButton";
            AtrasButton.Size = new Size(100, 25);
            AtrasButton.TabIndex = 2;
            AtrasButton.Text = "Volver al menu";
            AtrasButton.UseVisualStyleBackColor = true;
            AtrasButton.Click += AtrasButton_Click;
            // 
            // NroOrdenLabel
            // 
            NroOrdenLabel.AutoSize = true;
            NroOrdenLabel.Location = new Point(12, 15);
            NroOrdenLabel.Name = "NroOrdenLabel";
            NroOrdenLabel.Size = new Size(82, 15);
            NroOrdenLabel.TabIndex = 3;
            NroOrdenLabel.Text = "Nro de Orden:";
            // 
            // anteriorButton
            // 
            anteriorButton.Location = new Point(171, 246);
            anteriorButton.Name = "anteriorButton";
            anteriorButton.Size = new Size(60, 25);
            anteriorButton.TabIndex = 4;
            anteriorButton.Text = "Anterior";
            anteriorButton.UseVisualStyleBackColor = true;
            anteriorButton.Click += anteriorButton_Click;
            // 
            // SiguienteButton
            // 
            SiguienteButton.Location = new Point(237, 246);
            SiguienteButton.Name = "SiguienteButton";
            SiguienteButton.Size = new Size(64, 25);
            SiguienteButton.TabIndex = 5;
            SiguienteButton.Text = "Siguiente";
            SiguienteButton.UseVisualStyleBackColor = true;
            SiguienteButton.Click += SiguienteButton_Click;
            // 
            // EmpaquetadoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 349);
            Controls.Add(SiguienteButton);
            Controls.Add(anteriorButton);
            Controls.Add(NroOrdenLabel);
            Controls.Add(AtrasButton);
            Controls.Add(EmpaquetarButton);
            Controls.Add(EmpaquetarListView);
            Name = "EmpaquetadoForms";
            Text = "Empaquetar";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button anteriorButton;
        private Button SiguienteButton;
    }
}
