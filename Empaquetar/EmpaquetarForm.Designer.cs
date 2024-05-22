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
            PedidosLabel = new Label();
            ComfirmarButton = new Button();
            EmpaquetarListbox = new ListBox();
            AtrasButton = new Button();
            SuspendLayout();
            // 
            // PedidosLabel
            // 
            PedidosLabel.AutoSize = true;
            PedidosLabel.Location = new Point(15, 9);
            PedidosLabel.Name = "PedidosLabel";
            PedidosLabel.Size = new Size(142, 15);
            PedidosLabel.TabIndex = 1;
            PedidosLabel.Text = "Pedidos para empaquetar";
            // 
            // ComfirmarButton
            // 
            ComfirmarButton.Location = new Point(365, 199);
            ComfirmarButton.Name = "ComfirmarButton";
            ComfirmarButton.Size = new Size(77, 23);
            ComfirmarButton.TabIndex = 2;
            ComfirmarButton.Text = "Confirmar Orden";
            ComfirmarButton.UseVisualStyleBackColor = true;
            // 
            // EmpaquetarListbox
            // 
            EmpaquetarListbox.FormattingEnabled = true;
            EmpaquetarListbox.ItemHeight = 15;
            EmpaquetarListbox.Location = new Point(14, 28);
            EmpaquetarListbox.Name = "EmpaquetarListbox";
            EmpaquetarListbox.Size = new Size(430, 154);
            EmpaquetarListbox.TabIndex = 3;
            // 
            // AtrasButton
            // 
            AtrasButton.Location = new Point(284, 199);
            AtrasButton.Name = "AtrasButton";
            AtrasButton.Size = new Size(75, 23);
            AtrasButton.TabIndex = 4;
            AtrasButton.Text = "Atras";
            AtrasButton.UseVisualStyleBackColor = true;
            AtrasButton.Click += button1_Click;
            // 
            // EmpaquetarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 250);
            Controls.Add(AtrasButton);
            Controls.Add(EmpaquetarListbox);
            Controls.Add(ComfirmarButton);
            Controls.Add(PedidosLabel);
            Name = "EmpaquetarForm";
            Text = "EmpaquetarForm";
            Load += EmpaquetarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label PedidosLabel;
        private Button ComfirmarButton;
        private ListBox EmpaquetarListbox;
        private Button AtrasButton;
    }
}