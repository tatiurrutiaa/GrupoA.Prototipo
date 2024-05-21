namespace GrupoA.Prototipo
{
    partial class RetiroStockForms
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
            botonRetirarStock = new Button();
            botonAtras = new Button();
            listBoxRetiroStock = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // botonRetirarStock
            // 
            botonRetirarStock.Location = new Point(284, 224);
            botonRetirarStock.Name = "botonRetirarStock";
            botonRetirarStock.Size = new Size(130, 23);
            botonRetirarStock.TabIndex = 15;
            botonRetirarStock.Text = "Retirar Stock";
            botonRetirarStock.UseVisualStyleBackColor = true;
            botonRetirarStock.Click += botonRetirarStock_Click;
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(203, 224);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(75, 23);
            botonAtras.TabIndex = 16;
            botonAtras.Text = "Atrás";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += botonAtras_Click;
            // 
            // listBoxRetiroStock
            // 
            listBoxRetiroStock.FormattingEnabled = true;
            listBoxRetiroStock.ItemHeight = 15;
            listBoxRetiroStock.Location = new Point(12, 34);
            listBoxRetiroStock.Name = "listBoxRetiroStock";
            listBoxRetiroStock.Size = new Size(401, 184);
            listBoxRetiroStock.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 18;
            label1.Text = "Posición - Cantidad - Mercadería";
            // 
            // RetiroStockForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 263);
            Controls.Add(label1);
            Controls.Add(listBoxRetiroStock);
            Controls.Add(botonAtras);
            Controls.Add(botonRetirarStock);
            Name = "RetiroStockForms";
            Text = "Retiro de stock";
            Load += RetiroStockForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button botonRetirarStock;
        private Button botonAtras;
        private ListBox listBoxRetiroStock;
        private Label label1;
    }
}