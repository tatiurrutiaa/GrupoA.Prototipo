namespace GrupoA.Prototipo
{
    partial class Despacho
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
            SuspendLayout();
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(12, 34);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(235, 200);
            checkedListBox2.TabIndex = 26;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // Cantid
            // 
            Cantid.AutoSize = true;
            Cantid.Location = new Point(12, 6);
            Cantid.Margin = new Padding(4, 0, 4, 0);
            Cantid.Name = "Cantid";
            Cantid.Size = new Size(271, 25);
            Cantid.TabIndex = 25;
            Cantid.Text = "Lista de Pendientes de Despacho";
            //Cantid.Click += this.Cantid_Click;
            // 
            // Despacho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox2);
            Controls.Add(Cantid);
            Name = "Despacho";
            Text = "Despacho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox2;
        private Label Cantid;
    }
}