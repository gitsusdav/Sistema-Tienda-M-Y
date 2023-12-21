namespace tiendaMY
{
    partial class FiltroLINQ
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.busquedaTB = new System.Windows.Forms.TextBox();
            this.listaProductos = new System.Windows.Forms.DataGridView();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(12, 38);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(416, 42);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Busqueda de producto";
            // 
            // busquedaTB
            // 
            this.busquedaTB.Location = new System.Drawing.Point(123, 109);
            this.busquedaTB.Name = "busquedaTB";
            this.busquedaTB.Size = new System.Drawing.Size(257, 22);
            this.busquedaTB.TabIndex = 1;
            this.busquedaTB.TextChanged += new System.EventHandler(this.busquedaTB_TextChanged);
            // 
            // listaProductos
            // 
            this.listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreColumn,
            this.codigoColumn});
            this.listaProductos.Location = new System.Drawing.Point(95, 161);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.RowHeadersWidth = 51;
            this.listaProductos.RowTemplate.Height = 24;
            this.listaProductos.Size = new System.Drawing.Size(306, 375);
            this.listaProductos.TabIndex = 2;
            this.listaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.MinimumWidth = 6;
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.Width = 125;
            // 
            // codigoColumn
            // 
            this.codigoColumn.HeaderText = "Codigo";
            this.codigoColumn.MinimumWidth = 6;
            this.codigoColumn.Name = "codigoColumn";
            this.codigoColumn.Width = 85;
            // 
            // FiltroLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 611);
            this.Controls.Add(this.listaProductos);
            this.Controls.Add(this.busquedaTB);
            this.Controls.Add(this.tituloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FiltroLINQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiltroLINQ";
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TextBox busquedaTB;
        private System.Windows.Forms.DataGridView listaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColumn;
    }
}