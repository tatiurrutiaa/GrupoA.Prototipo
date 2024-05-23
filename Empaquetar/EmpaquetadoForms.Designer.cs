namespace GrupoA.Prototipo.Empaquetar
{
    partial class EmpaquetadoForms
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
            EmpaquetarlistBox = new ListBox();
            EmpaquetarButton = new Button();
            AtrasButton = new Button();
            NroOrdenLabel = new Label();
            SuspendLayout();
            // 
            // EmpaquetarlistBox
            // 
            EmpaquetarlistBox.FormattingEnabled = true;
            EmpaquetarlistBox.ItemHeight = 15;
            EmpaquetarlistBox.Location = new Point(12, 33);
            EmpaquetarlistBox.Name = "EmpaquetarlistBox";
            EmpaquetarlistBox.Size = new Size(467, 94);
            EmpaquetarlistBox.TabIndex = 0;
            // 
            // EmpaquetarButton
            // 
            EmpaquetarButton.Location = new Point(379, 133);
            EmpaquetarButton.Name = "EmpaquetarButton";
            EmpaquetarButton.Size = new Size(100, 25);
            EmpaquetarButton.TabIndex = 1;
            EmpaquetarButton.Text = "Empaquetar";
            EmpaquetarButton.UseVisualStyleBackColor = true;
            EmpaquetarButton.Click += EmpaquetarButton_Click;
            // 
            // AtrasButton
            // 
            AtrasButton.Location = new Point(379, 225);
            AtrasButton.Name = "AtrasButton";
            AtrasButton.Size = new Size(100, 25);
            AtrasButton.TabIndex = 2;
            AtrasButton.Text = "Volver al menu";
            AtrasButton.UseVisualStyleBackColor = true;
            AtrasButton.Click += AtrasButton_Click;
            // 
            // NroOrdenLabel
            // 
            NroOrdenLabel.AutoSize = true;
            NroOrdenLabel.Location = new Point(12, 15);
            NroOrdenLabel.Name = "NroOrdenLabel";
            NroOrdenLabel.Size = new Size(85, 15);
            NroOrdenLabel.TabIndex = 3;
            NroOrdenLabel.Text = "Nro de Orden: ";
            // 
            // EmpaquetadoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 262);
            Controls.Add(NroOrdenLabel);
            Controls.Add(AtrasButton);
            Controls.Add(EmpaquetarButton);
            Controls.Add(EmpaquetarlistBox);
            Name = "EmpaquetadoForms";
            Text = "Empaquetar";
            Load += EmpaquetadoForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox EmpaquetarlistBox;
        private Button EmpaquetarButton;
        private Button AtrasButton;
        private Label NroOrdenLabel;
    }
}