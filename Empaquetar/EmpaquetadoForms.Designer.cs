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
            SuspendLayout();
            // 
            // EmpaquetarlistBox
            // 
            EmpaquetarlistBox.FormattingEnabled = true;
            EmpaquetarlistBox.ItemHeight = 15;
            EmpaquetarlistBox.Location = new Point(12, 30);
            EmpaquetarlistBox.Name = "EmpaquetarlistBox";
            EmpaquetarlistBox.Size = new Size(265, 94);
            EmpaquetarlistBox.TabIndex = 0;
            // 
            // EmpaquetarButton
            // 
            EmpaquetarButton.Location = new Point(192, 132);
            EmpaquetarButton.Name = "EmpaquetarButton";
            EmpaquetarButton.Size = new Size(85, 25);
            EmpaquetarButton.TabIndex = 1;
            EmpaquetarButton.Text = "Empaquetar";
            EmpaquetarButton.UseVisualStyleBackColor = true;
            // 
            // AtrasButton
            // 
            AtrasButton.Location = new Point(121, 132);
            AtrasButton.Name = "AtrasButton";
            AtrasButton.Size = new Size(65, 25);
            AtrasButton.TabIndex = 2;
            AtrasButton.Text = "Atras";
            AtrasButton.UseVisualStyleBackColor = true;
            AtrasButton.Click += AtrasButton_Click;
            // 
            // EmpaquetadoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 183);
            Controls.Add(AtrasButton);
            Controls.Add(EmpaquetarButton);
            Controls.Add(EmpaquetarlistBox);
            Name = "EmpaquetadoForms";
            Text = "Empaquetar";
            Load += EmpaquetadoForms_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox EmpaquetarlistBox;
        private Button EmpaquetarButton;
        private Button AtrasButton;
    }
}