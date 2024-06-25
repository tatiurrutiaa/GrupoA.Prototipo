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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DespachoSinTransportistaForms));
            ListBoxOrdenesPrep = new CheckedListBox();
            label1 = new Label();
            botonConfirmar = new Button();
            botonAtras = new Button();
            labelDNI = new Label();
            textBoxDNI = new TextBox();
            buttonDNI = new Button();
            refreshButton = new Button();
            SuspendLayout();
            // 
            // ListBoxOrdenesPrep
            // 
            ListBoxOrdenesPrep.Enabled = false;
            ListBoxOrdenesPrep.FormattingEnabled = true;
            ListBoxOrdenesPrep.Location = new Point(12, 85);
            ListBoxOrdenesPrep.Name = "ListBoxOrdenesPrep";
            ListBoxOrdenesPrep.Size = new Size(282, 256);
            ListBoxOrdenesPrep.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(280, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar las ordenes de preparación a despachar:";
            // 
            // botonConfirmar
            // 
            botonConfirmar.Location = new Point(115, 347);
            botonConfirmar.Name = "botonConfirmar";
            botonConfirmar.Size = new Size(179, 23);
            botonConfirmar.TabIndex = 2;
            botonConfirmar.Text = "Generar remito";
            botonConfirmar.UseVisualStyleBackColor = true;
            botonConfirmar.Click += botonConfirmar_Click;
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(12, 380);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(97, 23);
            botonAtras.TabIndex = 3;
            botonAtras.Text = "Volver al Menu";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += botonAtras_Click;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.FlatStyle = FlatStyle.System;
            labelDNI.Location = new Point(17, 12);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(168, 15);
            labelDNI.TabIndex = 4;
            labelDNI.Text = "Ingrese el DNI del transportista";
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(16, 36);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(169, 23);
            textBoxDNI.TabIndex = 5;
            textBoxDNI.TextChanged += textBoxDNI_TextChanged;
            textBoxDNI.KeyPress += textBoxDNI_KeyPress;
            // 
            // buttonDNI
            // 
            buttonDNI.Location = new Point(217, 36);
            buttonDNI.Name = "buttonDNI";
            buttonDNI.Size = new Size(75, 23);
            buttonDNI.TabIndex = 6;
            buttonDNI.Text = "Aplicar DNI";
            buttonDNI.UseVisualStyleBackColor = true;
            buttonDNI.Click += buttonDNI_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(12, 347);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(97, 23);
            refreshButton.TabIndex = 7;
            refreshButton.Text = "Actualizar";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // DespachoSinTransportistaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 415);
            Controls.Add(refreshButton);
            Controls.Add(buttonDNI);
            Controls.Add(textBoxDNI);
            Controls.Add(labelDNI);
            Controls.Add(botonAtras);
            Controls.Add(botonConfirmar);
            Controls.Add(label1);
            Controls.Add(ListBoxOrdenesPrep);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DespachoSinTransportistaForms";
            Text = "Despacho sin transportista";
            FormClosed += Salida_FormClosed;
            Load += DespachoSinTransportistaForms_Load;
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
        private Button refreshButton;
    }
}