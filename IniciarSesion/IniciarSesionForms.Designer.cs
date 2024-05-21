namespace GrupoA.Prototipo
{
    partial class IniciarSesionForms
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
            botonIngresar = new Button();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // botonIngresar
            // 
            botonIngresar.Location = new Point(85, 136);
            botonIngresar.Name = "botonIngresar";
            botonIngresar.Size = new Size(75, 23);
            botonIngresar.TabIndex = 0;
            botonIngresar.Text = "Ingresar";
            botonIngresar.UseVisualStyleBackColor = true;
            botonIngresar.Click += botonIngresar_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(50, 43);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(144, 23);
            textBoxUsuario.TabIndex = 1;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(50, 97);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.Size = new Size(144, 23);
            textBoxContraseña.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 79);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // IniciarSesionForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 183);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(botonIngresar);
            Name = "IniciarSesionForms";
            Text = "IniciarSesion";
            Load += IniciarSesionForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonIngresar;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Label label1;
        private Label label2;
    }
}