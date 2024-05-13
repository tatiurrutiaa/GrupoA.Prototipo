namespace GrupoA.Prototipo.Empaquetado
{
    partial class EmpaquetarForm
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
            PedidosList = new ListView();
            NroPedidoCol = new ColumnHeader();
            PedidosLabel = new Label();
            ComfirmarButton = new Button();
            CancelarButton = new Button();
            PedidoCol = new ColumnHeader();
            GenerarTicketButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // PedidosList
            // 
            PedidosList.Columns.AddRange(new ColumnHeader[] { NroPedidoCol, PedidoCol });
            PedidosList.GridLines = true;
            PedidosList.Location = new Point(15, 27);
            PedidosList.Name = "PedidosList";
            PedidosList.Size = new Size(398, 84);
            PedidosList.TabIndex = 0;
            PedidosList.UseCompatibleStateImageBehavior = false;
            PedidosList.View = View.Details;
            PedidosList.SelectedIndexChanged += PedidosList_SelectedIndexChanged;
            // 
            // NroPedidoCol
            // 
            NroPedidoCol.Width = 100;
            // 
            // PedidosLabel
            // 
            PedidosLabel.AutoSize = true;
            PedidosLabel.Location = new Point(15, 9);
            PedidosLabel.Name = "PedidosLabel";
            PedidosLabel.Size = new Size(142, 15);
            PedidosLabel.TabIndex = 1;
            PedidosLabel.Text = "Pedidos para empaquetar";
            PedidosLabel.Click += label1_Click;
            // 
            // ComfirmarButton
            // 
            ComfirmarButton.Location = new Point(336, 166);
            ComfirmarButton.Name = "ComfirmarButton";
            ComfirmarButton.Size = new Size(77, 23);
            ComfirmarButton.TabIndex = 2;
            ComfirmarButton.Text = "Confirmar Orden";
            ComfirmarButton.UseVisualStyleBackColor = true;
            ComfirmarButton.Click += button1_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(253, 166);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(77, 23);
            CancelarButton.TabIndex = 3;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // PedidoCol
            // 
            PedidoCol.Width = 300;
            // 
            // GenerarTicketButton
            // 
            GenerarTicketButton.Location = new Point(253, 137);
            GenerarTicketButton.Name = "GenerarTicketButton";
            GenerarTicketButton.Size = new Size(160, 23);
            GenerarTicketButton.TabIndex = 4;
            GenerarTicketButton.Text = "Generar Ticket del Paquete";
            GenerarTicketButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 170);
            label1.Name = "label1";
            label1.Size = new Size(232, 15);
            label1.TabIndex = 5;
            label1.Text = "¿Desea mandar este pedido a Empaquetar?";
            // 
            // EmpaquetarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 205);
            Controls.Add(label1);
            Controls.Add(GenerarTicketButton);
            Controls.Add(CancelarButton);
            Controls.Add(ComfirmarButton);
            Controls.Add(PedidosLabel);
            Controls.Add(PedidosList);
            Name = "EmpaquetarForm";
            Text = "EmpaquetarForm";
            Load += EmpaquetarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView PedidosList;
        private ColumnHeader NroPedidoCol;
        private Label PedidosLabel;
        private Button ComfirmarButton;
        private Button CancelarButton;
        private ColumnHeader PedidoCol;
        private Button GenerarTicketButton;
        private Label label1;
    }
}