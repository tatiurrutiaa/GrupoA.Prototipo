﻿namespace GrupoA.Prototipo
{
    partial class OrdenSeleccionForms
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
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            botonAceptar = new Button();
            botonAtras = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 36);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(477, 292);
            checkedListBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 15);
            label1.TabIndex = 1;
            label1.Text = "Por favor, seleccione las ordenes a preparar:";
            // 
            // botonAceptar
            // 
            botonAceptar.Location = new Point(414, 334);
            botonAceptar.Name = "botonAceptar";
            botonAceptar.Size = new Size(75, 23);
            botonAceptar.TabIndex = 2;
            botonAceptar.Text = "Aceptar";
            botonAceptar.UseVisualStyleBackColor = true;
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(333, 334);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(75, 23);
            botonAtras.TabIndex = 3;
            botonAtras.Text = "Atrás";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += botonAtras_Click;
            // 
            // OrdenSeleccionForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 369);
            Controls.Add(botonAtras);
            Controls.Add(botonAceptar);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Name = "OrdenSeleccionForms";
            Text = "Orden de Selección";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label1;
        private Button botonAceptar;
        private Button botonAtras;
    }
}

// FormularioPrincipal.Designer.cs
partial class OrdenSeleccionForms
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ListBox lstOrdenes;
    private System.Windows.Forms.Button btnGenerarOrdenSeleccion;

    private void InitializeComponent()
    {
        this.lstOrdenes = new System.Windows.Forms.ListBox();
        this.btnGenerarOrdenSeleccion = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lstOrdenes

        this.lstOrdenes.FormattingEnabled = true;
        this.lstOrdenes.Location = new System.Drawing.Point(12, 12);
        this.lstOrdenes.Name = "lstOrdenes";
        this.lstOrdenes.Size = new System.Drawing.Size(260, 199);
        this.lstOrdenes.TabIndex = 0;

        // btnGenerarOrdenSeleccion

        this.btnGenerarOrdenSeleccion.Location = new System.Drawing.Point(12, 217);
        this.btnGenerarOrdenSeleccion.Name = "btnGenerarOrdenSeleccion";
        this.btnGenerarOrdenSeleccion.Size = new System.Drawing.Size(260, 32);
        this.btnGenerarOrdenSeleccion.TabIndex = 1;
        this.btnGenerarOrdenSeleccion.Text = "Generar Orden de Selección";
        this.btnGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
        this.btnGenerarOrdenSeleccion.Click += new System.EventHandler(this.btnGenerarOrdenSeleccion_Click);
    }
}    
     
// OrdenSeleccionForm
         
        /* this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 261);
        this.Controls.Add(this.btnGenerarOrdenSeleccion);
        this.Controls.Add(this.lstOrdenes);
        this.Name = "FormularioPrincipal";
        this.Text = "Generar Orden de Selección";
        this.ResumeLayout(false); /*

    }
}