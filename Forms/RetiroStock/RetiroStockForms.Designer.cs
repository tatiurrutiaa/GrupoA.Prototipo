namespace GrupoA.Prototipo
{
    partial class RetiroStockForms
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
            botonRetirarStock = new Button();
            botonMenu = new Button();
            comboBoxOrdenSelec = new ComboBox();
            groupBoxRetirarMercaderia = new GroupBox();
            listViewRetiroStock = new ListView();
            botonAtras = new Button();
            botonBuscar = new Button();
            groupBoxOrdenSelec = new GroupBox();
            groupBoxRetirarMercaderia.SuspendLayout();
            groupBoxOrdenSelec.SuspendLayout();
            SuspendLayout();
            // 
            // botonRetirarStock
            // 
            botonRetirarStock.Location = new Point(87, 274);
            botonRetirarStock.Name = "botonRetirarStock";
            botonRetirarStock.Size = new Size(276, 23);
            botonRetirarStock.TabIndex = 15;
            botonRetirarStock.Text = "Retirar Stock";
            botonRetirarStock.UseVisualStyleBackColor = true;
            botonRetirarStock.Click += botonRetirarStock_Click;
            // 
            // botonMenu
            // 
            botonMenu.Location = new Point(18, 393);
            botonMenu.Name = "botonMenu";
            botonMenu.Size = new Size(109, 23);
            botonMenu.TabIndex = 16;
            botonMenu.Text = "Volver al Menu";
            botonMenu.UseVisualStyleBackColor = true;
            botonMenu.Click += botonMenu_Click;
            // 
            // comboBoxOrdenSelec
            // 
            comboBoxOrdenSelec.FormattingEnabled = true;
            comboBoxOrdenSelec.Location = new Point(6, 22);
            comboBoxOrdenSelec.Name = "comboBoxOrdenSelec";
            comboBoxOrdenSelec.Size = new Size(194, 23);
            comboBoxOrdenSelec.TabIndex = 19;
            // 
            // groupBoxRetirarMercaderia
            // 
            groupBoxRetirarMercaderia.Controls.Add(listViewRetiroStock);
            groupBoxRetirarMercaderia.Controls.Add(botonAtras);
            groupBoxRetirarMercaderia.Controls.Add(botonRetirarStock);
            groupBoxRetirarMercaderia.Enabled = false;
            groupBoxRetirarMercaderia.Location = new Point(12, 84);
            groupBoxRetirarMercaderia.Name = "groupBoxRetirarMercaderia";
            groupBoxRetirarMercaderia.Size = new Size(369, 303);
            groupBoxRetirarMercaderia.TabIndex = 21;
            groupBoxRetirarMercaderia.TabStop = false;
            groupBoxRetirarMercaderia.Text = "Mercadería a Retirar";
            // 
            // listViewRetiroStock
            // 
            listViewRetiroStock.Location = new Point(6, 22);
            listViewRetiroStock.Name = "listViewRetiroStock";
            listViewRetiroStock.Size = new Size(357, 246);
            listViewRetiroStock.TabIndex = 25;
            listViewRetiroStock.UseCompatibleStateImageBehavior = false;
            // 
            // botonAtras
            // 
            botonAtras.Location = new Point(6, 274);
            botonAtras.Name = "botonAtras";
            botonAtras.Size = new Size(75, 23);
            botonAtras.TabIndex = 24;
            botonAtras.Text = "Atras";
            botonAtras.UseVisualStyleBackColor = true;
            botonAtras.Click += botonAtras_Click;
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(206, 21);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(75, 23);
            botonBuscar.TabIndex = 22;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // groupBoxOrdenSelec
            // 
            groupBoxOrdenSelec.Controls.Add(comboBoxOrdenSelec);
            groupBoxOrdenSelec.Controls.Add(botonBuscar);
            groupBoxOrdenSelec.Location = new Point(12, 12);
            groupBoxOrdenSelec.Name = "groupBoxOrdenSelec";
            groupBoxOrdenSelec.Size = new Size(291, 57);
            groupBoxOrdenSelec.TabIndex = 23;
            groupBoxOrdenSelec.TabStop = false;
            groupBoxOrdenSelec.Text = "Orden de Selección";
            // 
            // RetiroStockForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 431);
            Controls.Add(groupBoxOrdenSelec);
            Controls.Add(groupBoxRetirarMercaderia);
            Controls.Add(botonMenu);
            Name = "RetiroStockForms";
            Text = "Retiro de stock";
            FormClosed += RetiroStockForms_FormClosed;
            Load += RetiroStockForms_Load;
            groupBoxRetirarMercaderia.ResumeLayout(false);
            groupBoxOrdenSelec.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button botonRetirarStock;
        private Button botonMenu;
        private ComboBox comboBoxOrdenSelec;
        private GroupBox groupBoxRetirarMercaderia;
        private Button botonBuscar;
        private GroupBox groupBoxOrdenSelec;
        private Button botonAtras;
        private ListView listViewRetiroStock;
    }
}