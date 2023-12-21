namespace tiendaMY
{
    partial class Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inventarioDGV = new System.Windows.Forms.DataGridView();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarPB = new System.Windows.Forms.DataGridViewImageColumn();
            this.inventarioLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // inventarioDGV
            // 
            this.inventarioDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoColumn,
            this.nombreColumn,
            this.descripcionColumn,
            this.cantidadColumn,
            this.precioCompraColumn,
            this.precioVentaColumn,
            this.eliminarPB});
            this.inventarioDGV.Location = new System.Drawing.Point(71, 101);
            this.inventarioDGV.Name = "inventarioDGV";
            this.inventarioDGV.RowHeadersWidth = 51;
            this.inventarioDGV.RowTemplate.Height = 24;
            this.inventarioDGV.Size = new System.Drawing.Size(879, 492);
            this.inventarioDGV.TabIndex = 0;
            this.inventarioDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventarioDGV_CellContentClick);
            // 
            // codigoColumn
            // 
            this.codigoColumn.HeaderText = "Codigo";
            this.codigoColumn.MinimumWidth = 6;
            this.codigoColumn.Name = "codigoColumn";
            this.codigoColumn.Width = 85;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.MinimumWidth = 6;
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.Width = 125;
            // 
            // descripcionColumn
            // 
            this.descripcionColumn.HeaderText = "Descripcion";
            this.descripcionColumn.MinimumWidth = 6;
            this.descripcionColumn.Name = "descripcionColumn";
            this.descripcionColumn.Width = 125;
            // 
            // cantidadColumn
            // 
            this.cantidadColumn.HeaderText = "Cantidad";
            this.cantidadColumn.MinimumWidth = 6;
            this.cantidadColumn.Name = "cantidadColumn";
            this.cantidadColumn.Width = 65;
            // 
            // precioCompraColumn
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.precioCompraColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.precioCompraColumn.HeaderText = "Precio Compra";
            this.precioCompraColumn.MinimumWidth = 6;
            this.precioCompraColumn.Name = "precioCompraColumn";
            this.precioCompraColumn.Width = 65;
            // 
            // precioVentaColumn
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.precioVentaColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.precioVentaColumn.HeaderText = "Precio Venta";
            this.precioVentaColumn.MinimumWidth = 6;
            this.precioVentaColumn.Name = "precioVentaColumn";
            this.precioVentaColumn.Width = 65;
            // 
            // eliminarPB
            // 
            this.eliminarPB.HeaderText = "Eliminar";
            this.eliminarPB.MinimumWidth = 6;
            this.eliminarPB.Name = "eliminarPB";
            this.eliminarPB.Width = 55;
            // 
            // inventarioLbl
            // 
            this.inventarioLbl.AutoSize = true;
            this.inventarioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioLbl.Location = new System.Drawing.Point(403, 23);
            this.inventarioLbl.Name = "inventarioLbl";
            this.inventarioLbl.Size = new System.Drawing.Size(203, 46);
            this.inventarioLbl.TabIndex = 1;
            this.inventarioLbl.Text = "Inventario";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.refreshBtn.Location = new System.Drawing.Point(411, 639);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(233, 42);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Actualizar";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 693);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.inventarioLbl);
            this.Controls.Add(this.inventarioDGV);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventario_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventarioDGV;
        private System.Windows.Forms.Label inventarioLbl;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaColumn;
        private System.Windows.Forms.DataGridViewImageColumn eliminarPB;
    }
}