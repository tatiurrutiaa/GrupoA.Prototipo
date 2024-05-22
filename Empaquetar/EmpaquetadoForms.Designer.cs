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
            SuspendLayout();
            // 
            // EmpaquetarlistBox
            // 
            EmpaquetarlistBox.FormattingEnabled = true;
            EmpaquetarlistBox.ItemHeight = 15;
            EmpaquetarlistBox.Location = new Point(12, 30);
            EmpaquetarlistBox.Name = "EmpaquetarlistBox";
            EmpaquetarlistBox.Size = new Size(247, 94);
            EmpaquetarlistBox.TabIndex = 0;
            // 
            // EmpaquetarButton
            // 
            EmpaquetarButton.Location = new Point(172, 133);
            EmpaquetarButton.Name = "EmpaquetarButton";
            EmpaquetarButton.Size = new Size(85, 25);
            EmpaquetarButton.TabIndex = 1;
            EmpaquetarButton.Text = "Empaquetar";
            EmpaquetarButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 183);
            Controls.Add(EmpaquetarButton);
            Controls.Add(EmpaquetarlistBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox EmpaquetarlistBox;
        private Button EmpaquetarButton;
    }
}