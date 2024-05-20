namespace GrupoA.Prototipo
{
    partial class VerificarTransportistaForms
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
            botonVerificar = new Button();
            textBoxDNI = new TextBox();
            label1 = new Label();
            groupBoxOrdenEntrega = new GroupBox();
            botonAtras = new Button();
            botonCrearRemito = new Button();
            checkedListBox1 = new CheckedListBox();
            groupBoxOrdenEntrega.SuspendLayout();
            SuspendLayout();
            // 
            // botonVerificar
            // 
            botonVerificar.Location = new Point(180, 27);
            botonVerificar.Name = "botonVerificar";
            botonVerificar.Size = new Size(75, 23);
            botonVerificar.TabIndex = 0;
            botonVerificar.Text = "Verificar";
            botonVerificar.UseVisualStyleBackColor = true;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(12, 27);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(162, 23);
            textBoxDNI.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "DNI Transportista";
            // 
            // groupBoxOrdenEntrega
            // 
            groupBoxOrdenEntrega.Controls.Add(botonAtras);
            groupBoxOrdenEntrega.Controls.Add(botonCrearRemito);
            groupBoxOrdenEntrega.Controls.Add(checkedListBox1);
            groupBoxOrdenEntrega.Location = new Point(12, 67);
            groupBoxOrdenEntrega.Name = "groupBoxOrdenEntrega";
            groupBoxOrdenEntrega.Size = new Size(255, 281);
            groupBoxOrdenEntrega.TabIndex = 3;
            groupBoxOrdenEntrega.TabStop = false;
            groupBoxOrdenEntrega.Text = "Orden de entrega";
            groupBoxOrdenEntrega.Enter += groupBoxOrdenesAEntregar_Enter;
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(6, 248);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(75, 23);
            botonAtras.TabIndex = 2;
            botonAtras.Text = "Atrás";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += botonAtras_Click;
            // 
            // botonCrearRemito
            // 
            botonCrearRemito.Location = new Point(131, 248);
            botonCrearRemito.Name = "botonCrearRemito";
            botonCrearRemito.Size = new Size(112, 23);
            botonCrearRemito.TabIndex = 1;
            botonCrearRemito.Text = "Crear Remito";
            botonCrearRemito.UseVisualStyleBackColor = true;
            botonCrearRemito.Click += botonCrearRemito_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(6, 22);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(237, 220);
            checkedListBox1.TabIndex = 0;
            // 
            // VerificarTransportistaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 358);
            Controls.Add(groupBoxOrdenEntrega);
            Controls.Add(label1);
            Controls.Add(textBoxDNI);
            Controls.Add(botonVerificar);
            Name = "VerificarTransportistaForms";
            Text = "Verificar Transportista";
            groupBoxOrdenEntrega.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonVerificar;
        private TextBox textBoxDNI;
        private Label label1;
        private GroupBox groupBoxOrdenEntrega;
        private CheckedListBox checkedListBox1;
        private Button botonAtras;
        private Button botonCrearRemito;
    }
}