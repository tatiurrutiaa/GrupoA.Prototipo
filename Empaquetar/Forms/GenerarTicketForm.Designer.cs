namespace GrupoA.Prototipo.Empaquetar
{
    partial class GenerarTicketForm
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
            label1 = new Label();
            NroPedidoBox = new TextBox();
            label2 = new Label();
            CuitBox = new TextBox();
            label3 = new Label();
            ImprimirButton = new Button();
            FragilCheckBox = new CheckBox();
            RazonSocialTextBox = new TextBox();
            RazonSociallabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos del cliente";
            label1.Click += label1_Click;
            // 
            // NroPedidoBox
            // 
            NroPedidoBox.Location = new Point(23, 167);
            NroPedidoBox.Name = "NroPedidoBox";
            NroPedidoBox.Size = new Size(113, 23);
            NroPedidoBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 140);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "N° de Pedido";
            // 
            // CuitBox
            // 
            CuitBox.Location = new Point(23, 69);
            CuitBox.Name = "CuitBox";
            CuitBox.Size = new Size(117, 23);
            CuitBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 51);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "CUIT Cliente";
            // 
            // ImprimirButton
            // 
            ImprimirButton.Location = new Point(149, 399);
            ImprimirButton.Name = "ImprimirButton";
            ImprimirButton.Size = new Size(114, 27);
            ImprimirButton.TabIndex = 5;
            ImprimirButton.Text = "Imprimir";
            ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // FragilCheckBox
            // 
            FragilCheckBox.AutoSize = true;
            FragilCheckBox.Location = new Point(27, 338);
            FragilCheckBox.Name = "FragilCheckBox";
            FragilCheckBox.Size = new Size(55, 19);
            FragilCheckBox.TabIndex = 6;
            FragilCheckBox.Text = "Fragil";
            FragilCheckBox.UseVisualStyleBackColor = true;
            // 
            // RazonSocialTextBox
            // 
            RazonSocialTextBox.Location = new Point(149, 69);
            RazonSocialTextBox.Name = "RazonSocialTextBox";
            RazonSocialTextBox.Size = new Size(117, 23);
            RazonSocialTextBox.TabIndex = 7;
            // 
            // RazonSociallabel
            // 
            RazonSociallabel.AutoSize = true;
            RazonSociallabel.Location = new Point(149, 51);
            RazonSociallabel.Name = "RazonSociallabel";
            RazonSociallabel.Size = new Size(73, 15);
            RazonSociallabel.TabIndex = 8;
            RazonSociallabel.Text = "Razon Social";
            // 
            // GenerarTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 450);
            Controls.Add(RazonSociallabel);
            Controls.Add(RazonSocialTextBox);
            Controls.Add(FragilCheckBox);
            Controls.Add(ImprimirButton);
            Controls.Add(label3);
            Controls.Add(CuitBox);
            Controls.Add(label2);
            Controls.Add(NroPedidoBox);
            Controls.Add(label1);
            Name = "GenerarTicketForm";
            Text = "GenerarTicketForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NroPedidoBox;
        private Label label2;
        private TextBox CuitBox;
        private Label label3;
        private Button ImprimirButton;
        private CheckBox FragilCheckBox;
        private TextBox RazonSocialTextBox;
        private Label RazonSociallabel;
    }
}