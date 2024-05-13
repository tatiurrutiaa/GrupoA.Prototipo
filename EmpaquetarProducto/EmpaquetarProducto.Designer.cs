namespace GrupoA.Prototipo
{
    partial class EmpaquetarProducto
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
            label1 = new Label();
            botonAceptar = new Button();
            botonAtras = new Button();
            listView1 = new ListView();
            label2 = new Label();
            ID_Pedido = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // botonAceptar
            // 
            botonAceptar.Location = new Point(514, 240);
            botonAceptar.Name = "botonAceptar";
            botonAceptar.Size = new Size(75, 23);
            botonAceptar.TabIndex = 24;
            botonAceptar.Text = "Aceptar";
            botonAceptar.UseVisualStyleBackColor = true;
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(403, 240);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(75, 23);
            botonAtras.TabIndex = 25;
            botonAtras.Text = "Atrás";
            botonAtras.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID_Pedido });
            listView1.Location = new Point(22, 32);
            listView1.Name = "listView1";
            listView1.Size = new Size(573, 90);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            //listView1.SelectedIndexChanged += this.listView1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 10);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 27;
            label2.Text = "Pedidos para empaquetar";
            // 
            // EmpaquetarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 275);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(botonAtras);
            Controls.Add(botonAceptar);
            Controls.Add(label1);
            Name = "EmpaquetarProducto";
            Text = "EmpaquetarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button botonAceptar;
        private Button botonAtras;
        private ListView listView1;
        private Label label2;
        private ColumnHeader ID_Pedido;
    }
}