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
            botonIngresar.Location = new Point(143, 217);
            botonIngresar.Margin = new Padding(4, 5, 4, 5);
            botonIngresar.Name = "botonIngresar";
            botonIngresar.Size = new Size(107, 38);
            botonIngresar.TabIndex = 0;
            botonIngresar.Text = "Ingresar";
            botonIngresar.UseVisualStyleBackColor = true;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(80, 75);
            textBoxUsuario.Margin = new Padding(4, 5, 4, 5);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(240, 31);
            textBoxUsuario.TabIndex = 1;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(80, 45);
            labelUsuario.Margin = new Padding(4, 0, 4, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(72, 25);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(80, 138);
            labelContraseña.Margin = new Padding(4, 0, 4, 0);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(101, 25);
            labelContraseña.TabIndex = 4;
            labelContraseña.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(80, 168);
            textBoxContraseña.Margin = new Padding(4, 5, 4, 5);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(240, 31);
            textBoxContraseña.TabIndex = 3;
            // 
            // IniciarSesionForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 292);
            Controls.Add(labelContraseña);
            Controls.Add(textBoxContraseña);
            Controls.Add(labelUsuario);
            Controls.Add(textBoxUsuario);
            Controls.Add(botonIngresar);
            Margin = new Padding(4, 5, 4, 5);
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
