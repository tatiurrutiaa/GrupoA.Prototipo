namespace GrupoA.Prototipo
{
    partial class IniciarSesionForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botonIngresar = new Button();
            textBoxUsuario = new TextBox();
            labelUsuario = new Label();
            labelContraseña = new Label();
            textBoxContraseña = new TextBox();
            SuspendLayout();
            // 
            // botonIngresar
            // 
            botonIngresar.Location = new Point(100, 130);
            botonIngresar.Name = "botonIngresar";
            botonIngresar.Size = new Size(75, 23);
            botonIngresar.TabIndex = 0;
            botonIngresar.Text = "Ingresar";
            botonIngresar.UseVisualStyleBackColor = true;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(56, 45);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(169, 23);
            textBoxUsuario.TabIndex = 1;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(56, 27);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(47, 15);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuario";
            //labelUsuario.Click += this.label1_Click;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(56, 83);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(67, 15);
            labelContraseña.TabIndex = 4;
            labelContraseña.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(56, 101);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(169, 23);
            textBoxContraseña.TabIndex = 3;
            // 
            // IniciarSesionForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 175);
            Controls.Add(labelContraseña);
            Controls.Add(textBoxContraseña);
            Controls.Add(labelUsuario);
            Controls.Add(textBoxUsuario);
            Controls.Add(botonIngresar);
            Name = "IniciarSesionForms";
            Text = "Iniciar Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonIngresar;
        private TextBox textBoxUsuario;
        private Label labelUsuario;
        private Label labelContraseña;
        private TextBox textBoxContraseña;
    }
}
