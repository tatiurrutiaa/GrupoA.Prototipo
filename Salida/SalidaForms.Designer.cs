namespace GrupoA.Prototipo.Salida
{
    partial class Salida
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
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // ListBoxOrdenesPrep
            // 
            ListBoxOrdenesPrep.FormattingEnabled = true;
            ListBoxOrdenesPrep.Location = new Point(12, 85);
            ListBoxOrdenesPrep.Name = "ListBoxOrdenesPrep";
            ListBoxOrdenesPrep.Size = new Size(282, 274);
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
            botonConfirmar.Location = new Point(217, 365);
            botonConfirmar.Name = "botonConfirmar";
            botonConfirmar.Size = new Size(75, 23);
            botonConfirmar.TabIndex = 2;
            botonConfirmar.Text = "Confirmar";
            botonConfirmar.UseVisualStyleBackColor = true;
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(12, 365);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(75, 23);
            botonAtras.TabIndex = 3;
            botonAtras.Text = "Atrás";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += botonAtras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Location = new Point(17, 12);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrese el DNI del transportista";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(217, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Aplicar DNI";
            button1.UseVisualStyleBackColor = true;
            // 
            // Salida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 398);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(botonAtras);
            Controls.Add(botonConfirmar);
            Controls.Add(label1);
            Controls.Add(ListBoxOrdenesPrep);
            Name = "Salida";
            Text = "SalidaForms";
            Load += Salida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox ListBoxOrdenesPrep;
        private Label label1;
        private Button botonConfirmar;
        private Button botonAtras;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}