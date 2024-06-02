namespace GrupoA.Prototipo.DespachoSinTransportista
{
    partial class DespachoSinTransportistaForms
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
            ListBoxOrdenesPrep = new CheckedListBox();
            label1 = new Label();
            botonConfirmar = new Button();
            botonAtras = new Button();
            labelDNI = new Label();
            textBoxDNI = new TextBox();
            buttonDNI = new Button();
            SuspendLayout();
            // 
            // ListBoxOrdenesPrep
            // 
            ListBoxOrdenesPrep.Enabled = false;
            ListBoxOrdenesPrep.FormattingEnabled = true;
            ListBoxOrdenesPrep.Location = new Point(14, 113);
            ListBoxOrdenesPrep.Margin = new Padding(3, 4, 3, 4);
            ListBoxOrdenesPrep.Name = "ListBoxOrdenesPrep";
            ListBoxOrdenesPrep.Size = new Size(322, 356);
            ListBoxOrdenesPrep.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 89);
            label1.Name = "label1";
            label1.Size = new Size(356, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar las ordenes de preparación a despachar:";
            // 
            // botonConfirmar
            // 
            botonConfirmar.Location = new Point(248, 507);
            botonConfirmar.Margin = new Padding(3, 4, 3, 4);
            botonConfirmar.Name = "botonConfirmar";
            botonConfirmar.Size = new Size(86, 31);
            botonConfirmar.TabIndex = 2;
            botonConfirmar.Text = "Generar remito";
            botonConfirmar.UseVisualStyleBackColor = true;
            botonConfirmar.Click += botonConfirmar_Click;
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(14, 507);
            botonAtras.Margin = new Padding(3, 4, 3, 4);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(86, 31);
            botonAtras.TabIndex = 3;
            botonAtras.Text = "Atrás";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += botonAtras_Click;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.FlatStyle = FlatStyle.System;
            labelDNI.Location = new Point(19, 16);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(215, 20);
            labelDNI.TabIndex = 4;
            labelDNI.Text = "Ingrese el DNI del transportista";
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(18, 48);
            textBoxDNI.Margin = new Padding(3, 4, 3, 4);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(193, 27);
            textBoxDNI.TabIndex = 5;
            textBoxDNI.KeyPress += textBoxDNI_KeyPress;
            // 
            // buttonDNI
            // 
            buttonDNI.Location = new Point(248, 48);
            buttonDNI.Margin = new Padding(3, 4, 3, 4);
            buttonDNI.Name = "buttonDNI";
            buttonDNI.Size = new Size(86, 31);
            buttonDNI.TabIndex = 6;
            buttonDNI.Text = "Aplicar DNI";
            buttonDNI.UseVisualStyleBackColor = true;
            buttonDNI.Click += buttonDNI_Click;
            // 
            // DespachoSinTransportistaForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 553);
            Controls.Add(buttonDNI);
            Controls.Add(textBoxDNI);
            Controls.Add(labelDNI);
            Controls.Add(botonAtras);
            Controls.Add(botonConfirmar);
            Controls.Add(label1);
            Controls.Add(ListBoxOrdenesPrep);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DespachoSinTransportistaForms";
            Text = "Despacho sin transportista";
            FormClosed += Salida_FormClosed;
            Load += Salida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox ListBoxOrdenesPrep;
        private Label label1;
        private Button botonConfirmar;
        private Button botonAtras;
        private Label labelDNI;
        private TextBox textBoxDNI;
        private Button buttonDNI;
    }
}