namespace GrupoA.Prototipo.DespachoConTransportista
{
    partial class DespachoConTransportistaForms
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
            buttonDNI = new Button();
            textBoxDNI = new TextBox();
            labelDNI = new Label();
            groupBoxOrdenEntrega = new GroupBox();
            buttonAtras = new Button();
            buttonCrearRemito = new Button();
            ListBoxOrdenesPrep = new CheckedListBox();
            refreshButton = new Button();
            groupBoxOrdenEntrega.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDNI
            // 
            buttonDNI.Location = new Point(215, 34);
            buttonDNI.Name = "buttonDNI";
            buttonDNI.Size = new Size(98, 23);
            buttonDNI.TabIndex = 0;
            buttonDNI.Text = "Aplicar DNI";
            buttonDNI.UseVisualStyleBackColor = true;
            buttonDNI.Click += buttonDNI_Click;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(12, 34);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(197, 23);
            textBoxDNI.TabIndex = 1;
            textBoxDNI.KeyPress += textBoxDNI_KeyPress;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(12, 16);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(251, 15);
            labelDNI.TabIndex = 2;
            labelDNI.Text = "Ingrese el DNI del transportista (solo números)";
            // 
            // groupBoxOrdenEntrega
            // 
            groupBoxOrdenEntrega.Controls.Add(refreshButton);
            groupBoxOrdenEntrega.Controls.Add(buttonAtras);
            groupBoxOrdenEntrega.Controls.Add(buttonCrearRemito);
            groupBoxOrdenEntrega.Controls.Add(ListBoxOrdenesPrep);
            groupBoxOrdenEntrega.Location = new Point(12, 67);
            groupBoxOrdenEntrega.Name = "groupBoxOrdenEntrega";
            groupBoxOrdenEntrega.Size = new Size(301, 341);
            groupBoxOrdenEntrega.TabIndex = 3;
            groupBoxOrdenEntrega.TabStop = false;
            groupBoxOrdenEntrega.Text = "Seleccionar las ordenes de preparación a despachar:";
            groupBoxOrdenEntrega.Enter += groupBoxOrdenEntrega_Enter;
            // 
            // buttonAtras
            // 
            buttonAtras.Location = new Point(6, 312);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(112, 23);
            buttonAtras.TabIndex = 2;
            buttonAtras.Text = "Volver al Menu";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonCrearRemito
            // 
            buttonCrearRemito.Location = new Point(183, 312);
            buttonCrearRemito.Name = "buttonCrearRemito";
            buttonCrearRemito.Size = new Size(112, 23);
            buttonCrearRemito.TabIndex = 1;
            buttonCrearRemito.Text = "Crear Remito";
            buttonCrearRemito.UseVisualStyleBackColor = true;
            buttonCrearRemito.Click += ButtonCrearRemito_Click;
            // 
            // ListBoxOrdenesPrep
            // 
            ListBoxOrdenesPrep.Enabled = false;
            ListBoxOrdenesPrep.FormattingEnabled = true;
            ListBoxOrdenesPrep.Location = new Point(6, 22);
            ListBoxOrdenesPrep.Name = "ListBoxOrdenesPrep";
            ListBoxOrdenesPrep.Size = new Size(289, 256);
            ListBoxOrdenesPrep.TabIndex = 0;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(6, 283);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(97, 23);
            refreshButton.TabIndex = 8;
            refreshButton.Text = "Actualizar";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // DespachoConTransportistaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 420);
            Controls.Add(groupBoxOrdenEntrega);
            Controls.Add(labelDNI);
            Controls.Add(textBoxDNI);
            Controls.Add(buttonDNI);
            Name = "DespachoConTransportistaForms";
            Text = "Despacho Con Transportista";
            FormClosed += DespachoConTransportistaForms_FormClosed;
            Load += DespachoConTransportistaForms_Load;
            groupBoxOrdenEntrega.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDNI;
        private TextBox textBoxDNI;
        private Label labelDNI;
        private GroupBox groupBoxOrdenEntrega;
        private CheckedListBox ListBoxOrdenesPrep;
        private Button buttonAtras;
        private Button buttonCrearRemito;
        private Button refreshButton;
    }
}