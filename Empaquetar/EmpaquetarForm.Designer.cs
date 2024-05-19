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
            MercaderiaCol = new ColumnHeader();
            PedidosLabel = new Label();
            ComfirmarButton = new Button();
            CancelarButton = new Button();
            GenerarTicketButton = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // PedidosList
            // 
            PedidosList.Columns.AddRange(new ColumnHeader[] { NroPedidoCol, MercaderiaCol });
            PedidosList.GridLines = true;
            PedidosList.Location = new Point(17, 36);
            PedidosList.Margin = new Padding(3, 4, 3, 4);
            PedidosList.MultiSelect = false;
            PedidosList.Name = "PedidosList";
            PedidosList.Size = new Size(454, 111);
            PedidosList.TabIndex = 0;
            PedidosList.UseCompatibleStateImageBehavior = false;
            PedidosList.View = View.Details;
            // 
            // NroPedidoCol
            // 
            NroPedidoCol.Text = "NroPedido";
            NroPedidoCol.Width = 100;
            // 
            // MercaderiaCol
            // 
            MercaderiaCol.Text = "Mercaderia";
            MercaderiaCol.Width = 300;
            // 
            // PedidosLabel
            // 
            PedidosLabel.AutoSize = true;
            PedidosLabel.Location = new Point(17, 12);
            PedidosLabel.Name = "PedidosLabel";
            PedidosLabel.Size = new Size(180, 20);
            PedidosLabel.TabIndex = 1;
            PedidosLabel.Text = "Pedidos para empaquetar";
            // 
            // ComfirmarButton
            // 
            ComfirmarButton.Location = new Point(384, 221);
            ComfirmarButton.Margin = new Padding(3, 4, 3, 4);
            ComfirmarButton.Name = "ComfirmarButton";
            ComfirmarButton.Size = new Size(88, 31);
            ComfirmarButton.TabIndex = 2;
            ComfirmarButton.Text = "Confirmar Orden";
            ComfirmarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(289, 221);
            CancelarButton.Margin = new Padding(3, 4, 3, 4);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(88, 31);
            CancelarButton.TabIndex = 3;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // GenerarTicketButton
            // 
            GenerarTicketButton.Location = new Point(289, 183);
            GenerarTicketButton.Margin = new Padding(3, 4, 3, 4);
            GenerarTicketButton.Name = "GenerarTicketButton";
            GenerarTicketButton.Size = new Size(183, 31);
            GenerarTicketButton.TabIndex = 4;
            GenerarTicketButton.Text = "Generar Ticket del Paquete";
            GenerarTicketButton.UseVisualStyleBackColor = true;
            GenerarTicketButton.Click += GenerarTicketButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 227);
            label1.Name = "label1";
            label1.Size = new Size(299, 20);
            label1.TabIndex = 5;
            label1.Text = "¿Desea mandar este pedido a Empaquetar?";
            // 
            // button1
            // 
            button1.Location = new Point(213, 152);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 6;
            button1.Text = "Confirmar Orden";
            button1.UseVisualStyleBackColor = true;
            // 
            // EmpaquetarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 334);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(GenerarTicketButton);
            Controls.Add(CancelarButton);
            Controls.Add(ComfirmarButton);
            Controls.Add(PedidosLabel);
            Controls.Add(PedidosList);
            Margin = new Padding(3, 4, 3, 4);
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
        private ColumnHeader MercaderiaCol;
        private Button GenerarTicketButton;
        private Label label1;
        private Button button1;
    }
}