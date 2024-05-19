namespace GrupoA.Prototipo
{
    partial class DespachoForms
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
            checkedListBox2 = new CheckedListBox();
            Cantid = new Label();
            botonAtras = new Button();
            SuspendLayout();
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(8, 20);
            checkedListBox2.Margin = new Padding(2, 2, 2, 2);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(304, 166);
            checkedListBox2.TabIndex = 26;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // Cantid
            // 
            Cantid.AutoSize = true;
            Cantid.Location = new Point(8, 4);
            Cantid.Name = "Cantid";
            Cantid.Size = new Size(179, 15);
            Cantid.TabIndex = 25;
            Cantid.Text = "Lista de Pendientes de Despacho";
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(8, 191);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(75, 23);
            botonAtras.TabIndex = 27;
            botonAtras.Text = "Atrás";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += botonAtras_Click;
            // 
            // DespachoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 223);
            Controls.Add(botonAtras);
            Controls.Add(checkedListBox2);
            Controls.Add(Cantid);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DespachoForms";
            Text = "Despacho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox2;
        private Label Cantid;
        private Button botonAtras;
    }
}