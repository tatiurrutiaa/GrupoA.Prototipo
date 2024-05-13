namespace GrupoA.Prototipo.Empaquetado
{
    partial class EmpaquetarForm
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
            StockList = new ListView();
            MercaderiaCol = new ColumnHeader();
            CodPedidoCol = new ColumnHeader();
            CantidadCol = new ColumnHeader();
            CuitCol = new ColumnHeader();
            TrasnportistaCol = new ColumnHeader();
            SuspendLayout();
            // 
            // StockList
            // 
            StockList.Columns.AddRange(new ColumnHeader[] { MercaderiaCol, CodPedidoCol, CantidadCol, CuitCol, TrasnportistaCol });
            StockList.GridLines = true;
            StockList.Location = new Point(15, 43);
            StockList.Name = "StockList";
            StockList.Size = new Size(710, 137);
            StockList.TabIndex = 0;
            StockList.UseCompatibleStateImageBehavior = false;
            // 
            // EmpaquetarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
            Controls.Add(StockList);
            Name = "EmpaquetarForm";
            Text = "EmpaquetarForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView StockList;
        private ColumnHeader MercaderiaCol;
        private ColumnHeader CodPedidoCol;
        private ColumnHeader CantidadCol;
        private ColumnHeader CuitCol;
        private ColumnHeader TrasnportistaCol;
    }
}